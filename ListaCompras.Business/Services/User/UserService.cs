using ListaCompras.Domain.Models.Authentication;
using ListaCompras.Domain.Models.User;
using ListaComrpas.Business.Services.Abstractions.User;
using ListaComrpas.Data.Repositories.Abstractions.User;

namespace ListaComrpas.Business.Services.User
{
    public class UserService : IUserService
    {
        #region ..:: Variables ::..

        private readonly IUserRepository _repository;

        #endregion

        #region ..:: Constructor ::..

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region ..:: Methods ::..

        public async Task<UserLoginResponse> Login(UserLoginRequest model)
        {
            return await _repository.GetAsync(model);
        }

        public async Task Register(UserRegisterRequest model)
        {
            await _repository.CreateAsync(model);
        } 

        #endregion
    }
}
