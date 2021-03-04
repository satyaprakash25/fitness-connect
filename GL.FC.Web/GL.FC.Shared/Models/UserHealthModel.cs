namespace GL.FC.Shared
{
    public class UserHealthModel : ModelBase
    {
        public int UserId { get; set; }

        public UserProfileModel UserProfile { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }
    }
}
