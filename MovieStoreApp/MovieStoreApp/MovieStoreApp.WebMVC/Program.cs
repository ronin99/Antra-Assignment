var builder = WebApplication.CreateBuilder(args);

//code below this was written in configureservices method
#region COnfigureservices



// Add services to the container.
builder.Services.AddControllersWithViews();
#endregion
var app = builder.Build();

//code below this was written in configure method and it will contain middleware
//and enviroment relatedcode
#region COnfigure


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
#endregion
