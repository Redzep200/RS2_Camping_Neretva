using Microsoft.EntityFrameworkCore;
using RS2_Camping_Neretva.Service;
using RS2_Camping_Neretva.Service.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IParcelService, ParcelService>();
builder.Services.AddTransient<ParcelService, ParcelService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("CampingNeretvaConnection");
builder.Services.AddDbContext<CampingNeretvaRs2Context>(options => options.UseSqlServer(connectionString));

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
