namespace GestorArticulos
{
    partial class FormArticulo
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
            this.components = new System.ComponentModel.Container();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblCampoObligatorio = new System.Windows.Forms.Label();
            this.errorMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(233, 86);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(47, 12);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código*";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(233, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 12);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre*";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(203, 138);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(71, 12);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigo.Location = new System.Drawing.Point(280, 82);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(178, 19);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(280, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 19);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(280, 134);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(178, 19);
            this.txtDescripcion.TabIndex = 3;
            // 
            // cbMarca
            // 
            this.cbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(280, 160);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 20);
            this.cbMarca.TabIndex = 4;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            this.cbMarca.Click += new System.EventHandler(this.cbMarca_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(280, 187);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 20);
            this.cbCategoria.TabIndex = 5;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            this.cbCategoria.Click += new System.EventHandler(this.cbCategoria_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(239, 164);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(41, 12);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca*";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(215, 191);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 12);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoría*";
            // 
            // pbArticulo
            // 
            this.pbArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbArticulo.Location = new System.Drawing.Point(9, 64);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(174, 247);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 11;
            this.pbArticulo.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(12, 358);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(57, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Moccasin;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(392, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenUrl.Location = new System.Drawing.Point(215, 218);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(59, 12);
            this.lblImagenUrl.TabIndex = 16;
            this.lblImagenUrl.Text = "ImagenURL";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagenUrl.Location = new System.Drawing.Point(280, 214);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(178, 19);
            this.txtImagenUrl.TabIndex = 6;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(233, 294);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 12);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio*";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 4;
            this.nudPrecio.Location = new System.Drawing.Point(280, 291);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(126, 20);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(189, 9);
            this.lblDetalle.MaximumSize = new System.Drawing.Size(70, 26);
            this.lblDetalle.MinimumSize = new System.Drawing.Size(70, 26);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(70, 26);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblCampoObligatorio
            // 
            this.lblCampoObligatorio.AutoSize = true;
            this.lblCampoObligatorio.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoObligatorio.Location = new System.Drawing.Point(233, 51);
            this.lblCampoObligatorio.Name = "lblCampoObligatorio";
            this.lblCampoObligatorio.Size = new System.Drawing.Size(131, 12);
            this.lblCampoObligatorio.TabIndex = 10;
            this.lblCampoObligatorio.Text = "(*) Campo Obligatorio";
            // 
            // errorMarca
            // 
            this.errorMarca.ContainerControl = this;
            // 
            // errorCategoria
            // 
            this.errorCategoria.ContainerControl = this;
            // 
            // errorPrecio
            // 
            this.errorPrecio.ContainerControl = this;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(470, 393);
            this.Controls.Add(this.lblCampoObligatorio);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 432);
            this.MinimumSize = new System.Drawing.Size(469, 432);
            this.Name = "FormArticulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormArticulo_FormClosing);
            this.Load += new System.EventHandler(this.FormArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblCampoObligatorio;
        private System.Windows.Forms.ErrorProvider errorMarca;
        private System.Windows.Forms.ErrorProvider errorCategoria;
        private System.Windows.Forms.ErrorProvider errorPrecio;
    }
}