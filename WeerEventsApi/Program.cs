using Microsoft.Extensions.DependencyInjection;
using WeerEventsApi.Facade.Controllers;
using WeerEventsApi.Logging;
using WeerEventsApi.Logging.Factories;
using WeerEventsApi.Metingen.Managers;
using WeerEventsApi.Metingen.Repository;
using WeerEventsApi.Stations.Factories;
using WeerEventsApi.Stations.Managers;
using WeerEventsApi.Stations.Repositories;
using WeerEventsApi.Steden.Managers;
using WeerEventsApi.Steden.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IMetingLogger>(MetingLoggerFactory.Create(true,true));
builder.Services.AddSingleton<IStadRepository, StadRepository>();
builder.Services.AddSingleton<IStadManager, StadManager>();
builder.Services.AddSingleton<IDomeinController, DomeinController>();
builder.Services.AddSingleton<IWeerstationRepository, WeerstationRepository>();
builder.Services.AddSingleton<IWeerstationManager, WeerstationManager>();
builder.Services.AddSingleton<IMetingRepository, MetingRepository>();
builder.Services.AddSingleton<IMetingManager, MetingManager>();

var app = builder.Build();

app.MapGet("/", () => "WEER - WEERsomstandigheden Evalueren En Rapporteren");

app.MapGet("/steden", (IDomeinController dc) => dc.GeefSteden());

app.MapGet("/weerstations", (IDomeinController dc) => dc.GeefWeerstations());

app.MapGet("/metingen", (IDomeinController dc) => dc.GeefMetingen());

app.MapGet("/weerbericht", (IDomeinController dc) => dc.GeefWeerbericht());

//TODO api aanvullen

app.Run();