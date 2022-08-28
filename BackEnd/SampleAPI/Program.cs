var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This is a ASP.NET Web API running in docker container!");

app.Run();
