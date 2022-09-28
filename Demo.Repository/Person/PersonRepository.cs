using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Demo.Repository.Person
{
    public class PersonRepository : IPersonRepository
    {
        private readonly string _connectionString;

        public PersonRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<int> Create(Model.Person person)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Name", person.Name);
            parameters.Add("@Lastname", person.Lastname);
            parameters.Add("@DocumentNumber", person.DocumentNumber);
            parameters.Add("@DocumentTypeId", person.DocumentTypeId);
            parameters.Add("@Birthday", person.Birthday);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_Person]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Delete(int id)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Del_Person]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Update(Model.Person person)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Id", person.Id);
            parameters.Add("@Name", person.Name);
            parameters.Add("@Lastname", person.Lastname);
            parameters.Add("@DocumentNumber", person.DocumentNumber);
            parameters.Add("@DocumentTypeId", person.DocumentTypeId);
            parameters.Add("@Birthday", person.Birthday);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Upd_Person]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
