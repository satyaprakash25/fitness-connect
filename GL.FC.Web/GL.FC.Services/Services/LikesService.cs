using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class LikesService : BaseService<LikesModel, LikesEntity>, ILikesService
    {
        public LikesService(ILikesRepository likesRepository, IMapper mapper) : base(likesRepository, mapper)
        {


        }
    }
}
