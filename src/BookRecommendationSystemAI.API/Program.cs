using System.IO;
using System.Runtime.Intrinsics.X86;
using Asp.Versioning;
using BookRecommendationSystemAI.Infra.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddEnvironmentVariables()
    .Build();

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddConfiguration(configuration);

//temp até implementar cqrs e repositorios
builder.Services.AddDbContext<PostgresDbContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(x =>
{
    x.AssumeDefaultVersionWhenUnspecified = true;
    x.DefaultApiVersion = ApiVersion.Default;
    x.ReportApiVersions = true;
}).AddApiExplorer(x =>
{
    x.GroupNameFormat = "'v'V";
    x.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

if (app.Environment.IsProduction())
{
    app.UseHttpsRedirection();
}

app.UseRouting();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

await app.RunAsync();