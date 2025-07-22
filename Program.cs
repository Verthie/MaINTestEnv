using MaINTestEnv.Components;
using MaIN.Core;
using MaINTestEnv.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<AdventureSettingSevice>();
builder.Services.AddSingleton<GameTypeService>();
builder.Services.AddSingleton<GameSettingsService>();

builder.Services.AddMaIN(builder.Configuration);
var app = builder.Build();
app.Services.UseMaIN();

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
