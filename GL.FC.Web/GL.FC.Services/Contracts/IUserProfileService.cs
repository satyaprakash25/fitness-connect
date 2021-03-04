using GL.FC.Shared;

namespace GL.FC.Services
{
    public interface IUserProfileService : IBaseServices<UserProfileModel>
    {
        UserProfileModel GetUserByEmail(string email);
    }
}
