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
            this.CboCampo = new System.Windows.Forms.ComboBox();
            this.CboCriterio = new System.Windows.Forms.ComboBox();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
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
            this.DgvArticulos.Location = new System.Drawing.Point(2, 84);
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
            // 
            // BtnEditarArticulo
            // 
            this.BtnEditarArticulo.AutoSize = true;
            this.BtnEditarArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEditarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarArticulo.Image")));
            this.BtnEditarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditarArticulo.Location = new System.Drawing.Point(72, 420);
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
            this.BtnRefrescar.Location = new System.Drawing.Point(1182, 420);
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
            this.BtnEliminarArticulo.Location = new System.Drawing.Point(243, 420);
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
            this.BtnExportarPDF.Location = new System.Drawing.Point(967, 420);
            this.BtnExportarPDF.Name = "BtnExportarPDF";
            this.BtnExportarPDF.Size = new System.Drawing.Size(129, 38);
            this.BtnExportarPDF.TabIndex = 2;
            this.BtnExportarPDF.Text = "Exportar PDF";
            this.BtnExportarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportarPDF.UseVisualStyleBackColor = true;
            this.BtnExportarPDF.Click += new System.EventHandler(this.BtnExportarPDF_Click);
            // 
            // CboCampo
            // 
            this.CboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCampo.FormattingEnabled = true;
            this.CboCampo.Location = new System.Drawing.Point(146, 541);
            this.CboCampo.Name = "CboCampo";
            this.CboCampo.Size = new System.Drawing.Size(121, 24);
            this.CboCampo.TabIndex = 4;
            this.CboCampo.SelectedIndexChanged += new System.EventHandler(this.CboCampo_SelectedIndexChanged);
            // 
            // CboCriterio
            // 
            this.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCriterio.FormattingEnabled = true;
            this.CboCriterio.Location = new System.Drawing.Point(381, 541);
            this.CboCriterio.Name = "CboCriterio";
            this.CboCriterio.Size = new System.Drawing.Size(121, 24);
            this.CboCriterio.TabIndex = 5;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(613, 543);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(116, 22);
            this.TxtFiltro.TabIndex = 6;
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Location = new System.Drawing.Point(69, 549);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(51, 16);
            this.LblCampo.TabIndex = 7;
            this.LblCampo.Text = "Campo";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Location = new System.Drawing.Point(307, 549);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(49, 16);
            this.LblCriterio.TabIndex = 8;
            this.LblCriterio.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filtro";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(779, 533);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(129, 38);
            this.BtnFiltrar.TabIndex = 10;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 620);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.CboCriterio);
            this.Controls.Add(this.CboCampo);
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
        private System.Windows.Forms.ComboBox CboCampo;
        private System.Windows.Forms.ComboBox CboCriterio;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}