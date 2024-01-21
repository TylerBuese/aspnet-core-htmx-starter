using HtmxStarter.Models;
using Microsoft.EntityFrameworkCore;

namespace HtmxStarter.Data;

public class Context : DbContext 
{
	public Context(DbContextOptions<Context> options) : base(options)
	{
		
	}
	
	public DbSet<Todo> Todos { get; set; }
}