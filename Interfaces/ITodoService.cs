using HtmxStarter.Models;

namespace HtmxStarter.Interfaces;

public interface ITodoService
{
	public Task<List<Todo>> GetTodos();
	public Task<List<Todo>> AddTodo(Todo todo);
	public Task<Todo> ModifyTodo(Todo todo);
	public Task<List<Todo>> RemoveTodo(string id);
}