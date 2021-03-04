using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class CommentService : BaseService<CommentModel, CommentEntity>, ICommentService
    {
        public CommentService(ICommentRepository commentRepository, IMapper mapper) : base(commentRepository, mapper)
        {


        }
    }
}
