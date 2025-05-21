namespace WeerEventsApi.Logging.Factories;

public static class MetingLoggerFactory
{
    public static IMetingLogger Create(bool decorateWithJson = false, bool decorateWithXml = false)
    {
        //TODO Alle combinaties moeten mogelijk zijn (false,false | true,false | false,true | true,true)
        bool decorateWithJson;
        bool decorateWithXml;
        
        subscribed op weerstations

        return new MetingLogger();
    }
}