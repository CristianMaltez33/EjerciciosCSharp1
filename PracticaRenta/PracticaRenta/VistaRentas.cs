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
        protected static List<object> Rentas = new List<object>();

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
            //this.dtgvRentas.ColumnCount = 8;

            //var nombresColumnas = new List<string>
            //{
            //"Nombre conductor",
            //"Licencia",
            //"N. Telefono",
            //"Placas",
            //"Fecha renta",
            //"Fecha devolución",
            //"Km recorridos",
            //"Total renta"
            //};

            //for (int i = 0; i < nombresColumnas.Count; i++)
            //{
            //    this.dtgvRentas.Columns[i].HeaderText = nombresColumnas[i];
            //}
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarRenta vistaInfo = new IngresarRenta();
            vistaInfo.ShowDialog();
            DialogResult res = vistaInfo.ShowDialog();
            dtgvRentas.DataSource = null; 
            dtgvRentas.DataSource = Rentas;
        }

        private void btnReingreso_Click(object sender, EventArgs e)
        {
            ReingresoRenta vistaInfo = new ReingresoRenta(1);
            DialogResult res = vistaInfo.ShowDialog();
        }
    }
}
