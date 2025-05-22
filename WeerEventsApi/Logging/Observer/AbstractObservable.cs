using WeerEventsApi.Metingen;

namespace WeerEventsApi.Logging.Observer
{
    public abstract class AbstractObservable
    {
        private List<IObserver> _observers = [];

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(Meting meting)
        {          
            foreach (var observer in _observers)
            {
                observer.Update(meting);
            }
        }
    }
}
