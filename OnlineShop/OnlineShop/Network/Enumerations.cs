using System.Collections;
using System.Collections.Generic;

namespace OnlineShop
{
    public class Enumerations
    {
        public static Enumerations instance;

        private void Awake()
        {
            instance = this;
        }

        public enum ServerPackets
        {
            SAlertMsg = 1,
            SLogin
        }

        public enum ClientPackets
        {
            CNewAccount = 1,
            CHandleLogin
        }
    }
}