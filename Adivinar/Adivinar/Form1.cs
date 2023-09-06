using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinar
{
    public partial class Form1 : Form
    {
        private Color defaulColor = Color.Red;

        private int clicks = 0;

        private Image[] listaImagenes = new Image[]{
        Image.FromFile("Imagenes/zorro.jpg"),
        Image.FromFile("Imagenes/dinosaurio.jpg"),
        Image.FromFile("Imagenes/gato.jpg"),
        Image.FromFile("Imagenes/unicornio.jpg"),
        // Agrega más imágenes según tus necesidades
        };

        private Dictionary<int, bool> Calculados = new Dictionary<int, bool>();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                    // ((PictureBox)c).Visible = true;
                ((PictureBox)c).BackColor = Color.Red;
                ((PictureBox)c).SizeMode = PictureBoxSizeMode.StretchImage;

                PictureBox pictureBox = (PictureBox)c;

                // Asigna el manejador de eventos MouseEnter
                pictureBox.MouseEnter += new EventHandler(pcb_MouseEnter);

                // Asigna el manejador de eventos MouseLeave
                pictureBox.MouseLeave += new EventHandler(pcb_MouseLeave);

                pictureBox.MouseClick += new MouseEventHandler(pcb_Click);
            }

        }

        private void pcb_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Orange;
        }

        private void pcb_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = this.defaulColor;

        }

        private void pcb_Click(object sender, MouseEventArgs e)
        {
            Image imagen = Image.FromFile("Imagenes/zorro.jpg");

            Image imagen2 = Image.FromFile("Imagenes/zorro.jpg");

            ((PictureBox)sender).Image = imagen;

        }


    }
}
