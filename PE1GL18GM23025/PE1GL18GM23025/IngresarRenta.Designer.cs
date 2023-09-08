
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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlIngreso = new System.Windows.Forms.Panel();
            this.mtxtKmInicial = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtxtLicencia = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(258, 341);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(131, 341);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlIngreso
            // 
            this.pnlIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlIngreso.AutoSize = true;
            this.pnlIngreso.BackColor = System.Drawing.Color.Linen;
            this.pnlIngreso.Controls.Add(this.mtxtKmInicial);
            this.pnlIngreso.Controls.Add(this.mtxtTelefono);
            this.pnlIngreso.Controls.Add(this.mtxtLicencia);
            this.pnlIngreso.Controls.Add(this.mtxtPlaca);
            this.pnlIngreso.Controls.Add(this.dtpFechaInicio);
            this.pnlIngreso.Controls.Add(this.lblKmInicial);
            this.pnlIngreso.Controls.Add(this.lblFechaRenta);
            this.pnlIngreso.Controls.Add(this.label2);
            this.pnlIngreso.Controls.Add(this.lblPlaca);
            this.pnlIngreso.Controls.Add(this.lblLicencia);
            this.pnlIngreso.Controls.Add(this.txtNombre);
            this.pnlIngreso.Controls.Add(this.label1);
            this.pnlIngreso.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlIngreso.Location = new System.Drawing.Point(9, 9);
            this.pnlIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlIngreso.Name = "pnlIngreso";
            this.pnlIngreso.Size = new System.Drawing.Size(512, 310);
            this.pnlIngreso.TabIndex = 0;
            // 
            // mtxtKmInicial
            // 
            this.mtxtKmInicial.Location = new System.Drawing.Point(240, 247);
            this.mtxtKmInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtKmInicial.Mask = "0999999";
            this.mtxtKmInicial.Name = "mtxtKmInicial";
            this.mtxtKmInicial.Size = new System.Drawing.Size(69, 27);
            this.mtxtKmInicial.TabIndex = 15;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(206, 154);
            this.mtxtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtTelefono.Mask = "0000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(131, 27);
            this.mtxtTelefono.TabIndex = 14;
            // 
            // mtxtLicencia
            // 
            this.mtxtLicencia.Location = new System.Drawing.Point(206, 66);
            this.mtxtLicencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtLicencia.Mask = "0000-000000-000-0";
            this.mtxtLicencia.Name = "mtxtLicencia";
            this.mtxtLicencia.Size = new System.Drawing.Size(131, 27);
            this.mtxtLicencia.TabIndex = 13;
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.Location = new System.Drawing.Point(206, 110);
            this.mtxtPlaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtPlaca.Mask = "L90000-000";
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(131, 27);
            this.mtxtPlaca.TabIndex = 12;
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.Location = new System.Drawing.Point(28, 250);
            this.lblKmInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(195, 19);
            this.lblKmInicial.TabIndex = 10;
            this.lblKmInicial.Text = "Kilometraje antes de rentar:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(206, 203);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(270, 27);
            this.dtpFechaInicio.TabIndex = 9;
            this.dtpFechaInicio.Value = new System.DateTime(2023, 9, 8, 0, 0, 0, 0);
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Location = new System.Drawing.Point(29, 203);
            this.lblFechaRenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(93, 19);
            this.lblFechaRenta.TabIndex = 8;
            this.lblFechaRenta.Text = "Fecha Renta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de contacto:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(28, 110);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 19);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(29, 66);
            this.lblLicencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(66, 19);
            this.lblLicencia.TabIndex = 2;
            this.lblLicencia.Text = "Licencia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(206, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // epDatos
            // 
            this.epDatos.ContainerControl = this;
            // 
            // IngresarRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 401);
            this.Controls.Add(this.pnlIngreso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IngresarRenta";
            this.Text = "IngresarRenta";
            this.pnlIngreso.ResumeLayout(false);
            this.pnlIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlIngreso;
        private System.Windows.Forms.Label lblKmInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaRenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.MaskedTextBox mtxtLicencia;
        private System.Windows.Forms.MaskedTextBox mtxtPlaca;
        private System.Windows.Forms.ErrorProvider epDatos;
        private System.Windows.Forms.MaskedTextBox mtxtKmInicial;
    }
}