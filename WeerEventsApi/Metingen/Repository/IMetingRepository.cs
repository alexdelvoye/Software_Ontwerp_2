using WeerEventsApi.Stations;

namespace WeerEventsApi.Metingen.Repository
{
    public interface IMetingRepository
    {
        IEnumerable<Meting> GetMetingen();
    }
}
