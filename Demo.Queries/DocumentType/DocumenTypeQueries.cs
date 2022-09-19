using Dapper;
using Demo.ViewModel;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Demo.Queries.DocumentType
{
    public class DocumenTypeQueries : IDocumenTypeQueries
    {
        private readonly string _connectionString;

        public DocumenTypeQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<IEnumerable<DocumentTypeViewModel>> GetAll()
        {
            IEnumerable<DocumentTypeViewModel> result = new List<DocumentTypeViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<DocumentTypeViewModel>("[dbo].[Usp_Sel_DocumentType]", commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
