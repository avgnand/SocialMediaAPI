using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;

var builder = WebApplication.CreateBuilder(args);

// Different connection strings for each member
var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionNick");
// var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionZach");
// var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionMary");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
