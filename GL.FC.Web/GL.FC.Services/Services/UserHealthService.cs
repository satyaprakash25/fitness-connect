using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class UserHealthService : BaseService<UserHealthModel, UserHealthEntity>, IUserHealthService
    {
        public UserHealthService(IUserHealthRepository userHealthRepository, IMapper mapper)
            : base(userHealthRepository, mapper)
        {
        }
    }
}
