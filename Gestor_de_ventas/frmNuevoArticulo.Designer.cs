﻿namespace Gestor_de_ventas
{
    partial class frmNuevoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoArticulo));
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblCodigoArticulo = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.LblUrlImagen = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.LblArticuloNuevo = new System.Windows.Forms.Label();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.BtnInicializar = new System.Windows.Forms.Button();
            this.BtnAgregarimagen = new System.Windows.Forms.Button();
            this.pbxCodigo = new System.Windows.Forms.PictureBox();
            this.pbxNombre = new System.Windows.Forms.PictureBox();
            this.pbxPrecio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(279, 395);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(107, 58);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(446, 395);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(131, 58);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblCodigoArticulo
            // 
            this.LblCodigoArticulo.AutoSize = true;
            this.LblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoArticulo.Location = new System.Drawing.Point(51, 146);
            this.LblCodigoArticulo.Name = "LblCodigoArticulo";
            this.LblCodigoArticulo.Size = new System.Drawing.Size(155, 22);
            this.LblCodigoArticulo.TabIndex = 2;
            this.LblCodigoArticulo.Text = "Código de artículo";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Location = new System.Drawing.Point(255, 146);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(165, 22);
            this.txtCodArticulo.TabIndex = 0;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(51, 295);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(59, 22);
            this.LblMarca.TabIndex = 4;
            this.LblMarca.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(255, 191);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(51, 191);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(73, 22);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(255, 237);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(51, 237);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(104, 22);
            this.LblDescripcion.TabIndex = 8;
            this.LblDescripcion.Text = "Descripción";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(621, 187);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(165, 22);
            this.txtUrlImagen.TabIndex = 5;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // LblUrlImagen
            // 
            this.LblUrlImagen.AutoSize = true;
            this.LblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrlImagen.Location = new System.Drawing.Point(470, 186);
            this.LblUrlImagen.Name = "LblUrlImagen";
            this.LblUrlImagen.Size = new System.Drawing.Size(96, 22);
            this.LblUrlImagen.TabIndex = 10;
            this.LblUrlImagen.Text = "Url Imagen";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(621, 239);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(165, 22);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(470, 239);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(61, 22);
            this.LblPrecio.TabIndex = 12;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(470, 146);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(88, 22);
            this.LblCategoria.TabIndex = 14;
            this.LblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(621, 144);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(165, 24);
            this.cboCategoria.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Location = new System.Drawing.Point(255, 293);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(165, 24);
            this.cboMarca.TabIndex = 3;
            // 
            // LblArticuloNuevo
            // 
            this.LblArticuloNuevo.AutoSize = true;
            this.LblArticuloNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticuloNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblArticuloNuevo.Location = new System.Drawing.Point(26, 37);
            this.LblArticuloNuevo.Name = "LblArticuloNuevo";
            this.LblArticuloNuevo.Size = new System.Drawing.Size(333, 54);
            this.LblArticuloNuevo.TabIndex = 16;
            this.LblArticuloNuevo.Text = "Artículo nuevo";
            // 
            // PbxImagen
            // 
            this.PbxImagen.Image = ((System.Drawing.Image)(resources.GetObject("PbxImagen.Image")));
            this.PbxImagen.Location = new System.Drawing.Point(875, 284);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(383, 345);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 17;
            this.PbxImagen.TabStop = false;
            // 
            // BtnInicializar
            // 
            this.BtnInicializar.AutoSize = true;
            this.BtnInicializar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicializar.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicializar.Image")));
            this.BtnInicializar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicializar.Location = new System.Drawing.Point(800, 304);
            this.BtnInicializar.Name = "BtnInicializar";
            this.BtnInicializar.Size = new System.Drawing.Size(42, 41);
            this.BtnInicializar.TabIndex = 18;
            this.BtnInicializar.UseVisualStyleBackColor = true;
            this.BtnInicializar.Click += new System.EventHandler(this.BtnInicializar_Click);
            // 
            // BtnAgregarimagen
            // 
            this.BtnAgregarimagen.AutoSize = true;
            this.BtnAgregarimagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarimagen.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarimagen.Image")));
            this.BtnAgregarimagen.Location = new System.Drawing.Point(804, 179);
            this.BtnAgregarimagen.Name = "BtnAgregarimagen";
            this.BtnAgregarimagen.Size = new System.Drawing.Size(38, 38);
            this.BtnAgregarimagen.TabIndex = 19;
            this.BtnAgregarimagen.UseVisualStyleBackColor = true;
            this.BtnAgregarimagen.Click += new System.EventHandler(this.BtnAgregarimagen_Click);
            // 
            // pbxCodigo
            // 
            this.pbxCodigo.Image = ((System.Drawing.Image)(resources.GetObject("pbxCodigo.Image")));
            this.pbxCodigo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxCodigo.InitialImage")));
            this.pbxCodigo.Location = new System.Drawing.Point(224, 146);
            this.pbxCodigo.Name = "pbxCodigo";
            this.pbxCodigo.Size = new System.Drawing.Size(25, 22);
            this.pbxCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCodigo.TabIndex = 20;
            this.pbxCodigo.TabStop = false;
            this.pbxCodigo.Visible = false;
            // 
            // pbxNombre
            // 
            this.pbxNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbxNombre.Image")));
            this.pbxNombre.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxNombre.InitialImage")));
            this.pbxNombre.Location = new System.Drawing.Point(224, 191);
            this.pbxNombre.Name = "pbxNombre";
            this.pbxNombre.Size = new System.Drawing.Size(25, 22);
            this.pbxNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNombre.TabIndex = 21;
            this.pbxNombre.TabStop = false;
            this.pbxNombre.Visible = false;
            // 
            // pbxPrecio
            // 
            this.pbxPrecio.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrecio.Image")));
            this.pbxPrecio.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxPrecio.InitialImage")));
            this.pbxPrecio.Location = new System.Drawing.Point(579, 239);
            this.pbxPrecio.Name = "pbxPrecio";
            this.pbxPrecio.Size = new System.Drawing.Size(25, 22);
            this.pbxPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPrecio.TabIndex = 25;
            this.pbxPrecio.TabStop = false;
            this.pbxPrecio.Visible = false;
            // 
            // frmNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1254, 601);
            this.Controls.Add(this.pbxPrecio);
            this.Controls.Add(this.pbxNombre);
            this.Controls.Add(this.pbxCodigo);
            this.Controls.Add(this.BtnAgregarimagen);
            this.Controls.Add(this.BtnInicializar);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.LblArticuloNuevo);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.LblUrlImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.txtCodArticulo);
            this.Controls.Add(this.LblCodigoArticulo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo nuevo";
            this.Load += new System.EventHandler(this.frmNuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblCodigoArticulo;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label LblUrlImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label LblArticuloNuevo;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Button BtnInicializar;
        private System.Windows.Forms.Button BtnAgregarimagen;
        private System.Windows.Forms.PictureBox pbxCodigo;
        private System.Windows.Forms.PictureBox pbxNombre;
        private System.Windows.Forms.PictureBox pbxPrecio;
    }
}