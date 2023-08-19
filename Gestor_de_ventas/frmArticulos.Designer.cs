namespace Gestor_de_ventas
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnEditarArticulo = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.BtnEliminarArticulo = new System.Windows.Forms.Button();
            this.BtnExportarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToResizeRows = false;
            this.DgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DgvArticulos.Location = new System.Drawing.Point(2, 171);
            this.DgvArticulos.MultiSelect = false;
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowHeadersWidth = 51;
            this.DgvArticulos.RowTemplate.Height = 40;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(1380, 315);
            this.DgvArticulos.TabIndex = 1;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 46);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de artículos";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // BtnEditarArticulo
            // 
            this.BtnEditarArticulo.AutoSize = true;
            this.BtnEditarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEditarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarArticulo.Image")));
            this.BtnEditarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditarArticulo.Location = new System.Drawing.Point(66, 518);
            this.BtnEditarArticulo.Name = "BtnEditarArticulo";
            this.BtnEditarArticulo.Size = new System.Drawing.Size(130, 38);
            this.BtnEditarArticulo.TabIndex = 0;
            this.BtnEditarArticulo.Text = "Editar artículo";
            this.BtnEditarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditarArticulo.UseVisualStyleBackColor = true;
            this.BtnEditarArticulo.Click += new System.EventHandler(this.BtnEditarArticulo_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.AutoSize = true;
            this.BtnRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefrescar.Image")));
            this.BtnRefrescar.Location = new System.Drawing.Point(1176, 518);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(108, 38);
            this.BtnRefrescar.TabIndex = 3;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnEliminarArticulo
            // 
            this.BtnEliminarArticulo.AutoSize = true;
            this.BtnEliminarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarArticulo.Image")));
            this.BtnEliminarArticulo.Location = new System.Drawing.Point(237, 518);
            this.BtnEliminarArticulo.Name = "BtnEliminarArticulo";
            this.BtnEliminarArticulo.Size = new System.Drawing.Size(143, 38);
            this.BtnEliminarArticulo.TabIndex = 1;
            this.BtnEliminarArticulo.Text = "Eliminar artículo";
            this.BtnEliminarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarArticulo.UseVisualStyleBackColor = true;
            this.BtnEliminarArticulo.Click += new System.EventHandler(this.BtnEliminarArticulo_Click);
            // 
            // BtnExportarPDF
            // 
            this.BtnExportarPDF.AutoSize = true;
            this.BtnExportarPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExportarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportarPDF.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportarPDF.Image")));
            this.BtnExportarPDF.Location = new System.Drawing.Point(961, 518);
            this.BtnExportarPDF.Name = "BtnExportarPDF";
            this.BtnExportarPDF.Size = new System.Drawing.Size(129, 38);
            this.BtnExportarPDF.TabIndex = 2;
            this.BtnExportarPDF.Text = "Exportar PDF";
            this.BtnExportarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportarPDF.UseVisualStyleBackColor = true;
            this.BtnExportarPDF.Click += new System.EventHandler(this.BtnExportarPDF_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 620);
            this.Controls.Add(this.BtnExportarPDF);
            this.Controls.Add(this.BtnEliminarArticulo);
            this.Controls.Add(this.BtnRefrescar);
            this.Controls.Add(this.BtnEditarArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.DgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticulos";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnEditarArticulo;
        private System.Windows.Forms.Button BtnRefrescar;
        private System.Windows.Forms.Button BtnEliminarArticulo;
        private System.Windows.Forms.Button BtnExportarPDF;
    }
}