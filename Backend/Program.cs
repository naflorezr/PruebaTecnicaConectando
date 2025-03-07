using Microsoft.EntityFrameworkCore;
using PruebaTecnica.DbConnection;
using PruebaTecnica.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoriaService>();
//Conexion base de datos
builder.Services.AddDbContext<DbConnectionContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection")));

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
