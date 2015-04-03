using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Data.IRepository.Base;
using Angular.Data.Modals;

namespace Angular.Data.IRepository
{
    public interface IPersonRepository: IGenericRepository<Person>
    {
    }
}
