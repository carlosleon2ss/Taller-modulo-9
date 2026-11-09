using EjercicioTienda.Options;
using EjercicioTienda.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOptions<TiendaOptions>()
    .Bind(builder.Configuration.GetSection(TiendaOptions.Seccion))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services.AddScoped<IResumenService, ResumenService>();
builder.Services.AddTransient<ICalculadoraIva, CalculadoraIva>();

var app = builder.Build();

app.MapControllers();
app.Run();
