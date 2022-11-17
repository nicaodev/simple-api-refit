using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Refit;
using simple_api_refit.Interface;
using simple_api_refit.Model;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRefitClient<IQuote>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://api.kanye.rest");
});
builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/quote", ([FromServices] IQuote quote) =>
{
    return quote.ReturnQuote();
});

app.Run();



