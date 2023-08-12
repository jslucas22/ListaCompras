using ListaCompras.Domain.Models.Authentication;
using ListaCompras.Domain.Models.User;

namespace ListaComrpas.Business.Services.Abstractions.User
{
    public interface IUserService
    {
        Task<UserLoginResponse> Login(UserLoginRequest model);

        Task Register(UserRegisterRequest model);
    }
}
