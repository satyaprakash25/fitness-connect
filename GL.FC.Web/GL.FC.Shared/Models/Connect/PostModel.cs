using System.Collections.Generic;

namespace GL.FC.Shared
{
    public class PostModel : ModelBase
    {
        public string Heading { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Tags { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel Category { get; set; }

        public int CreatedBy { get; set; }

        public UserProfileModel CreatedByUser { get; set; }

        private IList<PostImagesModel> postImages;

        public IList<PostImagesModel> PostImages
        {
            get { return postImages ?? new List<PostImagesModel>(); }
            set { postImages = value; }
        }

        private IList<LikesModel> likesList;

        public IList<LikesModel> LikesList
        {
            get { return likesList ?? new List<LikesModel>(); }
            set { likesList = value; }
        }

        private IList<CommentModel> commentList;

        public IList<CommentModel> CommentList
        {
            get { return commentList ?? new List<CommentModel>(); }
            set { commentList = value; }
        }


    }
}
