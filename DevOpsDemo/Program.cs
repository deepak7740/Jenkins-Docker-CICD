
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () =>
    Results.Ok(new
    {
      Message = "Hello from Jenkins Docker CI/CD!",
      Status = "Success"
    }));

app.MapGet("/health", () =>
    Results.Ok(new
    {
      Status = "Healthy",
      Service = "DevOpsDemo"
    }));

app.Run();
