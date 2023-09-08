
namespace PracticaRenta
{
    partial class ReingresoRenta
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
            this.pnlReingreso = new System.Windows.Forms.Panel();
            this.lblFechaReingreso = new System.Windows.Forms.Label();
            this.lblKmdespues = new System.Windows.Forms.Label();
            this.dtpFechaReingreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.epDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtKmRenta = new System.Windows.Forms.MaskedTextBox();
            this.pnlReingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReingreso
            // 
            this.pnlReingreso.AutoSize = true;
            this.pnlReingreso.Controls.Add(this.mtxtKmRenta);
            this.pnlReingreso.Controls.Add(this.lblFechaReingreso);
            this.pnlReingreso.Controls.Add(this.lblKmdespues);
            this.pnlReingreso.Controls.Add(this.dtpFechaReingreso);
            this.pnlReingreso.Location = new System.Drawing.Point(11, 10);
            this.pnlReingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReingreso.Name = "pnlReingreso";
            this.pnlReingreso.Size = new System.Drawing.Size(500, 130);
            this.pnlReingreso.TabIndex = 2;
            // 
            // lblFechaReingreso
            // 
            this.lblFechaReingreso.AutoSize = true;
            this.lblFechaReingreso.Location = new System.Drawing.Point(23, 38);
            this.lblFechaReingreso.Name = "lblFechaReingreso";
            this.lblFechaReingreso.Size = new System.Drawing.Size(120, 17);
            this.lblFechaReingreso.TabIndex = 12;
            this.lblFechaReingreso.Text = "Fecha Reingreso:";
            // 
            // lblKmdespues
            // 
            this.lblKmdespues.AutoSize = true;
            this.lblKmdespues.Location = new System.Drawing.Point(23, 87);
            this.lblKmdespues.Name = "lblKmdespues";
            this.lblKmdespues.Size = new System.Drawing.Size(202, 17);
            this.lblKmdespues.TabIndex = 14;
            this.lblKmdespues.Text = "Kilometraje después de rentar:";
            // 
            // dtpFechaReingreso
            // 
            this.dtpFechaReingreso.Location = new System.Drawing.Point(165, 38);
            this.dtpFechaReingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaReingreso.Name = "dtpFechaReingreso";
            this.dtpFechaReingreso.Size = new System.Drawing.Size(310, 22);
            this.dtpFechaReingreso.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(368, 154);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(93, 154);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 27);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // epDatos
            // 
            this.epDatos.ContainerControl = this;
            // 
            // mtxtKmRenta
            // 
            this.mtxtKmRenta.Location = new System.Drawing.Point(260, 87);
            this.mtxtKmRenta.Mask = "0999999";
            this.mtxtKmRenta.Name = "mtxtKmRenta";
            this.mtxtKmRenta.Size = new System.Drawing.Size(215, 22);
            this.mtxtKmRenta.TabIndex = 15;
            // 
            // ReingresoRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 196);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlReingreso);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReingresoRenta";
            this.Text = "ReingresoRenta";
            this.pnlReingreso.ResumeLayout(false);
            this.pnlReingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReingreso;
        private System.Windows.Forms.Label lblFechaReingreso;
        private System.Windows.Forms.Label lblKmdespues;
        private System.Windows.Forms.DateTimePicker dtpFechaReingreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider epDatos;
        private System.Windows.Forms.MaskedTextBox mtxtKmRenta;
    }
}