### Layouts

Layouts are aggregated in Views/Shared. ASP.NET Core only lets you have one layout per controller, but lets you render sections within each layout conditionally if you choose. Each controller folder (e.g., App, Login) has its own layout. For example, login doesn't have a header, while app does. 