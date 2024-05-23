using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosAppABP.TodoRecords
{
    public interface ITodoRecordsRepository : IRepository<Todo, int>
    {
    }
}
