using HtmxStarter.Data;
using HtmxStarter.Interfaces;
using HtmxStarter.Models;
using Microsoft.EntityFrameworkCore;

namespace HtmxStarter.Services;

public class TodoService : ITodoService
{
	private readonly Context _context;

	public TodoService(Context context)
	{
		_context = context;
	}
	
	public async Task<List<Todo>> AddTodo(Todo todo)
	{
		_context.Todos.Add(todo);
		await _context.SaveChangesAsync();
		var todos = await GetTodos();
		return todos;
	}

	public async Task<List<Todo>> GetTodos()
	{
		return await _context.Todos.ToListAsync();
	}

	public async Task<Todo> ModifyTodo(Todo todo)
	{
		throw new NotImplementedException();
	}

	public async Task<List<Todo>> RemoveTodo(string id)
	{
		var todo = _context.Todos.Find(id);
		if (todo is null) 
		{
			throw new Exception();
		}
		
		_context.Todos.Remove(todo);
		await _context.SaveChangesAsync();
		return await _context.Todos.ToListAsync();
	}
}