namespace GestorArticulos
{
    partial class FormBusquedaAvanzada
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.errorBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Moccasin;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Moccasin;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(295, 99);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(52, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(12, 14);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(35, 12);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicion.Location = new System.Drawing.Point(224, 14);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(59, 12);
            this.lblCondicion.TabIndex = 7;
            this.lblCondicion.Text = "Condición";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(37, 75);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(41, 12);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtro";
            // 
            // cbCampo
            // 
            this.cbCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(12, 29);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 20);
            this.cbCampo.TabIndex = 0;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCondicion
            // 
            this.cbCondicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicion.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Location = new System.Drawing.Point(226, 29);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(121, 20);
            this.cbCondicion.TabIndex = 1;
            this.cbCondicion.Click += new System.EventHandler(this.cbCondicion_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(84, 71);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(196, 19);
            this.txtFiltro.TabIndex = 2;
            // 
            // errorBuscar
            // 
            this.errorBuscar.ContainerControl = this;
            // 
            // FormBusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(359, 134);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cbCondicion);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 173);
            this.MinimumSize = new System.Drawing.Size(375, 173);
            this.Name = "FormBusquedaAvanzada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.Load += new System.EventHandler(this.FormBusquedaAvanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ErrorProvider errorBuscar;
    }
}