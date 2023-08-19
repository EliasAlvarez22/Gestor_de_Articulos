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
            this.BtnAgregarArticulo = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pbxInicio = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticulos.Location = new System.Drawing.Point(3, 177);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(243, 57);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "Ver artículos";
            this.btnArticulos.UseCompatibleTextRendering = true;
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoSize = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelMenu.Controls.Add(this.BtnAgregarArticulo);
            this.PanelMenu.Controls.Add(this.btnArticulos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(249, 583);
            this.PanelMenu.TabIndex = 1;
            // 
            // BtnAgregarArticulo
            // 
            this.BtnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAgregarArticulo.Location = new System.Drawing.Point(3, 263);
            this.BtnAgregarArticulo.Name = "BtnAgregarArticulo";
            this.BtnAgregarArticulo.Size = new System.Drawing.Size(243, 57);
            this.BtnAgregarArticulo.TabIndex = 1;
            this.BtnAgregarArticulo.Text = "Agregar artículo";
            this.BtnAgregarArticulo.UseCompatibleTextRendering = true;
            this.BtnAgregarArticulo.UseVisualStyleBackColor = true;
            this.BtnAgregarArticulo.Click += new System.EventHandler(this.BtnAgregarArticulo_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Controls.Add(this.pbxInicio);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(249, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1015, 583);
            this.panelFormularios.TabIndex = 2;
            // 
            // pbxInicio
            // 
            this.pbxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbxInicio.Image")));
            this.pbxInicio.InitialImage = null;
            this.pbxInicio.Location = new System.Drawing.Point(478, 207);
            this.pbxInicio.Name = "pbxInicio";
            this.pbxInicio.Size = new System.Drawing.Size(718, 481);
            this.pbxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInicio.TabIndex = 0;
            this.pbxInicio.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1264, 583);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Button BtnAgregarArticulo;
        private System.Windows.Forms.PictureBox pbxInicio;
    }
}