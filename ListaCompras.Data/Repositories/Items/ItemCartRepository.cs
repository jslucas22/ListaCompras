using ListaCompras.Domain.Models.Items;
using ListaComrpas.Data.Repositories.Abstractions.Items;

namespace ListaComrpas.Data.Repositories.Items
{
    public class ItemCartRepository : IItemCartRepository
    {
        public Task CreateAsync(ItemsCartRequest model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id_user, string id_cart)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(ItemsCartRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemsCartResponse>> GetAllActiveAsync(string id_user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemsCartResponse>> GetAllInactiveAsync(string id_user)
        {
            throw new NotImplementedException();
        }

        public Task<ItemsCartResponse> GetAsync(string id_user, string id_cart)
        {
            throw new NotImplementedException();
        }
    }
}
