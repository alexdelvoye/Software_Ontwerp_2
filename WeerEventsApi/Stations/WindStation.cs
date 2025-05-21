using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class WindStation : Weerstation
    {
        public WindStation(Stad stad) : base(stad)
        {
        }

        public WindStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }
    }
}
