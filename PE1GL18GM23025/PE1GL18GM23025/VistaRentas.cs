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

    //ENUNCIADO:Un encargado de alquiler de vehículos, requiere llevar el control de la renta de los mismos. Para ello
    // cada vez que renta un auto, toma el nombre del conductor, su licencia y un número de teléfono.De
    //auto toma el número de kilometraje inicial y la fecha en la cual lo renta, al regresar el automóvil,
   //tomando nuevamente la fecha de ingreso y el kilometraje final, Si los kilómetros recorridos son más de
   // 500, los primeros se cobran a 0.67 cts cada kilómetro, pero los siguientes restantes se cobran a 0.89 ctvs
   // Diseñe una solución que le permita recolectar la información necesaria y luego imprimir el desglose del
   // pago por el alquiler del auto.


    // DATOS ESTUDIANTE
    // GIRON MARTINEZ, KARLA GISSELL
    // GM23025   GL18
    // Ing. Bladimir Diaz



   // viata principal donde se mostraran todas las rentas hechas 
    public partial class VistaRentas : Form
    {
        private static List<object> Rentas = new List<object>();

        // creo una lista que se mostrara en el DataGriewView
        private List<string> nombresColumnas = new List<string>
        {
        "Nombre conductor",
        "Licencia",
        "N. Telefono",
        "Placas",
        "Fecha renta",
        "Fecha devolución",
        "Kms iniciales",
        "Kms finales",
        "Kms recorridos",
        "Total renta"
        };

        // sirve  para ingresar el registro que se quiere editar
        private int index;


        //Obteniendo acceso a los datos  de las rentas de otra venta
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

        

        // evento click del boton ingresar
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


        //evento click del boton reingreso
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


        // evento cellclick del dtgRentas
        private void dtgvRentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.index = e.RowIndex;

            if (index >= 0)
                btnReingreso.Enabled = true;
            else
                btnReingreso.Enabled = false;

        }
    }

    // clase renta
    class Renta {

        // declaracion de variables 
        string nombre;
        string licencia;
        string telefono;
        string placa;
        string fechaRenta;
        string fechaDevolucion;
        double _kmAntesR = 0;
        double _kmDespuesR = 0;
        double kmRecorridos;
        string total;

        // get y set para cada variable
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Licencia
        {
            set { licencia = value; }
            get { return licencia; }
        }
        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public string Placa
        {
            set { placa = value; }
            get { return placa; }
        }
        public string FechaRenta
        {
            set { fechaRenta = value; }
            get { return fechaRenta; }
        }
        public string FechaDevolucion
        {
            set { fechaDevolucion = value; }
            get { return fechaDevolucion; }
        }

        //set para guardar los km iniciales 
        public double kmAntesR {
            set { _kmAntesR = value; }
            get { return _kmAntesR; }
        }

        //set para guardar km despues
        public double kmDespuesR
        {
            set { _kmDespuesR = value; }
            get { return _kmDespuesR; }
        }

        public double KmRecorridos
        {
            set { kmRecorridos = value; }
            get { return kmRecorridos; }
        }
        public string Total
        {
            set { total = value; }
            get { return total; }
        }

        // metodo CalcularTodo que realiza el calculo matematico para saber cual es el total.
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
