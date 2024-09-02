using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers();   //builder.Services.AddScoped<IProductRepository>(); builder.Services.AddDBcontexts();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<DemodbContext>(options =>
//                   options.UseNpgsql("Persist Security Info=True;Password=changeme;Username=postgres;Database=Demodb;Host=localhost"));
ReposDI.Init(builder.Services);
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
