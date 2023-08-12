using ListaCompras.Domain.Models.Items;

namespace ListaComrpas.Business.Services.Abstractions.Items
{
    public interface IItemProductService
    {
        Task CreateAsync(ItemsProductRequest model);

        Task EditAsync(ItemsProductRequest model);

        Task<ItemsProductResponse> GetAsync(string id_user, string id_product);

        Task<IEnumerable<ItemsProductResponse>> GetAllActiveAsync(string id_user);

        Task<IEnumerable<ItemsProductResponse>> GetAllInactiveAsync(string id_user);

        Task SoftDeleteAsync(string id_user, string id_product);

        Task DeleteAsync(string id_user, string id_product);
    }
}
