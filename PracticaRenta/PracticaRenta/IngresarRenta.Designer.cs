
namespace PracticaRenta
{
    partial class IngresarRenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlIngreso = new System.Windows.Forms.Panel();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(71, 537);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 30);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(473, 537);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlIngreso
            // 
            this.pnlIngreso.AutoSize = true;
            this.pnlIngreso.Controls.Add(this.txtKmInicial);
            this.pnlIngreso.Controls.Add(this.lblKmInicial);
            this.pnlIngreso.Controls.Add(this.dateTimePicker1);
            this.pnlIngreso.Controls.Add(this.lblFechaRenta);
            this.pnlIngreso.Controls.Add(this.textBox1);
            this.pnlIngreso.Controls.Add(this.label2);
            this.pnlIngreso.Controls.Add(this.txtPlaca);
            this.pnlIngreso.Controls.Add(this.lblPlaca);
            this.pnlIngreso.Controls.Add(this.txtLicencia);
            this.pnlIngreso.Controls.Add(this.lblLicencia);
            this.pnlIngreso.Controls.Add(this.txtNombre);
            this.pnlIngreso.Controls.Add(this.label1);
            this.pnlIngreso.Location = new System.Drawing.Point(25, 12);
            this.pnlIngreso.Name = "pnlIngreso";
            this.pnlIngreso.Size = new System.Drawing.Size(596, 354);
            this.pnlIngreso.TabIndex = 0;
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.Location = new System.Drawing.Point(269, 293);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(250, 26);
            this.txtKmInicial.TabIndex = 11;
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.Location = new System.Drawing.Point(18, 293);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(203, 20);
            this.lblKmInicial.TabIndex = 10;
            this.lblKmInicial.Text = "Kilometraje antes de rentar:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Location = new System.Drawing.Point(42, 230);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(106, 20);
            this.lblFechaRenta.TabIndex = 8;
            this.lblFechaRenta.Text = "Fecha Renta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de contacto:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(154, 167);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(375, 26);
            this.txtPlaca.TabIndex = 5;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(43, 170);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(154, 76);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(375, 26);
            this.txtLicencia.TabIndex = 3;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(43, 82);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(71, 20);
            this.lblLicencia.TabIndex = 2;
            this.lblLicencia.Text = "Licencia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(375, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // IngresarRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(649, 594);
            this.Controls.Add(this.pnlIngreso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "IngresarRenta";
            this.Text = "IngresarRenta";
            this.pnlIngreso.ResumeLayout(false);
            this.pnlIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlIngreso;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.Label lblKmInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaRenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}