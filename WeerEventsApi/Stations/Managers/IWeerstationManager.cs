using WeerEventsApi.Metingen;

namespace WeerEventsApi.Stations.Managers
{
    public interface IWeerstationManager
    {
        IEnumerable<Weerstation> GeefWeerstations();
        public void MaakWeerstations();
        public IEnumerable<Meting> GeefMetingen();
        public void DoeMeting();
    }
}
