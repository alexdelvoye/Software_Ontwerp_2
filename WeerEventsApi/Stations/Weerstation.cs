using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public abstract class Weerstation
    {
        public Stad Stad {  get; set; }
        public List<Meting> Metingen {  get; set; }

        public List<Meting> GeefMetingen()
        {
            return Metingen;
        }

        public Meting GenereerMeting()
        {
            Meting meting;

            return meting;
        }
    }
}
