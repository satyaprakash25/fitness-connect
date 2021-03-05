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

        public LikesModel AlreadyLikedData(int postId, int userId)
        {
            return _mapper.Map<LikesModel>(_repository.FirstOrDefault(a => a.LikedById == userId && a.PostId == postId, ""));
        }
    }
}
