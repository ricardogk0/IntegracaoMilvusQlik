using IntegracaoMilvusQlik.Data;
using IntegracaoMilvusQlik.Interfaces;
using IntegracaoMilvusQlik.Mappings;
using IntegracaoMilvusQlik.Rest;
using IntegracaoMilvusQlik.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<IntegracaoMilvusQlikContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("IntegracaoMilvusQlikContext") ?? 
        throw new InvalidOperationException("Connection string 'IntegracaoMilvusQlik' not found.")));

builder.Services.AddSingleton<IListaService, ListaService>();
builder.Services.AddSingleton<IMilvusApi, MilvusApiRest>();

builder.Services.AddAutoMapper(typeof(ListaMapping));

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
