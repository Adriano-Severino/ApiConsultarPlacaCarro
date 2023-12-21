using CSTPlaca.CrossCutting.Interface;
using CSTPlaca.CrossCutting.Service.ApiPlacas;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddCors(options => options.AddPolicy("Cors", options => options.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()));

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Services.AddScoped<IApiPlacaService, ApiPlacaService>();

builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "ConsultarPlacaCarro", Version = "v1" });
    
});

builder.Services.AddControllersWithViews()
               .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling =
                   Newtonsoft.Json.ReferenceLoopHandling.Ignore);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
