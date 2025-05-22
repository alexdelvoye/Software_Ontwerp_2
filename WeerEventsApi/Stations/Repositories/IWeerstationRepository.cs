namespace WeerEventsApi.Stations.Repositories
{
    public interface IWeerstationRepository
    {
        IEnumerable<Weerstation> GetWeerstations();
    }
}
