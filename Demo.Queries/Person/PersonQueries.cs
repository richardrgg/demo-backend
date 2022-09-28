using Demo.ViewModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Demo.Queries.Person
{
    public class PersonQueries : IPersonQueries
    {
        private readonly string _connectionString;

        public PersonQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<IEnumerable<PersonViewModel>> GetAll()
        {
            IEnumerable<PersonViewModel> result = new List<PersonViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<PersonViewModel>("[dbo].[Usp_Sel_Person_All]", commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<PersonByIdViewModel> GetById(int id)
        {
            var personByIdViewModel = new PersonByIdViewModel();

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using (var connection = new SqlConnection(_connectionString))
            {
                personByIdViewModel = await connection.QueryFirstOrDefaultAsync<PersonByIdViewModel>("[dbo].[Usp_Sel_Person_ById]", parameters, commandType: CommandType.StoredProcedure);
            }

            return personByIdViewModel;
        }
    }
}
