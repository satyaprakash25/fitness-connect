using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class PostService : BaseService<PostModel, PostEntity>, IPostService
    {
        public PostService(IPostRepository postRepository, IMapper mapper) : base(postRepository, mapper)
        {


        }
    }
}
