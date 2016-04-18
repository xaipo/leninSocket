using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClienteChat
{
    class Conexion
    {
        private static volatile Conexion instance = null;
        private static readonly object padlock = new object();

        public Socket socket = IO.Socket("http://localhost:3000");
       string  macAddr =
      (from nic in NetworkInterface.GetAllNetworkInterfaces()
       where nic.OperationalStatus == OperationalStatus.Up
       select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
      
        private Conexion()
        {

            socket.On(Socket.EVENT_CONNECT, () =>
            {
                //obtener la mac 
               

                socket.Emit("enviomac", macAddr);


            });
        }

        public static Conexion getInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                            instance = new Conexion();
                    }
                }

                return instance;
            }
        }

      

    }
}
