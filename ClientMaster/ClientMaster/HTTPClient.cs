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

            NetworkStream ns = clientSocket.GetStream();  //GET NETWORKSTREAM

            OpenWriter(ns);
            string theResponse = OpenReader(ns);

            Console.WriteLine("Server answer: " + theResponse);

            ns.Close();
            clientSocket.Close();
        }

        private string AssembleHttpMessage()
        {

             return "GET " + "\\" + "CrackedPasswords.txt" + "HTTP/1.0";

        }

        private void OpenWriter(NetworkStream nsw)
        {
            var sw = new StreamWriter(nsw);
            sw.AutoFlush = true;
            sw.Write(this.AssembleHttpMessage());
        }

        private string OpenReader(NetworkStream nsw)
        {
            var sr = new StreamReader(nsw);
            string getResponse = sr.ReadLine();

            return getResponse;
        }


    }
}
