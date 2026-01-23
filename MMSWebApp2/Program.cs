using Microsoft.EntityFrameworkCore;
using MMSWebApp2.Data;
using MMSWebApp2.Repository;
using MMSWebApp2.Repository.Interface;
using MMSWebApp2.Service;
using MMSWebApp2.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Service
builder.Services.AddScoped<IMemberService, MemberService>();

//Repository
builder.Services.AddScoped<IMemberRepository, MemberRepository>();

builder.Services.AddDbContext<MMSWebAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MMSWebAppDbConnection"));
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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
