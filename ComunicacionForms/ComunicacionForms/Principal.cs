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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is Label || c is TextBox || c is Button)
                {
                    Font nuevaFuente = new Font("Arial", 12, FontStyle.Bold);

                    c.Font = nuevaFuente;
                }
            }
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            Secundario secundario = new Secundario();

            secundario.ShowDialog();

            this.txtMensaje1.Text = secundario.Mensaje1;
            this.txtMensaje2.Text = secundario.Mensaje2;
        }

       
    }
}
