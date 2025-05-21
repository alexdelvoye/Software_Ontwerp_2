using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public abstract class Weerstation
    {
        public Stad Stad {  get; set; }
        public List<Meting> Metingen {  get; set; }

        protected Weerstation(Stad stad)
        {
            Stad = stad;
        }

        protected Weerstation(Stad stad, List<Meting> metingen)
        {
            Stad = stad;
            Metingen = metingen;
        }

        public override string ToString()
        {
            return $"{Stad}";
        }
    }
}
