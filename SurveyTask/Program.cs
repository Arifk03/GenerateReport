using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SurveyTask.Model;
using SurveyTask.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SurveyContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SurveyTask")));


builder.Services.AddControllers();
builder.Services.AddTransient<ISurveyService, SurveyService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
