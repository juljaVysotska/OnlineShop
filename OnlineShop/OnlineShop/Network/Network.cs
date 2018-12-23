using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;
using System;


namespace RefuelingNetwork
{
    public class Network
    {

        public static Network instance;



        //Network Settings
        public string ServerIP = "127.0.0.1";
        public int ServerPort = 6543;
        public bool isConnected;

        public TcpClient UserSocket;
        public NetworkStream myStream;
        public StreamReader myReader;
        public StreamWriter myWriter;

        private byte[] asyncBuff;
        public bool shouldHandleData;
        private byte[] myBytes;

        private void Awake()
        {
            instance = this;
        }

        // Use this for initialization
        public void Start()
        {
            ConnectServer();
        }

        void ConnectServer()
        {
            if (UserSocket != null)
            {
                if (UserSocket.Connected || isConnected)
                    return;
                UserSocket.Close();
                UserSocket = null;
            }

            UserSocket = new TcpClient();
            UserSocket.ReceiveBufferSize = 4096;
            UserSocket.SendBufferSize = 4096;
            UserSocket.NoDelay = false;
            Array.Resize(ref asyncBuff, 8192);
            UserSocket.BeginConnect(ServerIP, ServerPort, new AsyncCallback(ConnectCallback), UserSocket);
            isConnected = true;
        }

        void ConnectCallback(IAsyncResult result)
        {
            if (UserSocket != null)
            {
                UserSocket.EndConnect(result);
                if (UserSocket.Connected == false)
                {
                    isConnected = false;
                    return;
                }
                else
                {
                    UserSocket.NoDelay = true;
                    myStream = UserSocket.GetStream();
                    myStream.BeginRead(asyncBuff, 0, 8192, OnReceive, null);
                }
            }
        }

        private void Update()
        {
            if (shouldHandleData)
            {
                ClientHandleData.instance.HandleData(myBytes);
                shouldHandleData = false;
            }
        }

        void OnReceive(IAsyncResult result)
        {

            if (UserSocket != null)
            {
                if (UserSocket == null)
                    return;

                int byteArray = myStream.EndRead(result);
                myBytes = null;
                Array.Resize(ref myBytes, byteArray);
                Buffer.BlockCopy(asyncBuff, 0, myBytes, 0, byteArray);

                if (byteArray == 0)
                {
                    UserSocket.Close();
                    return;
                }

                shouldHandleData = true;

                if (UserSocket == null)
                    return;
                myStream.BeginRead(asyncBuff, 0, 8192, OnReceive, null);
            }
            
        }
    }
}