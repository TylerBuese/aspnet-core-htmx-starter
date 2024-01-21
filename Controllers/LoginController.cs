using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using HtmxStarter.Interfaces;
using HtmxStarter.Models;

namespace HtmxStarter.Controllers;

[Route("Login")]
public class LoginController : Controller
{
	[HttpGet("")]
	public async Task<ActionResult> Index() 
	{
		return View();
	}
	
	[HttpPost("")]
	public async Task<ActionResult> LoginPost([FromForm] LoginCredentials credentials) 
	{
		Console.WriteLine(credentials.Username);
		return Ok();
	}
}

public class LoginCredentials 
{
	public string Username { get; set; }
	public string Password { get; set; }
}