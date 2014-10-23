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
        private const string MethodField = "PUT ";
        StreamWriter sw;
 

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

            TcpClient clientSocket = new TcpClient("localhost", 8080);

            NetworkStream ns = clientSocket.GetStream();  //GET NETWORKSTREAM

          
           
           
           OpenWriter(ns, this.EstablishConnection());

          

           
           
            ns.Close();
            clientSocket.Close();
        }

        private string EstablishConnection()
        {
            return "Hi";
        }

   
        private void OpenWriter(NetworkStream nsw, string Message)
        {
            var sw = new StreamWriter(nsw);
            sw.AutoFlush = true;
            sw.Write(Message);
            
        }

        private string OpenReader(NetworkStream nsw)
        {
            var sr = new StreamReader(nsw);
            string getResponse = sr.ReadLine();
            if (getResponse != null)
            {
                return getResponse;
            }
            else
            {
                return "Fejl";
            }
        }


    }
}
