using WeerEventsApi.Stations;
using WeerEventsApi.Stations.Factories;
using WeerEventsApi.Stations.Repositories;

namespace WeerEventsApi.Metingen.Repository
{
    public class MetingRepository : IMetingRepository
    {
        public IEnumerable<Meting> GetMetingen()
        {
            return MetingFactory.MaakMeting();
        }
    }
}
