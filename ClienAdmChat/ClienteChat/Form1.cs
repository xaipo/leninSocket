﻿using Quobject.SocketIoClientDotNet.Client;
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
       public bool estado = false;
       public bool op = false;
       Conexion con = Conexion.getInstance;

        public FormAdmin()
        {
            InitializeComponent();
            bttonpc1.BackgroundImage = Image.FromFile(@"C:\Lenin\leninSocket\ClienAdmChat\icons\1463744082_computer.ico");
            bttonpc1.Visible = false;
            CheckForIllegalCrossThreadCalls = false;
            Login frmAbout = new Login();
            frmAbout.ShowDialog();
            
            
        }
        public void btn_Encender()
        {
            bttonpc1.BackgroundImage = Image.FromFile(@"C:\Lenin\leninSocket\ClienAdmChat\icons\1463744082_computer.ico");
            this.bttonpc1.Visible = true;
            estado = false;

        }
        public void btn_Apagar()
        {

            this.bttonpc1.Visible = false;
          

        }
        public void btn_Usado()
        {
            
            bttonpc1.BackgroundImage = Image.FromFile(@"C:\Lenin\leninSocket\ClienAdmChat\icons\1463744101_imac.ico");
            estado = true;           
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
                     
            if (estado == true)
            {
                MessageBoxTemporal.Show("Pc ya esta en uso!", "Estado", 1, false);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Seguro que deseas Escoger esta PC", "Escoger PC", MessageBoxButtons.OKCancel);
                if (opcion == DialogResult.OK)
                {
                    btn_Usado();
                    con.socket.Emit("desbloquear", "on");
                }
                
            }
            
           
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult opcion;
            opcion = MessageBox.Show("Seguro que deseas apagar la PC", "Apagar PC", MessageBoxButtons.OKCancel);
            if (opcion == DialogResult.OK)
            {
                Conexion con = Conexion.getInstance;
                con.socket.Emit("apagar", "apagar");
            }
            else
            {

            }
                     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            con.socket.Emit("desbloquear", "prueba");
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void btntiempo_Click(object sender, EventArgs e)
        {
            if (op == true)
            {
                
                Sistema_bloqueooff frmAbout = new Sistema_bloqueooff();
                frmAbout.Show();
                btn_tiempoOFF();
                op = false;

            }
            else
            {
                
                Sistema_bloqueo frmAbout = new Sistema_bloqueo();
                frmAbout.Show();
                btn_tiempoON();
                op = true;

            }
            
        }
        public void btn_tiempoON()
        {
            btntiempo.BackColor = Color.RosyBrown;
        }

        public void btn_tiempoOFF()
        {
            btntiempo.BackColor = Color.LightSteelBlue;
        }
    }
}
