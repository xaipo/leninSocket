using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Client1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
     //   [STAThread]
        static Conexion conect;
        static FormClie myform;
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myform = new FormClie();
            
            bool flag = false;
            try
            {
                conect = Conexion.getInstance;
                if (conect.isConnect)
                {
                    flag = true;
                    Thread t = new Thread(On);
                    t.Start();
                    Program.emitEstado("Bloqueado");
                    Application.Run(myform);
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Something Went Wrong!!");
                Application.Exit();
            }
            if (flag == true)
            {
                MessageBox.Show("Connect To Server!", "EXITO!");
            }
            else
            {
                MessageBox.Show("Failed To Connect To Server!", "Error!");
                Application.Exit();
            }         
                       
        }

        public static void On()
        {
            Boolean flag = true;
           // while (flag)
          //  {
              
                conect.socket.On("mensaje", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("on"))
                    {

                        
                        myform.FormClie_Resize();
                        emitEstado("Desbloqueado");
                        flag = false;
                        
                        
                        
                    }
                    if (val.Equals("off"))
                    {
                        
                        myform.FormClie_Resize_Normal();
                        emitEstado("Bloqueado");
                        flag = false;
                    }
                    

                });
              //  MessageBox.Show("Failed To Connect To Server!", "Error!");
            //}
        }


        public static void emitEstado(String msg)
        {
            conect.socket.Emit("devuelve", msg);

        }

       
    }
}
