using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosAppABP.Models
{
    public interface ITodoRecordsAppService : IApplicationService
    {
        Task<List<TodoRecordsDto>> GetAll();

        Task<TodoRecordsDto> Create(TodoRecordsDto input);

        Task<TodoRecordsDto> Update(TodoRecordsDto input);

        Task Delete(int Id);

        Task<TodoRecordsDto> GetTodo(int Id);
    }
}
