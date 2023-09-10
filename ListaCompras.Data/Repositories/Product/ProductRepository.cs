using Dapper;
using ListaCompras.Data.DbConfig;
using ListaCompras.Data.Repositories.Abstractions.Product;
using ListaCompras.Domain.Models.Product;
using System.Data;

namespace ListaCompras.Data.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        public async Task CreateAsync(ProductRequest model)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_product = model.Id,
                p_name = model.Name,
                p_supplier = model.Supplier,
                p_fabrication = model.Fabrication,
                p_expiration = model.Expiration,
                p_amount = model.Amount
            });

            await conn.ExecuteAsync(sql: "sp_create_product",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task DeleteAsync(string id_product)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_product = id_product,
            });

            await conn.ExecuteAsync(sql: "sp_del_product",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task EditAsync(ProductResponse model)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_product = model.Id,
                p_name = model.Name,
                p_supplier = model.Supplier,
                p_fabrication = model.Fabrication,
                p_expiration = model.Expiration,
                p_amount = model.Amount
            });

            await conn.ExecuteAsync(sql: "sp_edit_product",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public Task<IEnumerable<ProductResponse>> GetAllActiveAsync(string id_product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductResponse>> GetAllInactiveAsync(string id_product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse> GetAsync(string id_product)
        {
            throw new NotImplementedException();
        }
    }
}
