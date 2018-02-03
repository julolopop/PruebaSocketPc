using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace PruebaSocketPc
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

           

            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse("192.168.1.40"), 1234);
            
          
            try

            {
                
                miPrimerSocket.Connect(miDireccion);    
                
                Console.WriteLine("Conectado con exito");

                byte[] msg = new byte[255];
                msg = Encoding.ASCII.GetBytes("Hola y adiso");
                miPrimerSocket.Send(msg);

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
