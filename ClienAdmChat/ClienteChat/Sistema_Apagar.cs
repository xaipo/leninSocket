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
    public partial class Sistema_Apagar : Form
    {
        FormAdmin formAcceso;
        public Sistema_Apagar(FormAdmin padre)
        {
            InitializeComponent();
            formAcceso = padre;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            Conexion con = Conexion.getInstance;
            con.socket.Emit("apagar", "apagar");
        }
    }
}
