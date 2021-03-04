namespace GL.FC.Data.Database
{
    public class CommentRepository : Repository<CommentEntity>, ICommentRepository
    {
        public CommentRepository(DataContext context) : base(context)
        {

        }
    }
}
