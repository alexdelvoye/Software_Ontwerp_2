using WeerEventsApi.Metingen;
using WeerEventsApi.Stations.Repositories;

namespace WeerEventsApi.Stations.Managers
{
    public class WeerstationManager(IWeerstationRepository repository) : IWeerstationManager
    {
        public IEnumerable<Weerstation> weerstations;
        
        public void MaakWeerstations()
        {
            weerstations =  repository.GetWeerstations();
        }

        public IEnumerable<Weerstation> GeefWeerstations()
        {
            return weerstations;
        }

        public IEnumerable<Meting> GeefMetingen()
        {
            List<Meting> alleMetingen = new List<Meting>();
            
            foreach (Weerstation weerstation in weerstations)
            {
                foreach(Meting meting in weerstation.Metingen) 
                {
                    alleMetingen.Add(meting);
                }
            }
            return alleMetingen;    
        }

        public void DoeMeting()
        {
            foreach (Weerstation weerstation in weerstations)
            {
                weerstation.MaakMeting();
            }
        }
    }
}
