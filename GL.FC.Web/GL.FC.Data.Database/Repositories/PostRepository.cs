namespace GL.FC.Data.Database
{
    public class PostRepository : Repository<PostEntity>, IPostRepository
    {
        public PostRepository(DataContext context) : base(context)
        {

        }
    }
}
