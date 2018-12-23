using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace OnlineShop
{
    public class ClientSendData 
{
    public static ClientSendData instance;
    public Network network;




        

    // Use this for initialization
    void Awake()
    {
        instance = this;
    }

    public void SendDataToServer(byte[] data)
    {
        ByteBuffer buffer = new ByteBuffer();
        buffer.WriteBytes(data);
            Globals.network.myStream.Write(buffer.ToArray(), 0, buffer.ToArray().Length);
            
        buffer = null;
    }

    public void SendNewAccount(string USName, string USPass)
    {

        ByteBuffer buffer = new ByteBuffer();

        buffer.WriteInteger((int)Enumerations.ClientPackets.CNewAccount);
            buffer.WriteString(USName);
        buffer.WriteString(USPass);

        SendDataToServer(buffer.ToArray());
        buffer = null;
    }

    public void SendLogin(string USName, string USPass)
        {
            ByteBuffer buffer = new ByteBuffer();

        buffer.WriteInteger((int)Enumerations.ClientPackets.CHandleLogin);
        buffer.WriteString(USName);
        buffer.WriteString(USPass);

        SendDataToServer(buffer.ToArray());
        buffer = null;
    }
}
}