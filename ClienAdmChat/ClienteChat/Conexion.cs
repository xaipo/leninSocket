using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClienteChat
{
    class Conexion
    {
        private static volatile Conexion instance = null;
        private static readonly object padlock = new object();
        public Socket socket = IO.Socket("http://localhost:3000");
        public Boolean isConnect = false;  

       string  macAddr =
      (from nic in NetworkInterface.GetAllNetworkInterfaces()
       where nic.OperationalStatus == OperationalStatus.Up
       select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
      
        private Conexion()
        {
               try
            {
            

            socket.On(Socket.EVENT_CONNECT, () =>
            {
                //obtener la mac 
               

                socket.Emit("enviomac", macAddr);
               // socket.Emit("esta_admin", "prendido");
              isConnect = true;

            });
            //MessageBox.Show(isConnect.ToString());
            MessageBoxTemporal.Show("Conectando...", "Conexion", 1, false);
           //isConnect = true;
            }
               catch (Exception e)
               {
                   throw e;
                   MessageBox.Show(e.ToString(), "Algo salio mal en la conexcion!!");
                   Application.Exit();
               }
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
