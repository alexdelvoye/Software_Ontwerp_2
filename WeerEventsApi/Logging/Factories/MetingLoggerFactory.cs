using WeerEventsApi.Logging.Decorators;

namespace WeerEventsApi.Logging.Factories;

public static class MetingLoggerFactory
{
    public static IMetingLogger Create(bool decorateWithJson, bool decorateWithXml)
    {
        IMetingLogger metingLogger = new MetingLogger();

        if (decorateWithJson)
        {
            metingLogger = new JsonLoggerDecorator(metingLogger);
        }

        if (decorateWithXml)
        {
            metingLogger = new XmlLoggerDecorator(metingLogger);
        }

        return metingLogger;
    }
}