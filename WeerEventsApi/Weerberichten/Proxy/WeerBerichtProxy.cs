using WeerEventsApi.Metingen;
using WeerEventsApi.Weerberichten.Manager;

namespace WeerEventsApi.Weerberichten.Proxy
{
    public class WeerBerichtProxy : IWeerBerichtManager
    {
        private IWeerBerichtManager _weerBerichtManager;

        private Weerbericht _weerbericht;
        private DateTime _laatstGemaakt;

        public WeerBerichtProxy(IWeerBerichtManager weerBerichtManager)
        {
            _weerBerichtManager = weerBerichtManager;
        }

        public Weerbericht MaakWeerbericht()
        {
            if (CheckCachedCooldown())
            {
                _weerbericht = _weerBerichtManager.MaakWeerbericht();
                _laatstGemaakt = DateTime.Now;
            }
            return _weerbericht;
        }

        public bool CheckCachedCooldown()
        {
            bool CooldownVerstreken = false;

            if (DateTime.Now - _laatstGemaakt > TimeSpan.FromMinutes(1))
            {
                CooldownVerstreken = true;
            }
            return CooldownVerstreken;
        }

        public void VoegMetingToe(Meting meting)
        {
            _weerBerichtManager.VoegMetingToe(meting);
        }
    }
}
