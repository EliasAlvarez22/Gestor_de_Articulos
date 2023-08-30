namespace Gestor_de_ventas.views_Marcas
{
    partial class FrmAltaMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaMarca));
            this.lblValidacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.lblMarcasUsadas = new System.Windows.Forms.Label();
            this.lblContarMarcas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValidacion
            // 
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblValidacion.Location = new System.Drawing.Point(216, 334);
            this.lblValidacion.Name = "lblValidacion";
            this.lblValidacion.Size = new System.Drawing.Size(0, 25);
            this.lblValidacion.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(50, 221);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(221, 221);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(152, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(246, 359);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 58);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Location = new System.Drawing.Point(21, 49);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(267, 46);
            this.LblTitulo.TabIndex = 14;
            this.LblTitulo.Text = "Nueva Marca";
            // 
            // lblMarcasUsadas
            // 
            this.lblMarcasUsadas.AutoSize = true;
            this.lblMarcasUsadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcasUsadas.ForeColor = System.Drawing.Color.White;
            this.lblMarcasUsadas.Location = new System.Drawing.Point(50, 146);
            this.lblMarcasUsadas.Name = "lblMarcasUsadas";
            this.lblMarcasUsadas.Size = new System.Drawing.Size(290, 25);
            this.lblMarcasUsadas.TabIndex = 19;
            this.lblMarcasUsadas.Text = "Marca usada en             articulos";
            // 
            // lblContarMarcas
            // 
            this.lblContarMarcas.AutoSize = true;
            this.lblContarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContarMarcas.ForeColor = System.Drawing.Color.White;
            this.lblContarMarcas.Location = new System.Drawing.Point(228, 146);
            this.lblContarMarcas.Name = "lblContarMarcas";
            this.lblContarMarcas.Size = new System.Drawing.Size(0, 25);
            this.lblContarMarcas.TabIndex = 20;
            // 
            // FrmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(677, 479);
            this.Controls.Add(this.lblContarMarcas);
            this.Controls.Add(this.lblMarcasUsadas);
            this.Controls.Add(this.lblValidacion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marca";
            this.Load += new System.EventHandler(this.FrmAltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label lblMarcasUsadas;
        private System.Windows.Forms.Label lblContarMarcas;
    }
}