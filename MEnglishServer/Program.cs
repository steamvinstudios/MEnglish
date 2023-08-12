using MEnglishServer;

var news = new News();
news.All.Reverse();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapGet("/news", () =>  Results.Ok(news));

app.Run();
