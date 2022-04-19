using MovieStoreApp.Contracts.Repository;
using MovieStoreApp.Contracts.Services;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//swagger is use for documention
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<MovieContext>(builder.Configuration.GetConnectionString("MovieStore"));

//services
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();

//repository
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


//map the information to the controller
//controller/action method
app.MapControllers();

app.Run();
