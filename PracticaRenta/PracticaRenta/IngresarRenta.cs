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
        public IngresarRenta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Renta renta = new Renta();

            if (mtxtLicencia.MaskFull || mtxtTelefono.MaskFull || mtxtPlaca.MaskFull || mtxtKmInicial.MaskFull || !String.IsNullOrEmpty(txtNombre.Text))
                epDatos.Clear();

            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                epDatos.SetError(txtNombre, "El nombre no puede estar vacio");
                return;
            }

            if (!mtxtLicencia.MaskFull)
            {
                epDatos.SetError(mtxtLicencia, "La licencia debe se ir en formato 0000-000000-000-0");
                return;
            }

            if (!mtxtTelefono.MaskFull)
            {
                epDatos.SetError(mtxtTelefono, "La licencia debe se ir en formato 0000-0000");
                return;
            }

            if (!mtxtPlaca.MaskFull)
            {
                epDatos.SetError(mtxtPlaca, "La licencia debe se ir en formato L0000-000");
                return;
            }

            if (String.IsNullOrEmpty(mtxtKmInicial.Text))
            {
                epDatos.SetError(mtxtKmInicial, "El kilimetraje inicial no puede ser nulo");
                return;
            }


            renta.Nombre = this.txtNombre.Text;
            renta.Licencia = this.mtxtLicencia.Text;
            renta.Telefono = this.mtxtTelefono.Text;
            renta.Placa = this.mtxtPlaca.Text;
            renta.FechaRenta = (this.dtpFechaInicio.Value).ToString("dd-MM-yyyy");
            renta.FechaDevolucion = " ";
            renta.kmAntesR = Convert.ToDouble(this.mtxtKmInicial.Text);
            renta.kmDespuesR = 0;
            renta.KmRecorridos = 0;
            renta.Total = "---";

            VistaRentas.AgregarRenta(renta);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
