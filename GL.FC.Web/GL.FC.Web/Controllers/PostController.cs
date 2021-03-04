using GL.FC.Services;
using GL.FC.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace GL.FC.Web
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IUserProfileService _userProfileService;
        private readonly IPostService _postService;
        private readonly IPostImagesService _postImagesService;
        private readonly IWebHostEnvironment _env;
        private readonly ICategoryService _categoryService;

        public PostController(IUserProfileService userProfileService, IPostService postService,
            IPostImagesService postImagesService, IWebHostEnvironment env, ICategoryService categoryService)
        {
            _userProfileService = userProfileService;
            _postService = postService;
            _postImagesService = postImagesService;
            _env = env;
            _categoryService = categoryService;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Connect()
        {
            ViewBag.CategoryList = _categoryService.GetAll(string.Empty);
            IList<PostModel> result = _postService.GetAll("PostImages,CreatedByUser,Category").OrderByDescending(a=>a.CreationDate).ToList();
            return View(result ?? new List<PostModel>());
        }

        [HttpPost]
        public IActionResult Connect(PostViewModel postVM)
        {
            if (ModelState.IsValid)
            {
                var loggedInUserEmail = User.FindFirst(ClaimTypes.Email).Value;

                UserProfileModel user = _userProfileService.GetUserByEmail(loggedInUserEmail);

                PostModel newPost = new PostModel
                {
                    CategoryId = postVM.CategoryId,
                    Description = postVM.Description,
                    CreatedBy = user.Id,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                };

                PostModel addedPost = _postService.Add(newPost);

                if (postVM.Files != null && postVM.Files.Count > 0)
                {
                    foreach (var item in postVM.Files)
                    {
                        string fileName = string.Empty;
                        if (item.Length > 0)
                        {
                            fileName = $"{Guid.NewGuid().ToString().Substring(0, 6)}_{Path.GetFileNameWithoutExtension(item.FileName)}.{Path.GetExtension(item.FileName)}";
                            var uploads = Path.Combine(_env.WebRootPath, "uploads/posts");
                            string filePath = Path.Combine(uploads, fileName);
                            item.CopyTo(new FileStream(filePath, FileMode.Create));
                        }

                        PostImagesModel newPostImage = new PostImagesModel
                        {
                            ImagePath = fileName,
                            PostId = addedPost.Id,
                            CreationDate = DateTime.Now,
                            ModificationDate = DateTime.Now,
                        };

                        _postImagesService.Add(newPostImage);
                    }
                }
                return RedirectToAction("connect");
            }

            else
            {
                return View(postVM);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("connect");
        }


    }
}
