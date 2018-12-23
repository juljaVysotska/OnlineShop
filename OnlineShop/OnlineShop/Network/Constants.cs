using System.Collections;
using System.Collections.Generic;
namespace OnlineShop
{
    public class Constants 
    {

        public static Constants instance;

        private void Awake()
        {
            instance = this;
        }

        public const int MAX_PLAYERS = 100;
    }
}