using NeveTirzahPrison;
using NeveTirzhaPrisoner.Core;
using NeveTirzhaPrisoner.Core.Repositories;
using NeveTirzhaPrisoner.Core.Services;
using NeveTirzhaPrisoner.Data.Repositories;
using NeveTirzhaPrisoner.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPrisonerService, PrisonerService>();
builder.Services.AddScoped<IPrisonerRepository, PrisonerRepository>();
builder.Services.AddScoped<IPrisonerGuardService, PrisonGuardService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IPrisonerGuardRepository, PrisonerGuardRepository>();
builder.Services.AddScoped<IRehabilitationProgramsService, RehabilitationProgramsService>();
builder.Services.AddScoped<IRehabilitationProgramsRepository, RehabilitationProgramsRepository>();
builder.Services.AddDbContext<DataContext>();


builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
{
    //policy.WithOrigins("http://localhost:4200")
    policy.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
