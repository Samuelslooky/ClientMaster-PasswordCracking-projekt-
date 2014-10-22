using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientMaster
{
    public class HTTPClient
    {
        public HTTPClient()
        {

        }

        /// <summary>
        /// En klasse som har til ansvar at oprette forbindelse til Server slaverne
        /// </summary>
        
        public void Socket()
        {
            //Her oprettes en TCPClient samt en networkstream, StreamWriter og Streamreader
            Console.ReadLine();

            TcpClient clientSocket = new TcpClient("10.154.1.251", 8080);

            Stream ns = clientSocket.GetStream();  //GET NETWORKSTREAM
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.AutoFlush = true; // enable automatic flushing

            String message = Console.ReadLine();
            sw.WriteLine(message);
            String answer = sr.ReadLine();
            Console.WriteLine("Server: " + answer);

            ns.Close();
            clientSocket.Close();
        }
            
        
        


    }
}
