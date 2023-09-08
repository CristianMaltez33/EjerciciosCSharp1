
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRentas
            // 
            this.dtgvRentas.AllowUserToAddRows = false;
            this.dtgvRentas.AllowUserToOrderColumns = true;
            this.dtgvRentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgvRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRentas.Location = new System.Drawing.Point(24, 172);
            this.dtgvRentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvRentas.Name = "dtgvRentas";
            this.dtgvRentas.ReadOnly = true;
            this.dtgvRentas.RowHeadersWidth = 62;
            this.dtgvRentas.RowTemplate.Height = 28;
            this.dtgvRentas.Size = new System.Drawing.Size(790, 336);
            this.dtgvRentas.TabIndex = 0;
            this.dtgvRentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRentas_CellClick);
            // 
            // lblIngresar
            // 
            this.lblIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(68, 124);
            this.lblIngresar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(112, 19);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingresar Renta: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(184, 119);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(160, 29);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Guardar Nueva Renta";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnReingreso
            // 
            this.btnReingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReingreso.AutoSize = true;
            this.btnReingreso.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReingreso.Enabled = false;
            this.btnReingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReingreso.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReingreso.Location = new System.Drawing.Point(625, 118);
            this.btnReingreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReingreso.Name = "btnReingreso";
            this.btnReingreso.Size = new System.Drawing.Size(145, 31);
            this.btnReingreso.TabIndex = 4;
            this.btnReingreso.Text = "Reingreso Vehiculo";
            this.btnReingreso.UseVisualStyleBackColor = false;
            this.btnReingreso.Click += new System.EventHandler(this.btnReingreso_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reingreso vehiculo: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(320, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 33);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "¡TU COCHE IDEAL!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Uighur", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(359, 72);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(135, 23);
            this.lblSubTitulo.TabIndex = 6;
            this.lblSubTitulo.Text = "RENTA DE VEHICULOS";
            this.lblSubTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VistaRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(835, 519);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnReingreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.dtgvRentas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaRentas";
            this.Text = "Tu Coche Ideal";
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
    }
}

