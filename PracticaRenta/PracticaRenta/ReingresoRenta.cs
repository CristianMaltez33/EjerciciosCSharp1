using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRenta
{
    public partial class ReingresoRenta : Form
    {
        int index;
        public ReingresoRenta(int index)
        {
            InitializeComponent();

            this.index = index;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Rentas = VistaRentas.ObtenerRenta();

        }
    }
}
