using AppGestaoDeResiduos.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using AppGestaoDeResiduos.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conectando o app com o Banco de Dados
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar TestService
builder.Services.AddScoped<TestService>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.MaxDepth = 64; // Ajuste conforme necessário
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Adicionar dados de teste antes de iniciar a aplicação
using (var scope = app.Services.CreateScope())
{
var testService = scope.ServiceProvider.GetRequiredService<TestService>();
await testService.AddTestDataAsync();
}


public class TestService
{
    private readonly ApplicationDbContext _context;

    public TestService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddTestDataAsync()
    {
        var testUser = new Usuario
        {
            Nome = "Danilo",
            Email = "danilo@exemplo.com",
            AgendouColeta = false,
            FoiNotificado = false,
            EnderecoId = 1
        };

        _context.Usuarios.Add(testUser);
        await _context.SaveChangesAsync();
    }
}

