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
    public partial class IngresarRenta : Form
    {
        // VistaRentas vistaRentas = new VistaRentas();
        public IngresarRenta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            object renta = new { Nombre = "Ejemplo", Licencia = "L2009323", Telefono = "7780-8723", Placa = "P01", FechaRenta = "12/12/2023", KmAntesR = 500, FechaDespuesR = "13/12/2023", KmDespuesR = 500, KmRecorridos = 0, Total = "---"};

            // Agregar el objeto a la lista
            VistaRentas.AgregarRenta(renta);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
