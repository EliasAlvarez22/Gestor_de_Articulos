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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.BtnAgregarArticulo = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.TcoMenu = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticulos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulos.Image")));
            this.btnArticulos.Location = new System.Drawing.Point(334, 27);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(92, 69);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.UseCompatibleTextRendering = true;
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelMenu.Controls.Add(this.label6);
            this.PanelMenu.Controls.Add(this.label4);
            this.PanelMenu.Controls.Add(this.label3);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.BtnInicio);
            this.PanelMenu.Controls.Add(this.BtnMarcas);
            this.PanelMenu.Controls.Add(this.BtnCategorias);
            this.PanelMenu.Controls.Add(this.BtnAgregarArticulo);
            this.PanelMenu.Controls.Add(this.btnArticulos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1352, 146);
            this.PanelMenu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ver artículos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(498, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(954, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ver marcas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio";
            // 
            // BtnInicio
            // 
            this.BtnInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnInicio.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.Location = new System.Drawing.Point(58, 26);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInicio.Size = new System.Drawing.Size(92, 69);
            this.BtnInicio.TabIndex = 4;
            this.BtnInicio.UseCompatibleTextRendering = true;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnMarcas.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("BtnMarcas.Image")));
            this.BtnMarcas.Location = new System.Drawing.Point(972, 27);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(92, 69);
            this.BtnMarcas.TabIndex = 3;
            this.BtnMarcas.UseCompatibleTextRendering = true;
            this.BtnMarcas.UseVisualStyleBackColor = false;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCategorias.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategorias.Image")));
            this.BtnCategorias.Location = new System.Drawing.Point(1209, 27);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(92, 69);
            this.BtnCategorias.TabIndex = 2;
            this.BtnCategorias.Text = "       ";
            this.BtnCategorias.UseCompatibleTextRendering = true;
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // BtnAgregarArticulo
            // 
            this.BtnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAgregarArticulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarArticulo.Image")));
            this.BtnAgregarArticulo.Location = new System.Drawing.Point(524, 27);
            this.BtnAgregarArticulo.Name = "BtnAgregarArticulo";
            this.BtnAgregarArticulo.Size = new System.Drawing.Size(92, 69);
            this.BtnAgregarArticulo.TabIndex = 1;
            this.BtnAgregarArticulo.UseCompatibleTextRendering = true;
            this.BtnAgregarArticulo.UseVisualStyleBackColor = false;
            this.BtnAgregarArticulo.Click += new System.EventHandler(this.BtnAgregarArticulo_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Controls.Add(this.TcoMenu);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 146);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1352, 596);
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
            this.TcoMenu.Size = new System.Drawing.Size(1352, 596);
            this.TcoMenu.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1171, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ver categorías";
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
            this.PanelMenu.PerformLayout();
            this.panelFormularios.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}