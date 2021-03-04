namespace GL.FC.Data.Database
{
    public class PostImagesRepository : Repository<PostImagesEntity>, IPostImagesRepository
    {
        public PostImagesRepository(DataContext context) : base(context)
        {

        }
    }
}
