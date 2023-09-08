
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
            this.mtxtKmRenta = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaReingreso = new System.Windows.Forms.Label();
            this.lblKmdespues = new System.Windows.Forms.Label();
            this.dtpFechaReingreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.epDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlReingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReingreso
            // 
            this.pnlReingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlReingreso.AutoSize = true;
            this.pnlReingreso.Controls.Add(this.mtxtKmRenta);
            this.pnlReingreso.Controls.Add(this.lblFechaReingreso);
            this.pnlReingreso.Controls.Add(this.lblKmdespues);
            this.pnlReingreso.Controls.Add(this.dtpFechaReingreso);
            this.pnlReingreso.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReingreso.Location = new System.Drawing.Point(8, 8);
            this.pnlReingreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlReingreso.Name = "pnlReingreso";
            this.pnlReingreso.Size = new System.Drawing.Size(481, 113);
            this.pnlReingreso.TabIndex = 2;
            // 
            // mtxtKmRenta
            // 
            this.mtxtKmRenta.Location = new System.Drawing.Point(234, 71);
            this.mtxtKmRenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtKmRenta.Mask = "0999999";
            this.mtxtKmRenta.Name = "mtxtKmRenta";
            this.mtxtKmRenta.Size = new System.Drawing.Size(73, 27);
            this.mtxtKmRenta.TabIndex = 15;
            // 
            // lblFechaReingreso
            // 
            this.lblFechaReingreso.AutoSize = true;
            this.lblFechaReingreso.Location = new System.Drawing.Point(17, 31);
            this.lblFechaReingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaReingreso.Name = "lblFechaReingreso";
            this.lblFechaReingreso.Size = new System.Drawing.Size(119, 19);
            this.lblFechaReingreso.TabIndex = 12;
            this.lblFechaReingreso.Text = "Fecha Reingreso:";
            // 
            // lblKmdespues
            // 
            this.lblKmdespues.AutoSize = true;
            this.lblKmdespues.Location = new System.Drawing.Point(17, 71);
            this.lblKmdespues.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKmdespues.Name = "lblKmdespues";
            this.lblKmdespues.Size = new System.Drawing.Size(213, 19);
            this.lblKmdespues.TabIndex = 14;
            this.lblKmdespues.Text = "Kilometraje después de rentar:";
            // 
            // dtpFechaReingreso
            // 
            this.dtpFechaReingreso.Location = new System.Drawing.Point(161, 25);
            this.dtpFechaReingreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaReingreso.Name = "dtpFechaReingreso";
            this.dtpFechaReingreso.Size = new System.Drawing.Size(274, 27);
            this.dtpFechaReingreso.TabIndex = 13;
            this.dtpFechaReingreso.Value = new System.DateTime(2023, 9, 8, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(135, 146);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(242, 146);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // epDatos
            // 
            this.epDatos.ContainerControl = this;
            // 
            // ReingresoRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(500, 196);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlReingreso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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