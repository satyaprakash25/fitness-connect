namespace GL.FC.Shared
{
    public class LikesModel : ModelBase
    {
        public int PostId { get; set; }

        public PostModel Post { get; set; }

        public int LikedById { get; set; }

        public UserProfileModel LikedBy { get; set; }
    }
}
