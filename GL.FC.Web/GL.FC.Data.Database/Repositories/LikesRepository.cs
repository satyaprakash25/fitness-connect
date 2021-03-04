namespace GL.FC.Data.Database
{
    public class LikesRepository : Repository<LikesEntity>, ILikesRepository
    {
        public LikesRepository(DataContext context) : base(context)
        {

        }

    }
}
