using WeerEventsApi.Steden;

namespace WeerEventsApi.Metingen
{
    public class Meting
    {
        public DateTime momentMeting {  get; set; }
        public double waarde {  get; set; }
        public List<string> eenheid = new List<string>{"Kilometer Per Uur",
                                                "Millimeter Per Vierkante Meter Per Uur",
                                                "Graden Celsius",
                                                "Hecto Pascal"
        };
        public Stad Stad {  get; set; }       
    }
}
