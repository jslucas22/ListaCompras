using Dapper;
using ListaCompras.Data.DbConfig;
using ListaCompras.Domain.Models.Authentication;
using ListaCompras.Domain.Models.User;
using ListaComrpas.Data.Repositories.Abstractions.User;
using System.Data;

namespace ListaComrpas.Data.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        public async Task<UserLoginResponse> GetAsync(UserLoginRequest model)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(UserRegisterRequest model)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_user = model.Id,
                p_username = model.Username,
                p_first_name = model.FirstName,
                p_last_name = model.LastName
            });

            await conn.ExecuteAsync(sql: "sp_create_user",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task EditAsync(UserEditRequest model)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_user = model.Id,
                p_username = model.Username,
                p_first_name = model.FirstName,
                p_last_name = model.LastName
            });

            await conn.ExecuteAsync(sql: "sp_edit_user",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }

        public async Task DeleteAsync(string id)
        {
            using var conn = Configuration.GetSqlConnection();

            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(new
            {
                p_uuid_user = id,
            });

            await conn.ExecuteAsync(sql: "sp_del_user",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);
        }
    }
}
