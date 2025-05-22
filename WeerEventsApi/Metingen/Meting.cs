using WeerEventsApi.Steden;

namespace WeerEventsApi.Metingen
{
    public class Meting
    {
        public DateTime momentMeting {  get; set; }
        public double waarde {  get; set; }
        public string eenheid { get; set; }
        public Stad Stad {  get; set; }

        public override string ToString()
        {
            return $"{Stad.Naam}, {momentMeting}, {waarde}, {eenheid}" ;
        }
    }
}
