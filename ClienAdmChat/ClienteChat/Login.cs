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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
       
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtContraseña.Text != ""))
            {

                if ((txtUsuario.Text == "Normal") && (txtContraseña.Text == "000"))
                {
                  
                    MessageBoxTemporal.Show("Bienvenido:  " + "\n" + txtUsuario.Text, "Conexion", 1, false);
                }
                if ((txtUsuario.Text == "Admin") && (txtContraseña.Text == "000"))
                {
                    MessageBoxTemporal.Show("Bienvenido:  " + "\n" + txtUsuario.Text, "Conexion", 1, false);
                }
                this.Dispose();
             

            }
            else
                MessageBox.Show("Verifique bien los Datos");
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
