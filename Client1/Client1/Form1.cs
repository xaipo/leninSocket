using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;
using System.Threading;

namespace Client1
{
    public partial class FormClie : Form
    {
      //  Conexion con = Conexion.getInstance;
        Boolean estado;
       
        public FormClie()
        {
            InitializeComponent();
           
           FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            this.ShowInTaskbar = false;
            BackgroundImageLayout = ImageLayout.Stretch;
           
            
        }

        public void FormClie_Resize()
        {
           //-- para minimizar la app a la barra de notificaciones
            this.Visible = false;
            //WindowState = FormWindowState.Minimized;
            ControlSecion frmControl = new ControlSecion();
            frmControl.Show();          
            
           
            

        }
        public void FormClie_Resize_Normal()
        {

           // this.Show();
           // this.WindowState = FormWindowState.Maximized;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.Visible = true;
            TopMost = false;

        }
        private void formFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Impedir que el formulario se cierre pulsando X o Alt + F4 
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        } 



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormClie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
                        
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            FormClie_Resize();
          //  ControlSecion frmControl = new ControlSecion();
         //   frmControl.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Seguro que deseas apagar la PC", "Apagar PC",MessageBoxButtons.OKCancel);
            if (opcion == DialogResult.OK)
            {
                ApagarPC apg = new ApagarPC();
                apg.Shut_Down();
            }
            else
            {
                
            }

        }

        private void FormClie_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Impedir que el formulario se cierre pulsando X o Alt + F4 
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }  
        }

        private void btnCerrarSe_Click(object sender, EventArgs e)
        {

            FormClie_Resize_Normal();
            Program.emitEstado("Bloqueado");
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            // ControlSecion frmControl = new ControlSecion();
            //frmControl.Show();
            Prueba Prueba = new Prueba();
            Prueba.Show();

        }
        public void FormClie_Resize_Prueba()
        {

            // this.Show();
            // this.WindowState = FormWindowState.Maximized;

            
            WindowState = FormWindowState.Minimized;
            // ControlSecion frmControl = new ControlSecion();
            //frmControl.Show();
            Prueba Prueba = new Prueba();
            Prueba.Show();

        }
      
    }
}
