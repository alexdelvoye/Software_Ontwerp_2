using WeerEventsApi.Facade.Dto;
using WeerEventsApi.Stations.Factories;
using WeerEventsApi.Stations.Managers;
using WeerEventsApi.Steden.Managers;

namespace WeerEventsApi.Facade.Controllers;

public class DomeinController : IDomeinController
{
    private readonly IStadManager _stadManager;
    private readonly IWeerstationManager _weerstationManager;

    public DomeinController(IStadManager stadManager, IWeerstationManager weerstationManager)
    {
        _stadManager = stadManager;
        _weerstationManager = weerstationManager;
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
        //TODO
        throw new NotImplementedException();
    }

    public void DoeMetingen()
    {
        //TODO
        throw new NotImplementedException();
    }

    public WeerBerichtDto GeefWeerbericht()
    {
        //TODO
        throw new NotImplementedException();
    }
}