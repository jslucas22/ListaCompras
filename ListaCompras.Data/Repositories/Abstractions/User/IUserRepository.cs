using ListaCompras.Domain.Models.Authentication;
using ListaCompras.Domain.Models.User;

namespace ListaComrpas.Data.Repositories.Abstractions.User
{
    public interface IUserRepository
    {
        Task<UserLoginResponse> GetAsync(UserLoginRequest model);
        
        Task CreateAsync(UserRegisterRequest model);

        Task EditAsync(UserEditRequest model);
        
        Task DeleteAsync(string id);
    }
}
