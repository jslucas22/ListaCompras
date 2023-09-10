using ListaCompras.Domain.Models.Product;

namespace ListaCompras.Data.Repositories.Abstractions.Product
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductRequest model);

        Task EditAsync(ProductResponse model);

        Task<ProductResponse> GetAsync(string id_product);

        Task<IEnumerable<ProductResponse>> GetAllActiveAsync(string id_product);

        Task<IEnumerable<ProductResponse>> GetAllInactiveAsync(string id_product);

        Task DeleteAsync(string id_product);
    }
}
