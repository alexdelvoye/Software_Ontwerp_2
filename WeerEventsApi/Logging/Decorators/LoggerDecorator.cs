using WeerEventsApi.Metingen;

namespace WeerEventsApi.Logging.Decorators
{
    public abstract class LoggerDecorator : IMetingLogger
    {
        protected readonly IMetingLogger _metingLogger;

        public LoggerDecorator(IMetingLogger metingLogger)
        {
            _metingLogger = metingLogger;
        }

        public abstract void Log(Meting meting);

        public abstract void Update(Meting meting);
    }
}
