using FileUploadManager.Interfaces;
using GleamTech.AspNet.Core;
using ProCodeGuide.Samples.FileUpload.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IStreamFileUploadService, StreamFileUploadLocalService>();
builder.Services.AddGleamTech();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseGleamTech();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=StreamFileUpload}/{action=Index}/{id?}");

app.Run();
