namespace HtmxStarter.Interfaces;

public interface IRenderView 
{
	public Task<string> RenderToStringAsync(string viewName, object model);
}