using Dapper;
using ListaCompras.Data.DbConfig;
using ListaCompras.Domain.Models.Items;
using ListaComrpas.Data.Repositories.Abstractions.Items;
using System.Data;

namespace ListaComrpas.Data.Repositories.Items
{
    public class ItemCartRepository : IItemCartRepository
    {
        public async Task CreateAsync(ItemsCartRequest model)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_cart = model.Id,
                p_uuid_user = model.IdUser,
                p_uuid_product = model.IdProduct,
             });

            await conn.ExecuteAsync(sql: "sp_create_cart",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task DeleteAsync(string id_user, string id_cart)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_user = id_user,
                p_uuid_cart = id_cart,
            });

            await conn.ExecuteAsync(sql: "sp_del_cart",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task EditAsync(ItemsCartRequest model)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_cart = model.Id,
                p_uuid_user = model.IdUser,
                p_uuid_product = model.IdProduct,
            });

            await conn.ExecuteAsync(sql: "sp_edit_cart",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
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
