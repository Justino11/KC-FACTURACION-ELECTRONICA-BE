using KC_FACTURACION_ELECTRONICA.BbContext;
using KC_FACTURACION_ELECTRONICA.Interfaces;
using KC_FACTURACION_ELECTRONICA.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<DatalakeContext>();
builder.Services.AddScoped<IFacturasExtrajerasFE, FacturasExtrajerasFERepository>();
builder.Services.AddScoped<IHistorialFacturasProcesadas, HistorialFacturasProcesadasRepository>();

builder.Services.AddControllers();
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
