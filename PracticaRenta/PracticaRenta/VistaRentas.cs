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
    public partial class VistaRentas : Form
    {
        private static List<object> Rentas = new List<object>();

        private List<string> nombresColumnas = new List<string>
        {
        "Nombre conductor",
        "Licencia",
        "N. Telefono",
        "Placas",
        "Fecha renta",
        "Fecha devolución",
        "Km recorridos",
        "Total renta"
        };

        private int index;

        public static void AgregarRenta(object objeto)
        {
            Rentas.Add(objeto);
        }

        public static List<object> ObtenerRenta()
        {
            return Rentas;
        }

        public VistaRentas()
        {
            InitializeComponent();
        }

        private void VistaRentas_Load(object sender, EventArgs e)
        {
            this.dtgvRentas.ColumnCount = 8;

            for (int i = 0; i < nombresColumnas.Count; i++)
            {
                this.dtgvRentas.Columns[i].HeaderText = nombresColumnas[i];
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarRenta vistaInfo = new IngresarRenta();
            DialogResult res = vistaInfo.ShowDialog();
            
            if(res == DialogResult.OK)
            {
                dtgvRentas.DataSource = null;
                dtgvRentas.DataSource = Rentas;

                for (int i = 0; i < nombresColumnas.Count; i++)
                {
                    this.dtgvRentas.Columns[i].HeaderText = nombresColumnas[i];
                }
            }
            
        }

        private void btnReingreso_Click(object sender, EventArgs e)
        {
            ReingresoRenta vistaInfo = new ReingresoRenta(this.index);
            DialogResult res = vistaInfo.ShowDialog();

            if (res == DialogResult.OK)
            {
                dtgvRentas.DataSource = null;
                dtgvRentas.DataSource = Rentas;

                for (int i = 0; i < nombresColumnas.Count; i++)
                {
                    this.dtgvRentas.Columns[i].HeaderText = nombresColumnas[i];
                }
            }
        }

        private void dtgvRentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.index = e.RowIndex;

            if (index >= 0)
                btnReingreso.Enabled = true;
            else
                btnReingreso.Enabled = false;

        }
    }

    class Renta {
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public string Telefono { get; set; }
        public string Placa { get; set; }
        public string FechaRenta { get; set; }
        public string FechaDevolucion { get; set; }
        public double KmRecorridos { get; set; }
        public string Total { get; set; }

        private double _kmAntesR = 0;
        private double _kmDespuesR = 0;

        public double kmAntesR {
            set { this._kmAntesR = value; }
        }

        public double kmDespuesR
        {
            set { this._kmDespuesR = value; }
        }

        public void CalcularTodo()
        {
            double totalKm = this._kmDespuesR - this._kmAntesR;

            if (totalKm > 500)
                this.Total = ((500 * 0.67) + ((totalKm - 500) * 0.89)).ToString("F2");
            else
                this.Total = ( totalKm * 0.67 ).ToString("F2");

            this.KmRecorridos = this._kmDespuesR - this._kmAntesR;
        }

    }
}
