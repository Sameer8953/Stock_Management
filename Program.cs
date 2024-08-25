using api.Data;
using API.Interfaces;
using API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 builder.Services.AddControllers().AddNewtonsoftJson( options => {
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
 });

builder.Services.AddDbContext<ApplicationDBContext>(options => {
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Add Repository DI  Services....
builder.Services.AddTransient<IStockRepository,StockRepository>();
builder.Services.AddScoped<ICommentRepository,CommentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

