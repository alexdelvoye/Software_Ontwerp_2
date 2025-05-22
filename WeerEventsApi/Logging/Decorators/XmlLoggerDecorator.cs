using System.Xml;
using System.Xml.Serialization;
using WeerEventsApi.Metingen;

namespace WeerEventsApi.Logging.Decorators
{
    public class XmlLoggerDecorator : LoggerDecorator
    {
        private readonly string _pad = "log.xml";

        public XmlLoggerDecorator(IMetingLogger metinglogger) : base(metinglogger)
        {
        }

        public override void Log(Meting meting)
        {
            var serializer = new XmlSerializer(typeof(Meting));

            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                OmitXmlDeclaration = true
            };

            var xml = $@"<Meting>
    <Moment>{meting.momentMeting}</Moment>
    <Waarde>{meting.waarde}</Waarde>
    <Eenheid>{meting.eenheid}</Eenheid>
</Meting>";

            File.AppendAllText(_pad, Environment.NewLine + xml + Environment.NewLine);

            _metingLogger.Log(meting);
        }

        public override void Update(Meting meting)
        {
            Log(meting);
        }
    }
}
