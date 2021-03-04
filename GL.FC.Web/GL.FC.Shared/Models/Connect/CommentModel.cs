
namespace GL.FC.Shared
{
    public class CommentModel : ModelBase
    {
        public string Description { get; set; }

        public int PostId { get; set; }

        public PostModel Post { get; set; }

        public int CommentedById { get; set; }

        public UserProfileModel CommentedBy { get; set; }
    }
}
