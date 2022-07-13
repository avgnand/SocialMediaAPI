using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.Services.Comment;
using SocialMedia.Services.Post;
using SocialMedia.Services.Reply;
using SocialMedia.Services.User;

var builder = WebApplication.CreateBuilder(args);

// Different connection strings for each member
var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionNick");
// var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionZach");
// var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionMary");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Add Services for Dependency Injection
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IReplyService, ReplyService>();
builder.Services.AddScoped<ICommentService, CommentService>();

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
