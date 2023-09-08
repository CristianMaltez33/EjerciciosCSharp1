
namespace PracticaRenta
{
    partial class VistaRentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvRentas = new System.Windows.Forms.DataGridView();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnReingreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRentas
            // 
            this.dtgvRentas.AllowUserToAddRows = false;
            this.dtgvRentas.AllowUserToOrderColumns = true;
            this.dtgvRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRentas.Location = new System.Drawing.Point(3, 79);
            this.dtgvRentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvRentas.Name = "dtgvRentas";
            this.dtgvRentas.ReadOnly = true;
            this.dtgvRentas.RowHeadersWidth = 62;
            this.dtgvRentas.RowTemplate.Height = 28;
            this.dtgvRentas.Size = new System.Drawing.Size(1154, 413);
            this.dtgvRentas.TabIndex = 0;
            this.dtgvRentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRentas_CellClick);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(140, 36);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(110, 17);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingresar Renta: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.Location = new System.Drawing.Point(277, 31);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(177, 27);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Guardar Nueva Renta";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnReingreso
            // 
            this.btnReingreso.AutoSize = true;
            this.btnReingreso.Enabled = false;
            this.btnReingreso.Location = new System.Drawing.Point(834, 31);
            this.btnReingreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReingreso.Name = "btnReingreso";
            this.btnReingreso.Size = new System.Drawing.Size(177, 27);
            this.btnReingreso.TabIndex = 4;
            this.btnReingreso.Text = "Reingreso Vehiculo";
            this.btnReingreso.UseVisualStyleBackColor = true;
            this.btnReingreso.Click += new System.EventHandler(this.btnReingreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reingreso vehiculo: ";
            // 
            // VistaRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 540);
            this.Controls.Add(this.btnReingreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.dtgvRentas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VistaRentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VistaRentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRentas;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnReingreso;
        private System.Windows.Forms.Label label1;
    }
}

