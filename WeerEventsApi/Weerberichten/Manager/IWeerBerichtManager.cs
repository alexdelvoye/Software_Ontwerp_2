using WeerEventsApi.Metingen;

namespace WeerEventsApi.Weerberichten.Manager
{
    public interface IWeerBerichtManager
    {
        public void VoegMetingToe(Meting meting);
        public Weerbericht MaakWeerbericht();
    }
}
