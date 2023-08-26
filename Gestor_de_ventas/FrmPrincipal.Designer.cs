namespace Gestor_de_ventas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnArticulos = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.BtnAgregarArticulo = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.TcoMenu = new System.Windows.Forms.TabControl();
            this.PanelMenu.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticulos.BackColor = System.Drawing.Color.White;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulos.Image")));
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(26, 121);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(220, 80);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "   Ver artículos";
            this.btnArticulos.UseCompatibleTextRendering = true;
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoSize = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelMenu.Controls.Add(this.BtnInicio);
            this.PanelMenu.Controls.Add(this.BtnMarcas);
            this.PanelMenu.Controls.Add(this.BtnCategorias);
            this.PanelMenu.Controls.Add(this.BtnAgregarArticulo);
            this.PanelMenu.Controls.Add(this.btnArticulos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(286, 742);
            this.PanelMenu.TabIndex = 1;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnInicio.BackColor = System.Drawing.Color.White;
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(3, 12);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInicio.Size = new System.Drawing.Size(280, 59);
            this.BtnInicio.TabIndex = 4;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseCompatibleTextRendering = true;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnMarcas.BackColor = System.Drawing.Color.White;
            this.BtnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("BtnMarcas.Image")));
            this.BtnMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMarcas.Location = new System.Drawing.Point(26, 578);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(220, 80);
            this.BtnMarcas.TabIndex = 3;
            this.BtnMarcas.Text = "   Ver marcas";
            this.BtnMarcas.UseCompatibleTextRendering = true;
            this.BtnMarcas.UseVisualStyleBackColor = false;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCategorias.BackColor = System.Drawing.Color.White;
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategorias.Image")));
            this.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategorias.Location = new System.Drawing.Point(26, 483);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(220, 80);
            this.BtnCategorias.TabIndex = 2;
            this.BtnCategorias.Text = "       Ver categorías";
            this.BtnCategorias.UseCompatibleTextRendering = true;
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // BtnAgregarArticulo
            // 
            this.BtnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAgregarArticulo.BackColor = System.Drawing.Color.White;
            this.BtnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarArticulo.Image")));
            this.BtnAgregarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarArticulo.Location = new System.Drawing.Point(26, 216);
            this.BtnAgregarArticulo.Name = "BtnAgregarArticulo";
            this.BtnAgregarArticulo.Size = new System.Drawing.Size(220, 80);
            this.BtnAgregarArticulo.TabIndex = 1;
            this.BtnAgregarArticulo.Text = "       Agregar artículo";
            this.BtnAgregarArticulo.UseCompatibleTextRendering = true;
            this.BtnAgregarArticulo.UseVisualStyleBackColor = false;
            this.BtnAgregarArticulo.Click += new System.EventHandler(this.BtnAgregarArticulo_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Controls.Add(this.TcoMenu);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(286, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1066, 742);
            this.panelFormularios.TabIndex = 2;
            // 
            // TcoMenu
            // 
            this.TcoMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TcoMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcoMenu.ItemSize = new System.Drawing.Size(0, 40);
            this.TcoMenu.Location = new System.Drawing.Point(0, 0);
            this.TcoMenu.Multiline = true;
            this.TcoMenu.Name = "TcoMenu";
            this.TcoMenu.SelectedIndex = 0;
            this.TcoMenu.Size = new System.Drawing.Size(1066, 742);
            this.TcoMenu.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1352, 742);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Artículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Button BtnAgregarArticulo;
        private System.Windows.Forms.Button BtnMarcas;
        private System.Windows.Forms.Button BtnCategorias;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.TabControl TcoMenu;
    }
}