using GL.FC.Shared;

namespace GL.FC.Services
{
    public interface ILikesService : IBaseServices<LikesModel>
    {
        LikesModel AlreadyLikedData(int postId, int userId);
    }
}
