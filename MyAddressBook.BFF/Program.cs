using Microsoft.EntityFrameworkCore;
using MyAddressBook.Data;
using MyAddressBook.Data.Interfaces;
using MyAddressBook.Data.SQlite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyAddressBookDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:SQLiteDefault"])
);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                  builder =>
                  {
                      builder.AllowAnyOrigin();
                      builder.AllowAnyMethod();
                      builder.AllowAnyHeader();
                  });
});

builder.Services.AddScoped<IRepository, BookRepository>();

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
