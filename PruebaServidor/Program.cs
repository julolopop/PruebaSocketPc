using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PruebaServidor
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse("192.168.1.40"), 1234);
            
            try
            {
                // paso 4
                miPrimerSocket.Bind(miDireccion); 
                miPrimerSocket.Listen(1); 
                Console.WriteLine("Escuchando...");
                Socket Escuchar = miPrimerSocket.Accept();
                byte[] msg = new byte[255];
                Escuchar.Receive(msg);
                Console.WriteLine(Encoding.ASCII.GetString(msg));
             
                Console.WriteLine("Conectado con exito");



               
                miPrimerSocket.Close(); 
            }
            catch (Exception error)

            {
                Console.WriteLine("Error: {0}", error.ToString());
            }

            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();



        }
    }
}
