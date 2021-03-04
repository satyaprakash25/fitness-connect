using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class PostImagesService : BaseService<PostImagesModel, PostImagesEntity>, IPostImagesService
    {
        public PostImagesService(IPostImagesRepository postImagesRepository, IMapper mapper) : base(postImagesRepository, mapper)
        {


        }
    }
}
