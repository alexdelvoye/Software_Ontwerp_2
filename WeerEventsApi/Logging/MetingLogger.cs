using WeerEventsApi.Metingen;

namespace WeerEventsApi.Logging;

public class MetingLogger : IMetingLogger
{
    public void Log(Meting meting)
    {
        Console.WriteLine(meting.ToString());
    }

    public void Update(Meting meting)
    {
        Log(meting);
    }
}