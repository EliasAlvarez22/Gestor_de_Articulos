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
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnEditarArticulo = new System.Windows.Forms.Button();
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
            this.DgvArticulos.Location = new System.Drawing.Point(2, 90);
            this.DgvArticulos.MultiSelect = false;
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowHeadersWidth = 51;
            this.DgvArticulos.RowTemplate.Height = 40;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(1255, 241);
            this.DgvArticulos.TabIndex = 1;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(12, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 46);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de articulos";
            // 
            // BtnEditarArticulo
            // 
            this.BtnEditarArticulo.Location = new System.Drawing.Point(59, 389);
            this.BtnEditarArticulo.Name = "BtnEditarArticulo";
            this.BtnEditarArticulo.Size = new System.Drawing.Size(111, 52);
            this.BtnEditarArticulo.TabIndex = 3;
            this.BtnEditarArticulo.Text = "Editar artículo";
            this.BtnEditarArticulo.UseVisualStyleBackColor = true;
            this.BtnEditarArticulo.Click += new System.EventHandler(this.BtnEditarArticulo_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 620);
            this.Controls.Add(this.BtnEditarArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.DgvArticulos);
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnEditarArticulo;
    }
}