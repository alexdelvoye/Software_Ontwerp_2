using WeerEventsApi.Metingen;
using WeerEventsApi.Steden;

namespace WeerEventsApi.Stations
{
    public class LuchtdrukStation : Weerstation
    {
        Random random = new Random();
        public override event EventHandler<Meting> MetingGemaakt;

        public LuchtdrukStation(Stad stad) : base(stad)
        {
        }

        public LuchtdrukStation(Stad stad, List<Meting> metingen) : base(stad, metingen)
        {
        }

        public override void MaakMeting()
        {
            Meting meting = new Meting();

            int num = random.Next(940, 1061);
            meting.Stad = Stad;
            meting.waarde = num;
            meting.eenheid = "Hecto Pascal";
            meting.momentMeting = DateTime.Now;

            base.Metingen.Add(meting);

            NotifyObservers(meting);

            MetingGemaakt?.Invoke(this, meting);
        }
    }
}
