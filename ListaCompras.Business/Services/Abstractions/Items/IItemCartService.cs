using ListaCompras.Domain.Models.Items;

namespace ListaComrpas.Business.Services.Abstractions.Items
{
    public interface IItemCartService
    {
        Task CreateAsync(ItemsCartRequest model);

        Task EditAsync(ItemsCartRequest model);

        Task<ItemsCartResponse> GetAsync(string id_user, string id_cart);

        Task<IEnumerable<ItemsCartResponse>> GetAllActiveAsync(string id_user);

        Task<IEnumerable<ItemsCartResponse>> GetAllInactiveAsync(string id_user);

        Task DeleteAsync(string id_user, string id_cart);
    }
}
