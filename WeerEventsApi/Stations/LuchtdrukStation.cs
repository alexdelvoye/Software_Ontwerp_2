using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class LuchtdrukStation : Weerstation
    {
        public LuchtdrukStation(Stad stad) : base(stad)
        {
        }

        public LuchtdrukStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }
    }
}
