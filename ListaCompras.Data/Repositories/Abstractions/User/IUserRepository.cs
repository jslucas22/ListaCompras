using ListaCompras.Domain.Models.Authentication;
using ListaCompras.Domain.Models.User;

namespace ListaComrpas.Data.Repositories.Abstractions.User
{
    public interface IUserRepository
    {
        Task<UserLoginResponse> Login(UserLoginRequest model);

        Task Register(UserRegisterRequest model);
    }
}
