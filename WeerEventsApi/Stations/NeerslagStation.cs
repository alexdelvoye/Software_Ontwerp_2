using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class NeerslagStation : Weerstation
    {
        public NeerslagStation(Stad stad) : base(stad)
        {
        }

        public NeerslagStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }
    }
}
