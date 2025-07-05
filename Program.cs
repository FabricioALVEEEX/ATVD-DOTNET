using Microsoft.EntityFrameworkCore;
using MacLancheFelizFabricio.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=maclanche.db"));

// Suporte a controllers com views
builder.Services.AddControllersWithViews();

// Define cultura brasileira pt-BR
var defaultCulture = new CultureInfo("pt-BR");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = new List<CultureInfo> { defaultCulture },
    SupportedUICultures = new List<CultureInfo> { defaultCulture }
};

var app = builder.Build();

// Aplica a cultura pt-BR no pipeline
app.UseRequestLocalization(localizationOptions);

// Middleware padrão
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Faltava isso para servir CSS, JS, imagens etc.
app.UseRouting();
app.UseAuthorization();

// Rotas padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
