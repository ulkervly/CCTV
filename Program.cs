using CCTV_MVC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=LAPTOP-N2MJ83JU\\SQLEXPRESS;Database=CCTV;Trusted_Connection=True");
});
var app = builder.Build();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(name: "default",
    pattern: "{controller=home}/{action=index}/{id?}");

app.Run();
