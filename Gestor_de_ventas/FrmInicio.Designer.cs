namespace Gestor_de_ventas
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pbxInicio = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.LblContadorArticulos = new System.Windows.Forms.Label();
            this.LblTotalMarcas = new System.Windows.Forms.Label();
            this.LblContadorMarcas = new System.Windows.Forms.Label();
            this.btnActualizarTotales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxInicio
            // 
            this.pbxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbxInicio.Image")));
            this.pbxInicio.InitialImage = null;
            this.pbxInicio.Location = new System.Drawing.Point(377, 91);
            this.pbxInicio.Name = "pbxInicio";
            this.pbxInicio.Size = new System.Drawing.Size(718, 481);
            this.pbxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInicio.TabIndex = 5;
            this.pbxInicio.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(549, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 46);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Gestor de Artículos";
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalArticulos.Location = new System.Drawing.Point(25, 119);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(163, 25);
            this.LblTotalArticulos.TabIndex = 7;
            this.LblTotalArticulos.Text = "Total de Artículos";
            // 
            // LblContadorArticulos
            // 
            this.LblContadorArticulos.AutoSize = true;
            this.LblContadorArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContadorArticulos.Location = new System.Drawing.Point(320, 119);
            this.LblContadorArticulos.Name = "LblContadorArticulos";
            this.LblContadorArticulos.Size = new System.Drawing.Size(0, 25);
            this.LblContadorArticulos.TabIndex = 8;
            // 
            // LblTotalMarcas
            // 
            this.LblTotalMarcas.AutoSize = true;
            this.LblTotalMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalMarcas.Location = new System.Drawing.Point(25, 186);
            this.LblTotalMarcas.Name = "LblTotalMarcas";
            this.LblTotalMarcas.Size = new System.Drawing.Size(153, 25);
            this.LblTotalMarcas.TabIndex = 9;
            this.LblTotalMarcas.Text = "Total de Marcas";
            // 
            // LblContadorMarcas
            // 
            this.LblContadorMarcas.AutoSize = true;
            this.LblContadorMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContadorMarcas.Location = new System.Drawing.Point(320, 186);
            this.LblContadorMarcas.Name = "LblContadorMarcas";
            this.LblContadorMarcas.Size = new System.Drawing.Size(0, 25);
            this.LblContadorMarcas.TabIndex = 10;
            // 
            // btnActualizarTotales
            // 
            this.btnActualizarTotales.BackColor = System.Drawing.Color.White;
            this.btnActualizarTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTotales.Location = new System.Drawing.Point(25, 51);
            this.btnActualizarTotales.Name = "btnActualizarTotales";
            this.btnActualizarTotales.Size = new System.Drawing.Size(246, 43);
            this.btnActualizarTotales.TabIndex = 11;
            this.btnActualizarTotales.Text = "Actualizar totales";
            this.btnActualizarTotales.UseVisualStyleBackColor = false;
            this.btnActualizarTotales.Click += new System.EventHandler(this.btnActualizarTotales_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1243, 733);
            this.Controls.Add(this.btnActualizarTotales);
            this.Controls.Add(this.LblContadorMarcas);
            this.Controls.Add(this.LblTotalMarcas);
            this.Controls.Add(this.LblContadorArticulos);
            this.Controls.Add(this.LblTotalArticulos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbxInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxInicio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.Label LblContadorArticulos;
        private System.Windows.Forms.Label LblTotalMarcas;
        private System.Windows.Forms.Label LblContadorMarcas;
        private System.Windows.Forms.Button btnActualizarTotales;
    }
}