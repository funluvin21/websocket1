using SuperSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websocket1
{
    class Program
    {
        private static WebSocketServer wsServer;

        static void Main(string[] args)
        {
            wsServer = new WebSocketServer();
            int port = 8801;
            wsServer.Setup(port);

            wsServer.NewSessionConnected += WsServer_NewSessionConnected;
            wsServer.NewMessageReceived += WsServer_NewMessageReceived;
            wsServer.NewDataReceived += WsServer_NewDataReceived;

        }

        private static void WsServer_NewDataReceived(WebSocketSession session, byte[] value)
        {
            throw new NotImplementedException();
        }

        private static void WsServer_NewMessageReceived(WebSocketSession session, string value)
        {
            throw new NotImplementedException();
        }

        private static void WsServer_NewSessionConnected(WebSocketSession session)
        {
            throw new NotImplementedException();
        }
    }
}
