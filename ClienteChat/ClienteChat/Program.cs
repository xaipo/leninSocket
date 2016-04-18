using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteChat
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conexion con = Conexion.getInstance;

            con.socket.On("respuesta", (data) =>
            {
                Console.WriteLine(data);
                con.socket.Disconnect();
            });

            Console.ReadLine();

            Application.Run(new Form1());
        }
    }
}
