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
    public partial class FormAdmin : Form
    {
        bool estado = false;

        public FormAdmin()
        {
            InitializeComponent();
            bttonpc1.BackgroundImage = Image.FromFile(@"C:\Users\Lench0\Desktop\1463744082_computer.ico");
            bttonpc1.Visible = false;
            CheckForIllegalCrossThreadCalls = false;   
        }
        public void btn_Encender()
        {

            this.bttonpc1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hola");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion con = Conexion.getInstance;
            con.socket.Emit("msgg", "Este es un mensaje");
        }

        private void bttonpc_Click(object sender, EventArgs e)
        {
            
            Conexion con = Conexion.getInstance;
            if (estado == true)
            {
                bttonpc1.BackgroundImage = Image.FromFile(@"C:\Users\Lench0\Desktop\1463744082_computer.ico");
                estado = false;
                con.socket.Emit("desbloquear", "off");
            }
            else
            {
                bttonpc1.BackgroundImage = Image.FromFile(@"C:\Users\Lench0\Desktop\1463744101_imac.ico");
                estado = true;
                con.socket.Emit("desbloquear", "on");
            }
            
           
            

        }
    }
}
