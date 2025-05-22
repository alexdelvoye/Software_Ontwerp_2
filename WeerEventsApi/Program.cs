using Microsoft.Extensions.DependencyInjection;
using WeerEventsApi.Facade.Controllers;
using WeerEventsApi.Logging;
using WeerEventsApi.Logging.Factories;
using WeerEventsApi.Stations.Managers;
using WeerEventsApi.Stations.Repositories;
using WeerEventsApi.Steden.Managers;
using WeerEventsApi.Steden.Repositories;
using WeerEventsApi.Weerberichten.Manager;
using WeerEventsApi.Weerberichten.Proxy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IMetingLogger>(MetingLoggerFactory.Create(true,true));
builder.Services.AddSingleton<IStadRepository, StadRepository>();
builder.Services.AddSingleton<IStadManager, StadManager>();
builder.Services.AddSingleton<IWeerstationRepository, WeerstationRepository>();
builder.Services.AddSingleton<IWeerstationManager, WeerstationManager>();
builder.Services.AddSingleton<WeerBerichtManager>();
builder.Services.AddSingleton<IWeerBerichtManager>(provider => new WeerBerichtProxy(provider.GetRequiredService<WeerBerichtManager>()));
builder.Services.AddSingleton<IDomeinController, DomeinController>();

var app = builder.Build();

app.MapGet("/", () => "WEER - WEERsomstandigheden Evalueren En Rapporteren");

app.MapGet("/steden", (IDomeinController dc) => dc.GeefSteden());

app.MapGet("/weerstations", (IDomeinController dc) => dc.GeefWeerstations());

app.MapPost("/doemetingen", (IDomeinController dc) => dc.DoeMetingen());

app.MapGet("/metingen", (IDomeinController dc) => dc.GeefMetingen());

app.MapGet("/weerbericht", (IDomeinController dc) => dc.GeefWeerbericht());

app.Run();


/* Used Design Patterns
 * Facade -> Dto
 * Factory -> WeerstationFactory, MetingLoggerFactory
 * Observer -> AbstractObserver, IObserver -> MetingLogger
 * Decorator -> LoggerDecorator, JsonLoggerDecorator, XmlLoggerDecorator
 * Event/Delegate -> WeerBerichtManager -> Weerstation
 * Proxy -> WeerberichtProxy
 */