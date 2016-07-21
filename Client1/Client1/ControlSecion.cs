using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Client1
{
    public partial class ControlSecion : Form
    {      
        int seg;
        int min;
        int hor;
        public ControlSecion()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CheckForIllegalCrossThreadCalls = false;
            WindowState = FormWindowState.Normal;
            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            this.ShowInTaskbar = false;     
            tiempo_trans.Start();
            txt_hora_ini.Text = DateTime.Now.ToLongTimeString();
            txt_user.Text = "Usuario sin deficinir";
            Posicionar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult opcion;
                opcion = MessageBox.Show("Seguro que deseas Cerrar Sesion", "Escoger PC", MessageBoxButtons.OKCancel);
                if (opcion == DialogResult.OK)
                {
                    FormClie myform = new FormClie();
                    myform.Show();
                    Close();

                }       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tiempo_trans_Tick(object sender, EventArgs e)
        {

            if (min == 60)
            {
                hor += 1;
                min = 0;
            }
            if (seg == 60)
            {
                min += 1;
                seg = 0;
            }
            seg +=1;
            txttiempo1.Text = hor.ToString()+ ":" + min.ToString() + ":" + seg.ToString();
        }

        
        public void Posicionar()
        {
        
          int height = Screen.PrimaryScreen.WorkingArea.Size.Height;
          int width = Screen.PrimaryScreen.WorkingArea.Size.Width;
          int posY = height - 274;  //(que 312 es el alto del formulario)
          int posX = width - 210; //(que 227 es el ancho del formulario)
          this.Location = new Point(posX, posY);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ControlSecion_Load(object sender, EventArgs e)
        {

        }
    }
}
