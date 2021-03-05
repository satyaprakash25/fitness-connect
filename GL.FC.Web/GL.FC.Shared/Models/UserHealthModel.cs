namespace GL.FC.Shared
{
    public class UserHealthModel : ModelBase
    {
        public int UserId { get; set; }

        public UserProfileModel UserProfile { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public double Abdomen { get; set; }

        public double Neck { get; set; }
    }
}
