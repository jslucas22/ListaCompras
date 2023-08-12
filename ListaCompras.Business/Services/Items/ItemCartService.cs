using ListaCompras.Domain.Models.Items;
using ListaComrpas.Business.Services.Abstractions.Items;
using ListaComrpas.Data.Repositories.Abstractions.Items;

namespace ListaComrpas.Business.Services.Items
{
    public class ItemCartService : IItemCartService
    {
        #region ..:: Variables ::..

        private IItemCartRepository _repository;

        #endregion

        #region ..:: Constructor ::..

        public ItemCartService(IItemCartRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region ..:: Methods ::..

        public async Task CreateAsync(ItemsCartRequest model)
        {
            await _repository.CreateAsync(model);
        }

        public async Task DeleteAsync(string id_user, string id_cart)
        {
            await _repository.DeleteAsync(id_user, id_cart);
        }

        public async Task EditAsync(ItemsCartRequest model)
        {
            await _repository.EditAsync(model);
        }

        public async Task<IEnumerable<ItemsCartResponse>> GetAllActiveAsync(string id_user)
        {
            return await _repository.GetAllActiveAsync(id_user);
        }

        public async Task<IEnumerable<ItemsCartResponse>> GetAllInactiveAsync(string id_user)
        {
            return await _repository.GetAllInactiveAsync(id_user);
        }

        public async Task<ItemsCartResponse> GetAsync(string id_user, string id_cart)
        {
            return await _repository.GetAsync(id_user, id_cart);   
        } 
        #endregion
    }
}
