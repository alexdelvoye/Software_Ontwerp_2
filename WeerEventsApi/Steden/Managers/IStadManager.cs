using WeerEventsApi.Steden;

namespace WeerEventsApi.Steden.Managers;

public interface IStadManager
{
    IEnumerable<Stad> GeefSteden();
}