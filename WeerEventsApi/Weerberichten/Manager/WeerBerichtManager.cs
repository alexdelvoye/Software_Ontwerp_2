using WeerEventsApi.Metingen;

namespace WeerEventsApi.Weerberichten.Manager
{
    public class WeerBerichtManager : IWeerBerichtManager
    {
        private readonly List<Meting> _ontvangenMetingen = new List<Meting>();

        public void VoegMetingToe(Meting meting)
        {
            _ontvangenMetingen.Add(meting);
        }

        public Weerbericht MaakWeerbericht()
        {
            Random random = new Random();
            int aantalMetingen = _ontvangenMetingen.Count;
            string weerGuru;
            Weerbericht weerbericht = new Weerbericht();

            int num = random.Next(0, 2);
            if (num == 0) weerGuru = "slecht";
            else weerGuru = "goed";

            weerbericht.MomentCreatie = DateTime.Now;
            weerbericht.TekstueleInhoud = $"Op basis van {aantalMetingen} metingen en mijn diepzinnig computermodel kan ik zeggen dat er kans is op {weerGuru} weer.";

            Thread.Sleep(5000);

            return weerbericht;
        }
    }
}
