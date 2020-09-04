using System.Net.Sockets;

namespace MasterProxy
{
    public class TcpTunnel
    {
        public TcpClient ConsumerClient;
        public TcpClient ClientServerClient;
    }
}