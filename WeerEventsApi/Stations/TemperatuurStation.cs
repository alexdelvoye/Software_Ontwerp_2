using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class TemperatuurStation : Weerstation
    {
        Random random = new Random();
        public override event EventHandler<Meting> MetingGemaakt;

        public TemperatuurStation(Stad stad) : base(stad)
        {
        }

        public TemperatuurStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }

        public override void MaakMeting()
        {
            Meting meting = new Meting();

            int num = random.Next(-10, 40);
            meting.Stad = Stad;
            meting.waarde = num;
            meting.eenheid = "Graden Celsius";
            meting.momentMeting = DateTime.Now;

            Metingen.Add(meting);

            NotifyObservers(meting);

            MetingGemaakt?.Invoke(this, meting);
        }
    }
}
