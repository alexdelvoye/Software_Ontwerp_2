using System.Text.Json;
using WeerEventsApi.Stations.Factories;

namespace WeerEventsApi.Stations.Repositories
{
    public class WeerstationRepository : IWeerstationRepository
    {
        public IEnumerable<Weerstation> GetWeerstations()
        {
            return WeerstationFactory.MaakWeerstation();
        }
    }
}
