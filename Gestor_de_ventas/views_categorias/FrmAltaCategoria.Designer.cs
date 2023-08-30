namespace Gestor_de_ventas
{
    partial class FrmAltaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCategoria));
            this.LblTituloCategoria = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValidacion = new System.Windows.Forms.Label();
            this.lblContarCategorias = new System.Windows.Forms.Label();
            this.lblCategoriasUsadas = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTituloCategoria
            // 
            this.LblTituloCategoria.AutoSize = true;
            this.LblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCategoria.ForeColor = System.Drawing.Color.Transparent;
            this.LblTituloCategoria.Location = new System.Drawing.Point(12, 50);
            this.LblTituloCategoria.Name = "LblTituloCategoria";
            this.LblTituloCategoria.Size = new System.Drawing.Size(325, 46);
            this.LblTituloCategoria.TabIndex = 5;
            this.LblTituloCategoria.Text = "Nueva categoría";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(206, 369);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(152, 58);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(206, 238);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(152, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblValidacion
            // 
            this.lblValidacion.AutoSize = true;
            this.lblValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacion.ForeColor = System.Drawing.Color.Red;
            this.lblValidacion.Location = new System.Drawing.Point(214, 341);
            this.lblValidacion.Name = "lblValidacion";
            this.lblValidacion.Size = new System.Drawing.Size(0, 25);
            this.lblValidacion.TabIndex = 13;
            // 
            // lblContarCategorias
            // 
            this.lblContarCategorias.AutoSize = true;
            this.lblContarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContarCategorias.ForeColor = System.Drawing.Color.White;
            this.lblContarCategorias.Location = new System.Drawing.Point(253, 149);
            this.lblContarCategorias.Name = "lblContarCategorias";
            this.lblContarCategorias.Size = new System.Drawing.Size(0, 25);
            this.lblContarCategorias.TabIndex = 25;
            // 
            // lblCategoriasUsadas
            // 
            this.lblCategoriasUsadas.AutoSize = true;
            this.lblCategoriasUsadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriasUsadas.ForeColor = System.Drawing.Color.White;
            this.lblCategoriasUsadas.Location = new System.Drawing.Point(47, 149);
            this.lblCategoriasUsadas.Name = "lblCategoriasUsadas";
            this.lblCategoriasUsadas.Size = new System.Drawing.Size(320, 25);
            this.lblCategoriasUsadas.TabIndex = 24;
            this.lblCategoriasUsadas.Text = "Categoría usada en             articulos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(50, 235);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción";
            // 
            // FrmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(677, 479);
            this.Controls.Add(this.lblContarCategorias);
            this.Controls.Add(this.lblCategoriasUsadas);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblValidacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblTituloCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 526);
            this.MinimumSize = new System.Drawing.Size(695, 526);
            this.Name = "FrmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoría";
            this.Load += new System.EventHandler(this.FrmAltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloCategoria;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Label lblContarCategorias;
        private System.Windows.Forms.Label lblCategoriasUsadas;
        private System.Windows.Forms.Label lblDescripcion;
    }
}