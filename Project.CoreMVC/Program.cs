using Project.BLL.ServicesInjections;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromDays(1); //Projeyi ki�inin bos durma s�resi eger 1 g�nl�k bir s�re olursa Session bosa c�ks�n
    x.Cookie.HttpOnly = true; //document.cookie'den ilgili bilginin g�zlemlenmesi
    x.Cookie.IsEssential = true;
});

builder.Services.AddDbContextService(); 
builder.Services.AddIdentityServices();

builder.Services.AddRepServices();
builder.Services.AddManagerServices();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
