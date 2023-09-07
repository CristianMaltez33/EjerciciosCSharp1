
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
            this.pnlReingreso = new System.Windows.Forms.Panel();
            this.txtKmdespues = new System.Windows.Forms.TextBox();
            this.lblFechaReingreso = new System.Windows.Forms.Label();
            this.lblKmdespues = new System.Windows.Forms.Label();
            this.dtpFechaReingreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlReingreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReingreso
            // 
            this.pnlReingreso.AutoSize = true;
            this.pnlReingreso.Controls.Add(this.txtKmdespues);
            this.pnlReingreso.Controls.Add(this.lblFechaReingreso);
            this.pnlReingreso.Controls.Add(this.lblKmdespues);
            this.pnlReingreso.Controls.Add(this.dtpFechaReingreso);
            this.pnlReingreso.Location = new System.Drawing.Point(12, 12);
            this.pnlReingreso.Name = "pnlReingreso";
            this.pnlReingreso.Size = new System.Drawing.Size(563, 163);
            this.pnlReingreso.TabIndex = 2;
            this.pnlReingreso.Visible = false;
            // 
            // txtKmdespues
            // 
            this.txtKmdespues.Location = new System.Drawing.Point(250, 106);
            this.txtKmdespues.Name = "txtKmdespues";
            this.txtKmdespues.Size = new System.Drawing.Size(250, 26);
            this.txtKmdespues.TabIndex = 15;
            // 
            // lblFechaReingreso
            // 
            this.lblFechaReingreso.AutoSize = true;
            this.lblFechaReingreso.Location = new System.Drawing.Point(26, 47);
            this.lblFechaReingreso.Name = "lblFechaReingreso";
            this.lblFechaReingreso.Size = new System.Drawing.Size(135, 20);
            this.lblFechaReingreso.TabIndex = 12;
            this.lblFechaReingreso.Text = "Fecha Reingreso:";
            // 
            // lblKmdespues
            // 
            this.lblKmdespues.AutoSize = true;
            this.lblKmdespues.Location = new System.Drawing.Point(26, 109);
            this.lblKmdespues.Name = "lblKmdespues";
            this.lblKmdespues.Size = new System.Drawing.Size(203, 20);
            this.lblKmdespues.TabIndex = 14;
            this.lblKmdespues.Text = "Kilometraje antes de rentar:";
            // 
            // dtpFechaReingreso
            // 
            this.dtpFechaReingreso.Location = new System.Drawing.Point(186, 47);
            this.dtpFechaReingreso.Name = "dtpFechaReingreso";
            this.dtpFechaReingreso.Size = new System.Drawing.Size(348, 26);
            this.dtpFechaReingreso.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(414, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(105, 193);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ReingresoRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 245);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlReingreso);
            this.Name = "ReingresoRenta";
            this.Text = "ReingresoRenta";
            this.pnlReingreso.ResumeLayout(false);
            this.pnlReingreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReingreso;
        private System.Windows.Forms.TextBox txtKmdespues;
        private System.Windows.Forms.Label lblFechaReingreso;
        private System.Windows.Forms.Label lblKmdespues;
        private System.Windows.Forms.DateTimePicker dtpFechaReingreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}