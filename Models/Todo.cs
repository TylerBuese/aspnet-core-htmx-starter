namespace HtmxStarter.Models;

public class Todo 
{
	public String ID { get; set; } = Guid.NewGuid().ToString();
	public string Title { get; set; }
	public string Description { get; set; }
	
}