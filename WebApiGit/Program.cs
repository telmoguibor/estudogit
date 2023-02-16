using WebApiGit.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapGet("/info", () =>
{
    Info info = new Info();
    return info;
});
app.MapGet("/info/hash", (string frase) =>
{
    return Util.GerarMd5(frase);
});

app.Run();