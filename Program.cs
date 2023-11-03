using Microsoft.EntityFrameworkCore;
using TrabalhoAPI.Data;
using TrabalhoAPI.Data.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<AppDbContext>(

    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddCors();

builder.Services.AddTransient<FilmesService>();
builder.Services.AddTransient<DiretorService>();
builder.Services.AddTransient<CatalogoService>();
builder.Services.AddTransient<UsuarioService>();
builder.Services.AddTransient<ComentarioService>();
builder.Services.AddTransient<GeneroService>();
builder.Services.AddTransient<PontuacaoService>();
builder.Services.AddTransient<CatalogoFilmeService>();
builder.Services.AddTransient<WatchlistService>();
builder.Services.AddTransient<GeneroUsuarioService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(opcoes => opcoes
    .WithOrigins("http://localhost:4200")
    .AllowAnyHeader().AllowAnyMethod().AllowCredentials()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
