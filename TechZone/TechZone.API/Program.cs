using Microsoft.EntityFrameworkCore;
using TechZone.DataAccess;
using TechZone.DataAccess.Abstract;
using TechZone.DataAccess.Concrete.Context;
using TechZone.DataAccess.Concrete.EntityFramework;
using TechZone.Entities;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TechZoneAPIContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

#region 
builder.Services.AddTransient<IUserDal, EfUserDal>();
//builder.Services.AddTransient<IUserService, UserService>();

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

app.UseStaticFiles();

app.MapControllers();

app.Run();

