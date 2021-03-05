using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class UserProfileService : BaseService<UserProfileModel, UserProfileEntity>, IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository, IMapper mapper)
            : base(userProfileRepository, mapper)
        {
            _userProfileRepository = userProfileRepository;
        }

        public UserProfileModel GetUserByEmail(string email)
        {
            return _mapper.Map<UserProfileModel>(_userProfileRepository.FirstOrDefault(a => a.Email.Equals(email),
                "UserHealthDetails"));
        }
    }
}
