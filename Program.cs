using ApiLaboratorial.appDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080); // Porta padrão do Railway
});

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DATABASE_URL"))
);

// Adiciona o Swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilita o middleware para servir o Swagger JSON e a interface do Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Laboratorial v1");
        c.RoutePrefix = string.Empty; // Serve o Swagger UI na raiz (http://localhost:<porta>/)
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();

