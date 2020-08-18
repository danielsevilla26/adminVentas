
using AdminVentas.Application.Contracts.Services;
using AdminVentas.Business.Models;
using AdminVentas.DataAccess.Contracts.Repositories;
using AdminVentas.DataAccess.Mappers;
using System.Threading.Tasks;

namespace AdminVentas.Application.Services
{
    public class UserService : IUserService
    {
        /// <summary>
        /// Propiedad de acceso para UserEntity (se instancia una variable privada de tipo readonly -no debe ser modificado-)
        /// </summary>
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Constructor que se le inyecta una dependencia
        /// </summary>
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> GetUserEmail(int id)
        {
            var entity = await _userRepository.Get(id);

            return entity.Email;
        }

        public async Task<User> AddUser(User user)
        {
            var addedEntity = await _userRepository.AddAsync(UserMapper.Map(user));

            return UserMapper.Map(addedEntity);
        }
    }
}
