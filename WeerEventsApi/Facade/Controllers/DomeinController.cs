using WeerEventsApi.Facade.Dto;
using WeerEventsApi.Logging;
using WeerEventsApi.Stations;
using WeerEventsApi.Stations.Managers;
using WeerEventsApi.Steden.Managers;
using WeerEventsApi.Weerberichten;
using WeerEventsApi.Weerberichten.Manager;

namespace WeerEventsApi.Facade.Controllers;

public class DomeinController : IDomeinController
{
    private readonly IStadManager _stadManager;
    private readonly IWeerstationManager _weerstationManager;
    private readonly IMetingLogger _metingLogger;
    private readonly IWeerBerichtManager _weerBerichtProxy;
    
    public DomeinController(IStadManager stadManager, IWeerstationManager weerstationManager, IMetingLogger metingLogger, IWeerBerichtManager weerBerichtProxy)
    {
        _stadManager = stadManager;
        _weerstationManager = weerstationManager;
        _metingLogger = metingLogger;
        _weerBerichtProxy = weerBerichtProxy;
        _weerstationManager.MaakWeerstations();
        _weerstationManager.DoeMeting();

        foreach(Weerstation weerstation in _weerstationManager.GeefWeerstations())
        {
            weerstation.RegisterObserver(_metingLogger);
            weerstation.MetingGemaakt += (sender, meting) => _weerBerichtProxy.VoegMetingToe(meting);
        }
    }

    public IEnumerable<StadDto> GeefSteden()
    {
        return _stadManager.GeefSteden().Select(s => new StadDto
        {
            Naam = s.Naam,
            Beschrijving = s.Beschrijving,
            GekendVoor = s.GekendVoor
        });
    }

    public IEnumerable<WeerStationDto> GeefWeerstations()
    {
        return _weerstationManager.GeefWeerstations().Select(w => new WeerStationDto
        {
            Stad = w.Stad
        });
    }

    public IEnumerable<MetingDto> GeefMetingen()
    {
        return _weerstationManager.GeefMetingen().Select(m => new MetingDto
        {
            MomentMeting = m.momentMeting,
            Waarde = m.waarde,
            Eenheid = m.eenheid,
            StadNaam = m.Stad.Naam
        });
    }

    public void DoeMetingen()
    {
        _weerstationManager.DoeMeting();
    }

    public WeerBerichtDto GeefWeerbericht()
    {
        Weerbericht weerbericht = _weerBerichtProxy.MaakWeerbericht();

        return new WeerBerichtDto { MomentCreatie = weerbericht.MomentCreatie, TekstueleInhoud = weerbericht.TekstueleInhoud };
    }
}