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
                    Thread t = new Thread(Escucha_cli);
                    t.Start();
                    conect.socket.Emit("estado_clie", "encendido");
                    

                                 
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Something Went Wrong!!");
                Application.Exit();
            }
            if (flag == true)
            {
                MessageBoxTemporal.Show("Connect To Server!", "EXITO!", 2, false);
                //-- Ejecuta la app
                Application.Run(myform);               
            }
            else
            {
                MessageBox.Show("Failed To Connect To Server!", "Error!");
                Application.Exit();
            }         
                       
        }

        public static void Escucha_cli()
        {          

                conect.socket.On("mensaje", (data) =>
                {
                    
                    string val = data.ToString();
                    if (val.Equals("on"))
                    {

                       myform.FormClie_Resize();
                       ControlSecion frmControl = new ControlSecion();
                       frmControl.Show();
                        emitEstado("Desbloqueado");                    
                                                
                    }
                });

                    conect.socket.On("mensaje", (data) =>
                {
                    
                    string val = data.ToString();
                    if (val.Equals("off"))
                    {
                        
                        myform.FormClie_Resize_Normal();
                        emitEstado("Bloqueado");
                    }                 

                });

                conect.socket.On("apagarse", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("apagar"))
                    {
                        ApagarPC apg = new ApagarPC();
                        apg.Shut_Down();

                    }

                });

                conect.socket.On("mensajito", (data) =>
                {
                    string val = data.ToString();
                    if (val.Equals("prendido"))
                    {
                        myform.FormClie_Resize_Normal();
                        emitEstado("Bloqueado");
                        
                    }
                  
                });
        }


        public static void emitEstado(String msg)
        {
            conect.socket.Emit("devuelve", msg);

        }
       
    }
}
