using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Repository.Impl
{
    public class TodoItemRepositoryImpl : ITodoItemRepository
    {
        private readonly TodoApiDbContext _context;

        public TodoItemRepositoryImpl(TodoApiDbContext context)
        {
            _context = context;
        }

        public async Task Atualizar(TodoItem todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(int id)
        {
            var query = _context.TodoItem.Where(e => e.Id == id);
            _context.TodoItem.RemoveRange(query);
            await _context.SaveChangesAsync();
        }

        public async Task<TodoItem> GetById(int id)
        {
            return await _context.TodoItem.FindAsync(id);
        }

        public async Task<List<TodoItem>> Listar()
        {
            return await _context.TodoItem.ToListAsync();
        }

        public async Task Salvar(TodoItem todo)
        {
            _context.TodoItem.Add(todo);
            await _context.SaveChangesAsync();
        }
    }
}
