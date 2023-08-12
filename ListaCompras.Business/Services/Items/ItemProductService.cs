using ListaCompras.Domain.Models.Items;
using ListaComrpas.Business.Services.Abstractions.Items;
using ListaComrpas.Data.Repositories.Abstractions.Items;

namespace ListaComrpas.Business.Services.Items
{
    public class ItemProductService : IItemProductService
    {
        #region ..:: Variables ::..

        private readonly IItemProductRepository _repository;

        #endregion

        #region ..:: Constructor ::..

        public ItemProductService(IItemProductRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region ..:: Methods ::..

        public async Task CreateAsync(ItemsProductRequest model)
        {
            await _repository.CreateAsync(model);
        }

        public async Task DeleteAsync(string id_user, string id_product)
        {
            await _repository.DeleteAsync(id_user, id_product);
        }

        public async Task EditAsync(ItemsProductRequest model)
        {
            await _repository.EditAsync(model);
        }

        public async Task<IEnumerable<ItemsProductResponse>> GetAllActiveAsync(string id_user)
        {
            return await _repository.GetAllActiveAsync(id_user);
        }

        public async Task<IEnumerable<ItemsProductResponse>> GetAllInactiveAsync(string id_user)
        {
            return await _repository.GetAllInactiveAsync(id_user);
        }

        public async Task<ItemsProductResponse> GetAsync(string id_user, string id_product)
        {
            return await _repository.GetAsync(id_user, id_product);
        }

        public async Task SoftDeleteAsync(string id_user, string id_product)
        {
            await _repository.SoftDeleteAsync(id_user, id_product);
        }

        #endregion
    }
}
