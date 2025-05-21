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
                int num = random.Next(1, 5);
                int k = random.Next(0, 3);

                if (num == 1)
                {
                    Weerstation luchtdrukStation = new LuchtdrukStation(steden[k]);
                    weerstations.Add(luchtdrukStation);
                }
                else if (num == 2)
                {
                    Weerstation neerslagStation = new LuchtdrukStation(steden[k]);
                    weerstations.Add(neerslagStation);
                }
                else if (num == 3)
                {
                    Weerstation temperatuurStation = new LuchtdrukStation(steden[k]);
                    weerstations.Add(temperatuurStation);
                }
                else
                {
                    Weerstation windStation = new LuchtdrukStation(steden[k]);
                    weerstations.Add(windStation);
                }
            }
            return weerstations;  
        }
    }
}
