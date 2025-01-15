using GeopagosChallenge.Application.Interfaces;
using GeopagosChallenge.Application.Services;
using GeopagosChallenge.Domain.Validators;
using GeopagosChallenge.Infraestructure.Database;
using GeopagosChallenge.Infraestructure.Interfaces;
using GeopagosChallenge.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<LiteDbContext>();
builder.Services.AddSingleton<TournamentValidator>();
builder.Services.AddScoped<ITournamentRepository, TournamentRepository>();
builder.Services.AddScoped<ITournamentService, TournamentService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
