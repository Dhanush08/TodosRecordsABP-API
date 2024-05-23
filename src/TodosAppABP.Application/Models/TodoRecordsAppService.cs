using Abp.Application.Services;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodosAppABP.TodoRecords;

namespace TodosAppABP.Models
{
    public class TodoRecordsAppService : ApplicationService, ITodoRecordsAppService
    {
        private readonly IRepository<Todo, int> _todoRecordsRepository;

        public TodoRecordsAppService(IRepository<Todo, int> todoRecordsRepository)
        {
            _todoRecordsRepository = todoRecordsRepository;
        }

        public async Task<List<TodoRecordsDto>> GetAll()
        {
            var records = await _todoRecordsRepository.GetAllListAsync();

            return ObjectMapper.Map<List<TodoRecordsDto>>(records);
        }

        public async Task<TodoRecordsDto> Create(TodoRecordsDto input)
        {
            var todo = ObjectMapper.Map<Todo>(input);

            await _todoRecordsRepository.InsertAsync(todo);

            return ObjectMapper.Map<TodoRecordsDto>(todo);
        }

        public async Task<TodoRecordsDto> Update(TodoRecordsDto input)
        {
            var todo = await _todoRecordsRepository.GetAsync(input.Id);

            if (todo == null)
            {
                throw new EntityNotFoundException(typeof(Todo), input.Id); // Handle non-existent Todo
            }

            todo.Description = input.Description;

            todo.IsFullfilled = input.IsFullfilled;

            await _todoRecordsRepository.UpdateAsync(todo);

            return ObjectMapper.Map<TodoRecordsDto>(todo);
        }

        public async Task Delete(int Id)
        {
            var todo = await _todoRecordsRepository.GetAsync(Id);

            if (todo == null)
            {
                throw new EntityNotFoundException(typeof(Todo), Id); // Handle non-existent Todo
            }

            await _todoRecordsRepository.DeleteAsync(Id);
        }

        public async Task<TodoRecordsDto> GetTodo(int Id)
        {
            var todo = await _todoRecordsRepository.GetAsync(Id);

            if (todo == null)
            {
                throw new EntityNotFoundException(typeof(Todo), Id); // Handle non-existent Todo
            }

            return ObjectMapper.Map<TodoRecordsDto>(todo);
        }
    }
}
