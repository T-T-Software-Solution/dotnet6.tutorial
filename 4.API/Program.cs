using _2.Core.Extensions;
using _3.Infra;
using _3.Infra.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Configure IOption Pattern

builder.Services.ConfigureInfraOptions();

#endregion

#region Configure DI Container - Service Lifetimes - Infra

builder.Services.AddInfraDependencyInjection(builder.Configuration);

#endregion

#region Configure DI Container - Service Lifetimes - Business Services

builder.Services.AddCoreDependencyInjection();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await SeedDatabase();

app.Run();

async Task SeedDatabase()
{
    using var scope = app.Services.CreateScope();
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    await dataContext.Database.MigrateAsync(); // Run migration scripts
    await Seed.SeedData(dataContext); // Seed data to the project
}
