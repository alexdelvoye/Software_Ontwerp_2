using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class TemperatuurStation : Weerstation
    {
        public TemperatuurStation(Stad stad) : base(stad)
        {
        }

        public TemperatuurStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }
    }
}
