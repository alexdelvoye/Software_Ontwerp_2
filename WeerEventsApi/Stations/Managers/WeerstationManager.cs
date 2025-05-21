using WeerEventsApi.Stations.Repositories;
using WeerEventsApi.Steden;
using WeerEventsApi.Steden.Repositories;

namespace WeerEventsApi.Stations.Managers
{
    public class WeerstationManager(IWeerstationRepository repository) : IWeerstationManager
    {
        public IEnumerable<Weerstation> GeefWeerstations()
        {
            return repository.GetWeerstations();
        }
    }
}
