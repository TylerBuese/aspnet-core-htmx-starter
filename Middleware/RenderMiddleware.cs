using HtmxStarter.Interfaces;

namespace HtmxStarter.Middleware;

public class RenderMiddleware 
{
	private readonly RequestDelegate _next;


	public RenderMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(HttpContext context) 
	{
		await _next(context);
	}
}