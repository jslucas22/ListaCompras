using ListaCompras.Domain.Models.Authentication;
using ListaCompras.Domain.Models.User;
using ListaComrpas.Data.Repositories.Abstractions.User;

namespace ListaComrpas.Data.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        public async Task<UserLoginResponse> Login(UserLoginRequest model)
        {
            throw new NotImplementedException();
        }

        public async Task Register(UserRegisterRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
