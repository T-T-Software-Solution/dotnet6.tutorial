using Microsoft.EntityFrameworkCore;
using _2.Core;
using _3.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#region Configure IOption Pattern 
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-6.0

builder.Services.Configure<MailGunEmailProviderOptions>(
    builder.Configuration.GetSection(MailGunEmailProviderOptions.ConfigItem));

builder.Services.Configure<SendgridEmailProviderOptions>(
     builder.Configuration.GetSection(SendgridEmailProviderOptions.ConfigItem));
#endregion

#region Configure DI Container - Service Lifetimes - Infra
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();

// Try to switch between Sendgrid and Mailgun
//builder.Services.AddTransient<IEmailProvider, SendgridEmailProvider>();
builder.Services.AddTransient<IEmailProvider, MailGunEmailProvider>();

builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
#endregion

#region Configure DI Container - Service Lifetimes - Business Services
builder.Services.AddTransient<ITokenService, TokenService>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
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
    using (var scope = app.Services.CreateScope())
    {
        var dbcontext = scope.ServiceProvider.GetRequiredService<DataContext>();
        await dbcontext.Database.MigrateAsync(); // Run migration scripts
        await _3.Infra.Seed.SeedData(dbcontext); // Seed data to the project
    }
}