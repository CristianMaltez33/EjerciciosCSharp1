using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class ejercicio1 : Form
    {
        private int dotCounted = 0;

        private int lessSign = 0;
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ingresados = txtNumeros.Text;
            int pos = (ingresados.Length);
            // MessageBox.Show(ingresados);

            bool numeroASCII = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool puntoASCII = e.KeyChar == '.';
            bool menosASCII = e.KeyChar == '-';

            if (!(numeroASCII || puntoASCII || menosASCII || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten valores numéricos o de punto flotante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;

                txtNumeros.SelectionStart = pos;

                return;
            }

            if(e.KeyChar == (char)Keys.Back && String.IsNullOrEmpty(txtNumeros.Text)){

                e.Handled = true;
                return;
            }

            if (e.KeyChar == 8 && pos >= 0)
            {
                if (ingresados[pos - 1] == '-')
                    this.lessSign--;

                if (ingresados[pos - 1] == '.')
                    this.dotCounted--;
            }

            if (menosASCII && pos != 0)
            {
                MessageBox.Show("El signo de - solo puede ir al inicio de los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // ManejoErrores(pos, ingresados);

                e.Handled = true;

                txtNumeros.SelectionStart = pos + 1;

                return;
            }

            if (puntoASCII)
                this.dotCounted++;

            if (menosASCII)
                this.lessSign++;

            //if (this.dotCounted == 1 && pos == 0 && puntoASCII)
            //{
            //    txtNumeros.Text = " ";
            //    txtNumeros.Text = "0.";
            //}
                

            bool verifyDot = this.dotCounted > 1;
            bool verifyLessSign = this.lessSign > 1;

            if (verifyDot || verifyLessSign)
            {
                string errorUser = verifyDot ? "." : "-";
                MessageBox.Show($"Solo se permite un {errorUser} para los valores con punto flotante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // ManejoErrores(pos, ingresados);

                if (verifyDot)
                    this.dotCounted--;

                if (verifyLessSign)
                    this.lessSign--;

                e.Handled = true;
                return;
            }
                    txtNumeros.SelectionStart = pos + 1;
        }


        private void txtNumeros_KeyUp(object sender, KeyEventArgs e)
        {

            string ingresados = txtNumeros.Text;
            int pos = (ingresados.Length - 1);
            bool puntoASCII = e.KeyValue == 190;

            //if (!(numeroASCII || puntoASCII || backSpaceASCII || menosASCII || e.KeyValue == 13))
            //{
            //    MessageBox.Show("solo se permite valores números o de punto flotante", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    e.Handled = true;

            //    txtNumeros.SelectionStart = pos;

            //    return;
            //}

            //if(menosASCII && pos != 0)
            //{
            //    MessageBox.Show("El signo de - solo puede ir al inicio de los datos ingresados", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    ManejoErrores(pos, ingresados);

            //    e.Handled = true;

            //    txtNumeros.SelectionStart = pos;

            //    return;
            //}


            //if (puntoASCII)
            //    this.dotCounted++;

            //if (menosASCII)
            //    this.lessSign++;

            if (this.dotCounted == 1 && pos == 0 && puntoASCII)
            {
                txtNumeros.Text = "0.";
                txtNumeros.SelectionStart = 2;
            }

            //verifyDot = this.dotCounted > 1;

            //verifyLessSign = this.lessSign > 1;

            //if ( verifyDot || verifyLessSign )
            //{

            //    errorUser = verifyDot ? "." : "-";

            //    MessageBox.Show("solo se permite un "+ errorUser +"para los valores con punto flotante", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    ManejoErrores(pos, ingresados);

            //    if (verifyDot)
            //        this.dotCounted--;

            //    if (verifyLessSign)
            //        this.lessSign--;

            //    e.Handled = true;



            //    return;
            //}

        }

        private void txtNumeros_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void ManejoErrores(int pos, string ingresados)
        {
            if( pos >= 0 )
            ingresados = ingresados.Remove(pos, 1).Insert(pos, "");

            txtNumeros.Text = ingresados;
        }
    }
}
