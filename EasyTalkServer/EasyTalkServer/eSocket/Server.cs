using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Net.Sockets;


namespace EasyTalkServer.eSocket
{
    class Server
    {
        public void Start()
        {
            //将域名解析成IP地址
            IPAddress []adresses = Dns.GetHostAddresses("cnhun.3322.org");
            IPAddress adress = adresses[0];

            //创建连接，端口号为8082
            IPEndPoint endPoit = new IPEndPoint(adress,8082);
            Socket sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sok.Bind(endPoit);

            Socket client=sok.Accept();
            

        }
        
    }
}
