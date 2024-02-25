using CustomerDatabaseAPI.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomerDatabaseAPI.Server.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CustomerDatabaseAPIServerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerDatabaseAPIServerContext") ?? throw new InvalidOperationException("Connection string 'CustomerDatabaseAPIServerContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var app = builder.Build();

//for seed data

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.EnsurePopulated(services).Wait();
    }
    catch (Exception ex)
    {
        //print error message
        var logger = services.GetRequiredService<ILogger<Program>>();

        logger.LogError(ex, "An error occured seeding the database.");
    }
}

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
