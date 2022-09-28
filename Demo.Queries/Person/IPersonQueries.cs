using Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Queries.Person
{
    public interface IPersonQueries
    {
        Task<PersonByIdViewModel> GetById(int id);
        Task<IEnumerable<PersonViewModel>> GetAll();
    }
}
