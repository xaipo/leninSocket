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
                if (conect.isConnect)
                {
                    flag = true;
                    Thread t = new Thread(Escuchar);
                    t.Start();
                    Application.Run(myform);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Algo Ocurrio mal en la conexion!!");
                Application.Exit();
            }
            if (flag == true)
            {
                MessageBox.Show("App Adminitrador Conectado!", "EXITO!");
            }
            else
            {
                MessageBox.Show("Error al conectar con el servidor!", "Error!");
                Application.Exit();
            }
                      
        }

        public static void Escuchar()
        {
            Boolean flag = true;
          //  while (flag)
            //{

                conect.socket.On("estado", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("Bloqueado"))
                    {

                        myform.btn_Encender();
                        MessageBox.Show("Bloquedo");
                        flag = false;


                    }
                    if (val.Equals("Desbloqueado"))
                    {

                        MessageBox.Show("Desbloquedo");
                        flag = false;
                    }


                });
               conect.socket.On("desco_clie", (data) =>
                {
                    string val = data.ToString();
                        myform.btn_Apagar();
                        MessageBox.Show("Bloquedo");
                        flag = false;



                });


                //  MessageBox.Show("Failed To Connect To Server!", "Error!");
           // }
        }  

    }
}
