using Api.Repositories;
using Api.Services;
using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerDoc();
builder.Services.AddFastEndpoints();

builder.Services.AddScoped<UserService>();

builder.Services.AddSingleton<UserRepository>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseFastEndpoints();
app.UseSwaggerGen();


app.Run();
