using WeerEventsApi.Steden;
using WeerEventsApi.Steden.Managers;
using WeerEventsApi.Steden.Repositories;

namespace WeerEventsApi.Stations.Factories
{
    public static class WeerstationFactory
    {
        static Random random = new Random();
        static List<Weerstation> weerstations = new List<Weerstation>();
        static List<Stad> steden = new List<Stad>();

        private static StadManager _stadManager = new StadManager(new StadRepository());

        public static IEnumerable<Weerstation> MaakWeerstation()
        {
            steden = _stadManager.GeefSteden().ToList();
            for (int i = 0; i < 12; i++)
            {
                int num = random.Next(0, 4);
                int k = random.Next(0, 3);

                if (num == 0)
                {
                    Weerstation luchtdrukStation = new LuchtdrukStation(steden[k]);
                    weerstations.Add(luchtdrukStation);
                }
                else if (num == 1)
                {
                    Weerstation neerslagStation = new NeerslagStation(steden[k]);
                    weerstations.Add(neerslagStation);
                }
                else if (num == 2)
                {
                    Weerstation temperatuurStation = new TemperatuurStation(steden[k]);
                    weerstations.Add(temperatuurStation);
                }
                else
                {
                    Weerstation windStation = new WindStation(steden[k]);
                    weerstations.Add(windStation);
                }
            }
            return weerstations;  
        }
    }
}
