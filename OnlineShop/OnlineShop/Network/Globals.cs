using System.Collections;
using System.Collections.Generic;

namespace OnlineShop
{
    public class Globals
    {
        public static Globals instance;


        public static Network network = new Network();

        public static ClientHandleData clientkHandleData = new ClientHandleData();
        public static ClientSendData clientSendData = new ClientSendData();

        public void Start()
        {
            instance = this;
        }

        public int MyIndex;
    }
}