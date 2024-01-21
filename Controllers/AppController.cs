using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HtmxStarter.Interfaces;
using HtmxStarter.Models;
using HtmxStarter.Services;

namespace HtmxStarter.Controllers;

[Route("")]
public class AppController : Controller
{
	
	private readonly IRenderView _renderView;
	private readonly ITodoService _todoService;

	public AppController(IRenderView renderView, ITodoService todoService)
	{
		_renderView = renderView;
		_todoService = todoService;
	}
	public async Task<ActionResult> Index() 
	{
		var todos = await _todoService.GetTodos();
		return View(todos);
	}
	
	[HttpPost("Todo")]
	public async Task<ActionResult> NewTodo([FromForm]Todo todo) 
	{
		var todos = await _todoService.AddTodo(todo);	
		return base.Content(await _renderView.RenderToStringAsync($"Template{HttpContext.Request.Path.Value}", todos), "text/html");
	}
	
	[HttpGet("Test")]
	public async Task<ActionResult> Test() 
	{
		var view = await _renderView.RenderToStringAsync($"Template{HttpContext.Request.Path.Value}", null);
		return base.Content(view, "text/html");
	}
	
	[HttpDelete("Todo")]
	public async Task<ActionResult> RemoveTodo([FromQuery]string id) 
	{
		Console.WriteLine(id);
		var todos = await _todoService.RemoveTodo(id);
		return base.Content(await _renderView.RenderToStringAsync($"Template{HttpContext.Request.Path.Value}", todos), "text/html");
	}
}
