using Microsoft.EntityFrameworkCore;
using User; // Remplacez par le nom de l'espace de noms contenant votre DBContext

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run("http://localhost:4242");