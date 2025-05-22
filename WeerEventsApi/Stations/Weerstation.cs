using WeerEventsApi.Metingen;
using WeerEventsApi.Logging.Observer;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public abstract class Weerstation : AbstractObservable
    {
        public Stad Stad {  get; set; }
        public List<Meting> Metingen = new();
        public abstract event EventHandler<Meting> MetingGemaakt;

        protected Weerstation(Stad stad)
        {
            Stad = stad;
        }

        protected Weerstation(Stad stad, List<Meting> metingen)
        {
            Stad = stad;
            Metingen = metingen;
        }

        public abstract void MaakMeting();

        public override string ToString()
        {
            return $"{Stad.Naam}, {Metingen}";
        }
    }
}
