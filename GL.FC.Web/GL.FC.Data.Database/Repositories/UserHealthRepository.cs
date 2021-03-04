namespace GL.FC.Data.Database
{
    public class UserHealthRepository : Repository<UserHealthEntity>, IUserHealthRepository
    {
        public UserHealthRepository(DataContext context) : base(context)
        {

        }
    }
}
