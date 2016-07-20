using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClienteChat
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]
        static Conexion conect;
        static FormAdmin myform;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myform = new FormAdmin();

          /*  con.socket.On("respuesta", (data) =>
            {
                Console.WriteLine(data);
               // con.socket.Disconnect();
            });*/
            bool flag = false;
            try
            {
                conect = Conexion.getInstance;
                if (conect.isConnect == true)
                {
                    flag = true;
                    Thread t = new Thread(Escuchar);
                    t.Start();
                   conect.socket.Emit("esta_admin", "prendido");
                    
                }
                if (flag == true)
                {
                    
                    MessageBoxTemporal.Show("App Adminitrador Conectado!", "Conexion", 1, false);
                    Application.Run(myform);
                }
                else
                {
                    MessageBox.Show("Error al conectar con el servidor!", "Error!");
                    Application.Exit();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Algo Ocurrio mal en la conexion!!");
                Application.Exit();
            }
           
                      
        }

        public static void Escuchar()
        {

                conect.socket.On("estado", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("Bloqueado"))
                    {

                        myform.btn_Encender();


                    }
                  
                    if (val.Equals("Desbloqueado"))
                    {

                        MessageBox.Show("Desbloquedo", "Exito");
                    }


                });

                conect.socket.On("messag", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("encendido"))
                    {
                      
                        conect.socket.Emit("desbloquear", "off");

                    }

                });

               conect.socket.On("desco_clie", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("Bloqueado"))
                    {
                        myform.btn_Apagar();
                        MessageBox.Show("Bloquedo2", "Exito");
                    }



                });

        }  

    }
}
