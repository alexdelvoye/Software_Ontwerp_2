using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class NeerslagStation : Weerstation
    {
        Random random = new Random();
        public override event EventHandler<Meting> MetingGemaakt;

        public NeerslagStation(Stad stad) : base(stad)
        {
        }

        public NeerslagStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }

        public override void MaakMeting()
        {
            Meting meting = new Meting();

            int num = random.Next(0, 25);
            meting.Stad = Stad;
            meting.waarde = num;
            meting.eenheid = "Millimeter Per Vierkante Meter Per Uur";
            meting.momentMeting = DateTime.Now;

            Metingen.Add(meting);

            NotifyObservers(meting);

            MetingGemaakt?.Invoke(this, meting);
        }
    }
}
