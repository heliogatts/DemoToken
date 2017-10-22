using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace TesteToken
{
    public class UsersDAO
    {
        private readonly IConfiguration _configuration;

        public UsersDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string userID)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuration.GetConnectionString("Exemplo")))
            {
                return conexao.QueryFirstOrDefault<User>(
                    "SELECT UserID, AccessKey " +
                    "FROM dbo.Users " +
                    "WHERE UserID = @UserID", new { UserID = userID });
            }
        }
    }
}
