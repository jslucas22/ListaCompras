using ListaCompras.Domain.Models.Items;
using ListaComrpas.Data.Repositories.Abstractions.Items;

namespace ListaComrpas.Data.Repositories.Items
{
    public class ItemProductRepository : IItemProductRepository
    {
        public Task CreateAsync(ItemsProductRequest model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id_user, string id_product)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(ItemsProductRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemsProductResponse>> GetAllActiveAsync(string id_user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemsProductResponse>> GetAllInactiveAsync(string id_user)
        {
            throw new NotImplementedException();
        }

        public Task<ItemsProductResponse> GetAsync(string id_user, string id_product)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(string id_user, string id_product)
        {
            throw new NotImplementedException();
        }
    }
}
