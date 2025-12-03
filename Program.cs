using Microsoft.EntityFrameworkCore;
using Veterinaria.DB;
using Veterinaria.Service;
using Blazored.Toast;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredToast();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<VeterinariaDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddHttpClient(); 
builder.Services.AddHttpClient<RenaperService>();
builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<IMascotaService, MascotaService>();
builder.Services.AddScoped<IAtencionService, AtencionService>();

// --- FIN ---


var app = builder.Build();

// --- INICIO---

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); 
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// --- FIN ---

app.Run();
