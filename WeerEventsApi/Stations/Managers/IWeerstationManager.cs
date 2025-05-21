using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations.Managers
{
    public interface IWeerstationManager
    {
        IEnumerable<Weerstation> GeefWeerstations();
    }
}
