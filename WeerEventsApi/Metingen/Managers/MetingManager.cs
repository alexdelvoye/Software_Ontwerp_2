using WeerEventsApi.Stations;
using WeerEventsApi.Stations.Managers;
using WeerEventsApi.Stations.Repositories;

namespace WeerEventsApi.Metingen.Managers
{
    public class MetingManager(IMetingRepository repository) : IMetingManager
    {
        public IEnumerable<Meting> GeefMetingen()
        {
            return repository.GetMetingen();
        }
    }
}
