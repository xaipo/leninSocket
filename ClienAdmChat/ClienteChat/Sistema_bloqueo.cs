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
    public partial class Sistema_bloqueo : Form
    {
        FormAdmin formAcceso;
        public Sistema_bloqueo(FormAdmin padre)
        {
            InitializeComponent();
            formAcceso = padre;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            formAcceso.btn_tiempoON();
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            formAcceso.btn_tiempoOFF();
            this.Close();
            

        }
    }
}
