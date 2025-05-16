using WeerEventsApi.Steden;

namespace WeerEventsApi.Steden.Repositories;

public interface IStadRepository
{
    IEnumerable<Stad> GetSteden();
}