using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieStoreApp.Contracts.Repository;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Infrastructure.Services;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

//code below this was written in configureservices method
#region COnfigureservices



// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieContext>(option =>
{
    
    option.UseSqlServer(builder.Configuration.GetConnectionString("MovieStore"));
    // this will use the appsetting,json setting for data source that connect to database
});

//for repository
//this will create a object of movierepository and put it into imovierepository
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();

////services
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IMovieCastServiceAsync, MovieCastServiceAsync>();
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
