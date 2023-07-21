using codeFirstDeneme.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Buraya Ba�lant� Dizesini Girdik A�a��ya (Repository Context Denilen K�s�m Bizim �simlendirmemizdir.).
builder.Services.AddDbContext<RepositoryContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("sqlConnection")));//bunu verdi�imiz zaman IOC ye tan�m� yapm�� oluyoruz : Inversion Of Control 

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
