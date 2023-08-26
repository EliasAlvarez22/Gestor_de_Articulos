namespace Gestor_de_ventas
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnEditarArticulo = new System.Windows.Forms.Button();
            this.BtnEliminarCategoria = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategorias
            // 
            this.DgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DgvCategorias.Location = new System.Drawing.Point(33, 139);
            this.DgvCategorias.MultiSelect = false;
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.ReadOnly = true;
            this.DgvCategorias.RowHeadersWidth = 51;
            this.DgvCategorias.RowTemplate.Height = 24;
            this.DgvCategorias.Size = new System.Drawing.Size(741, 243);
            this.DgvCategorias.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 46);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lista de categorías";
            // 
            // BtnEditarArticulo
            // 
            this.BtnEditarArticulo.AutoSize = true;
            this.BtnEditarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEditarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarArticulo.Image")));
            this.BtnEditarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditarArticulo.Location = new System.Drawing.Point(33, 418);
            this.BtnEditarArticulo.Name = "BtnEditarArticulo";
            this.BtnEditarArticulo.Size = new System.Drawing.Size(158, 38);
            this.BtnEditarArticulo.TabIndex = 5;
            this.BtnEditarArticulo.Text = "Agregar categoría";
            this.BtnEditarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditarArticulo.UseVisualStyleBackColor = true;
            this.BtnEditarArticulo.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // BtnEliminarCategoria
            // 
            this.BtnEliminarCategoria.AutoSize = true;
            this.BtnEliminarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCategoria.Image")));
            this.BtnEliminarCategoria.Location = new System.Drawing.Point(229, 418);
            this.BtnEliminarCategoria.Name = "BtnEliminarCategoria";
            this.BtnEliminarCategoria.Size = new System.Drawing.Size(157, 38);
            this.BtnEliminarCategoria.TabIndex = 6;
            this.BtnEliminarCategoria.Text = "Eliminar categoría";
            this.BtnEliminarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.AutoSize = true;
            this.BtnRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefrescar.Image")));
            this.BtnRefrescar.Location = new System.Drawing.Point(526, 430);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(108, 38);
            this.BtnRefrescar.TabIndex = 7;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 616);
            this.Controls.Add(this.BtnRefrescar);
            this.Controls.Add(this.BtnEliminarCategoria);
            this.Controls.Add(this.BtnEditarArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.DgvCategorias);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategorias";
            this.Text = "Lista de Categorías";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnEditarArticulo;
        private System.Windows.Forms.Button BtnEliminarCategoria;
        private System.Windows.Forms.Button BtnRefrescar;
    }
}