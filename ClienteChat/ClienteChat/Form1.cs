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

            var socket = IO.Socket("http://localhost:3000");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
               socket.Emit("hi","hola mundo");
                
                /*socket.On("hi", (data) =>
                {
                   // Console.WriteLine(data);
                    socket.Disconnect();
                });*/
            });
            Console.ReadLine();




        }
    }
}
