using System.Text.Json;
using WeerEventsApi.Metingen;

namespace WeerEventsApi.Logging.Decorators
{
    public class JsonLoggerDecorator : LoggerDecorator
    {
        private readonly string _pad = "log.json";

        public JsonLoggerDecorator(IMetingLogger metinglogger) : base(metinglogger)
        {
        }

        public override void Log(Meting meting)
        {
            string json = JsonSerializer.Serialize(meting, new JsonSerializerOptions { WriteIndented = true });

            File.AppendAllText(_pad, Environment.NewLine + json + Environment.NewLine);

            _metingLogger.Log(meting);
        }

        public override void Update(Meting meting)
        {
            Log(meting);
        }
    }
}
