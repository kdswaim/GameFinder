using GameFinder.Data.Contexts;
using GameFinder.Services;
using GameFinder.Services.Maps;
using Microsoft.EntityFrameworkCore;
using GameFinder.Services.RatingServices;
using GameFinder.Services.GameServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IGameSystemService,GameSystemService>();
builder.Services.AddAutoMapper(typeof(MappingConfigurations));
builder.Services.AddScoped<IRatingService,RatingService>();
builder.Services.AddScoped<IGameServices,GameServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
