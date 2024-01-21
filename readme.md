### HTMX Starter

This starter provides a barebones example on how to get started with ASP.NET Core Razor Pages, EF Core, Tailwind and HTMX. As I build more projects with HTMX, I'll be updating this starter to be more of a starter rather than a template. This starter provides all of the configuration needed to get an HTMX enabled page running, including templating, automatic controller name to HTML template rendering, and a super useful and totally beautiful todo app.

The starter uses the Microsoft.EntityFrameworkCore.SQLite package for its database. 

### Tailwind

To get tailwind working, install the <a href="https://tailwindcss.com/blog/standalone-cli">Tailwind CLI</a> and the following CLI command against your app.

<code>tailwind.exe -i .\wwwroot\css\input.css -o .\wwwroot\css\output.css --watch #change the tailwind.exe to the location of your tailwind.exe, or create an environment variable</code> 

Once it's running, you should start to see updated output. 

To run the starter app, use <code>dotnet watch</code>

To install as a template, run <code>dotnet new install ./</code>

### Layouts

Layouts are aggregated in Views/Shared. ASP.NET Core only lets you have one layout per controller, but lets you render sections within each layout conditionally if you choose. Each controller folder (e.g., App, Login) has its own layout. For example, login doesn't have a header, while app does. 
