using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hola");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion con = Conexion.getInstance;

            con.socket.On("respuesta", (data) =>
            {
                Console.WriteLine(data);
                MessageBox.Show(data.ToString());
                con.socket.Disconnect();
            });

            Console.ReadLine();
        }
    }
}
