using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectDatabase.Areas.Identity.Data;
using ProjectDatabase.Data;
using ProjectDatabase.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ProjectDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ProjectDbContextConnection' not found.");

builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ProjectDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddScoped<IMlb2010Repository, Mlb2010Repository>();
builder.Services.AddScoped<IMlb2011Repository, Mlb2011Repository>();
builder.Services.AddScoped<IMlb2012Repository, Mlb2012Repository>();
builder.Services.AddScoped<IMlb2013Repository, Mlb2013Repository>();
builder.Services.AddScoped<IMlb2014Repository, Mlb2014Repository>();
builder.Services.AddScoped<IMlb2015Repository, Mlb2015Repository>();
builder.Services.AddScoped<IMlb2016Repository, Mlb2016Repository>();
builder.Services.AddScoped<IMlb2017Repository, Mlb2017Repository>();
builder.Services.AddScoped<IMlb2018Repository, Mlb2018Repository>();
builder.Services.AddScoped<IMlb2019Repository, Mlb2019Repository>();
builder.Services.AddScoped<IMlb2020Repository, Mlb2020Repository>();
builder.Services.AddScoped<IMlb2021Repository, Mlb2021Repository>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
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

app.MapRazorPages();

app.Run();
