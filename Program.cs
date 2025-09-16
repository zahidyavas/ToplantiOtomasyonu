var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles(); //wwwroot altındaki dosyaları kullanabilmek için bu satır gereklidir.
app.UseRouting(); //Routing middleware'ini etkinleştirir.

//app.MapDefaultControllerRoute(); farlı bi şekilde de yazılabilir.
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();