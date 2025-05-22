using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class WindStation : Weerstation
    {
        Random random = new Random();
        public override event EventHandler<Meting> MetingGemaakt;

        public WindStation(Stad stad) : base(stad)
        {
        }

        public WindStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }

        public override void MaakMeting()
        {
            Meting meting = new Meting();

            int num = random.Next(1, 40);
            meting.Stad = Stad;
            meting.waarde = num;
            meting.eenheid = "Kilometer Per Uur";
            meting.momentMeting = DateTime.Now;

            Metingen.Add(meting);

            NotifyObservers(meting);

            MetingGemaakt?.Invoke(this, meting);
        }
    }
}
