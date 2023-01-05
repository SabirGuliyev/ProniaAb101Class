using Microsoft.EntityFrameworkCore;
using ProniaAB101.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("default")));
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    "Default",
    "{Controller=Home}/{Action=Index}/{id?}"
    );

app.Run();
