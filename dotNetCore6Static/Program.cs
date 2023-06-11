using dotNetCore6Static.BL;
using dotNetCore6Static.DAL;
using dotNetCore6Static.Models;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserBL, UserBL>();
builder.Services.AddScoped<IUserDAL, UserDAL>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<personContext>(opt => opt.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()),
              ServiceLifetime.Singleton, ServiceLifetime.Singleton);

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

var dbcontext = app.Services.GetService<personContext>();

AddContextData(dbcontext);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



void AddContextData(personContext dbcontext)
{
    if (dbcontext != null)
    {
        //List<Person> personList = new List<Person>();
        //personList.Add(new Person { Code = 2, Name = "ששון" });
        //personList.Add(new Person { Code = 3, Name = "שמחה" });
        dbcontext.personList.Add(new Person { Code = 2, Name = "ששון" });
        dbcontext.SaveChanges();
    }

}

