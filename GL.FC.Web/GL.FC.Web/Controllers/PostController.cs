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
        private readonly ILikesService _likesService;
        private readonly ICommentService _commentService;

        public PostController(IUserProfileService userProfileService, IPostService postService,
            IPostImagesService postImagesService, IWebHostEnvironment env, ICategoryService categoryService,
            ILikesService likesService, ICommentService commentService)
        {
            _userProfileService = userProfileService;
            _postService = postService;
            _postImagesService = postImagesService;
            _env = env;
            _categoryService = categoryService;
            _likesService = likesService;
            _commentService = commentService;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Connect()
        {
            ViewBag.CategoryList = _categoryService.GetAll(string.Empty);
            IList<PostModel> result = _postService.GetAll("PostImages,CreatedByUser,Category,LikesList,CommentList,CommentList.CommentedBy").OrderByDescending(a => a.CreationDate).ToList();
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
            if (id > 0)
            {
                _postService.Remove(id);
            }
            return RedirectToAction("connect");
        }

        [HttpPost]
        public IActionResult Like(int postId)
        {
            if (postId > 0)
            {
                PostModel post = _postService.GetById(postId, "");

                if (post != null)
                {
                    LikesModel alreadyLiked = _likesService.AlreadyLikedData(postId, Convert.ToInt32(User.FindFirst("Id").Value));

                    if (alreadyLiked == null)
                    {
                        LikesModel like = new LikesModel
                        {
                            PostId = postId,
                            LikedById = Convert.ToInt32(User.FindFirst("Id").Value),
                            CreationDate = DateTime.Now,
                            ModificationDate = DateTime.Now,
                        };
                        _likesService.Add(like);
                        return Ok("add");
                    }

                    else
                    {
                        _likesService.Remove(alreadyLiked.Id);
                        return Ok("remove");
                    }



                }
                return BadRequest();
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Comment(int postId, string description)
        {
            if (postId > 0)
            {
                CommentModel comment = new CommentModel
                {
                    PostId = postId,
                    CommentedById = Convert.ToInt32(User.FindFirst("Id").Value),
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    Description = description,
                };

                _commentService.Add(comment);

                return RedirectToAction("connect");
            }
            return RedirectToAction("connect");
        }

        [HttpPost]
        public IActionResult DeleteComment(int commentId)
        {
            if (commentId > 0)
            {
                _commentService.Remove(commentId);
                return RedirectToAction("connect");
            }
            return RedirectToAction("connect");

        }
    }
}
