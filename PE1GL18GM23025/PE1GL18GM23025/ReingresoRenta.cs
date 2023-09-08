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

            if (String.IsNullOrEmpty(mtxtKmRenta.Text))
            {
                epDatos.SetError(mtxtKmRenta, "El campo no pude estar vacio");
                return;
            }
            else
                epDatos.Clear();
            
            List<object> Rentas = VistaRentas.ObtenerRenta();

            if (Rentas[index] is Renta renta)
            {
                renta.FechaDevolucion = (dtpFechaReingreso.Value).ToString("dd-MM-yyyy");
                renta.kmDespuesR = Convert.ToDouble(this.mtxtKmRenta.Text);

                renta.CalcularTodo();
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
