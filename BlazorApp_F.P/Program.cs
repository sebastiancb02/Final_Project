using BlazorApp_F.P.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlazorApp_F.P.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BlazorAppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'BlazorAppDbContextConnection' not found.");

builder.Services.AddDbContext<BlazorAppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<BlazorApp_User>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BlazorAppDbContext>();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();