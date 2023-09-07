using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicacionForms
{
    public partial class Secundario : Form
    {
        public string Mensaje1, Mensaje2;
        public Secundario()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.txtMensaje1.Text) || String.IsNullOrEmpty(this.txtMensaje2.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                this.Mensaje1 = this.txtMensaje1.Text;
                this.Mensaje2 = this.txtMensaje2.Text;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Mensaje1 = null;
            this.Mensaje2 = null;
            this.Close();
        }

        
    }
}
