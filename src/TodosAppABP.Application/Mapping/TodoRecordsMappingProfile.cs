using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosAppABP.Models;
using TodosAppABP.TodoRecords;

namespace TodosAppABP.Mapping
{
    public class TodoRecordsMappingProfile : Profile
    {
        public TodoRecordsMappingProfile()
        {
            CreateMap<Todo, TodoRecordsDto>();
            CreateMap<TodoRecordsDto, Todo>();

        }
    }
}
