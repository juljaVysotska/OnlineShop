using System.Collections;
using System.Collections.Generic;
namespace OnlineShop
{
    public class ClientHandleData
    {

        private delegate void Packet_(byte[] Data);
        private Dictionary<int, Packet_> Packets;

        //text username, password;

        public void InitMessages()
        {
            Packets = new Dictionary<int, Packet_>();
            Packets.Add((int)Enumerations.ServerPackets.SAlertMsg, HandleAlertMsg);
            Packets.Add((int)Enumerations.ServerPackets.SLogin, HandleLogin);
        }

        public static ClientHandleData instance;

        public ClientHandleData()
        {
            instance = this;
        }

        public void Awake()
        {
            instance = this;
        }

        public void HandleLogin(byte[] data)
        {

            int packetnum;
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetnum = buffer.ReadInteger();

            int Result = buffer.ReadInteger();
            

            MainWindow.rindows.login(Result);

        }

        public void HandleData(byte[] data)
        {
            int packetnum;
            Packet_ Packet;
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetnum = buffer.ReadInteger();
            buffer = null;
            if (packetnum == 0)
                return;

            if (Packets.TryGetValue(packetnum, out Packet))
            {
                Packet.Invoke(data);
            }
        }

        void HandleAlertMsg(byte[] data)
        {
            int packetnum;
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetnum = buffer.ReadInteger();




            string AlertMsg = buffer.ReadString();

            //Debug.Log(AlertMsg);
        }

    }
}