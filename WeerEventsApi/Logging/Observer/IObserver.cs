using WeerEventsApi.Metingen;

namespace WeerEventsApi.Logging.Observer
{
    public interface IObserver
    {
        public abstract void Update(Meting meting);
    }
}
