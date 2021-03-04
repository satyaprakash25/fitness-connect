namespace GL.FC.Data.Database
{
    public class UserProfileRepository : Repository<UserProfileEntity>, IUserProfileRepository
    {
        public UserProfileRepository(DataContext context) : base(context)
        {
                
        }

    }
}
