namespace Presentacion
{
    partial class Vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendedores));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbInsertar = new System.Windows.Forms.TabPage();
            this.lblVendedorR = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConsultar = new System.Windows.Forms.TabPage();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.tbModificar = new System.Windows.Forms.TabPage();
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.cmbCambio = new System.Windows.Forms.ComboBox();
            this.txtNCambio = new System.Windows.Forms.TextBox();
            this.txtConCambio = new System.Windows.Forms.TextBox();
            this.txtCoCambio = new System.Windows.Forms.TextBox();
            this.txtUCambio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbInsertar.SuspendLayout();
            this.tbConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.tbModificar.SuspendLayout();
            this.tbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbInsertar);
            this.tabControl1.Controls.Add(this.tbConsultar);
            this.tabControl1.Controls.Add(this.tbModificar);
            this.tabControl1.Controls.Add(this.tbEliminar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tbInsertar
            // 
            this.tbInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbInsertar.BackgroundImage")));
            this.tbInsertar.Controls.Add(this.lblVendedorR);
            this.tbInsertar.Controls.Add(this.btnGuardar);
            this.tbInsertar.Controls.Add(this.txtNombre);
            this.tbInsertar.Controls.Add(this.txtContrasena);
            this.tbInsertar.Controls.Add(this.txtUsuario);
            this.tbInsertar.Controls.Add(this.txtCodigo);
            this.tbInsertar.Controls.Add(this.label4);
            this.tbInsertar.Controls.Add(this.label3);
            this.tbInsertar.Controls.Add(this.label2);
            this.tbInsertar.Controls.Add(this.label1);
            this.tbInsertar.Location = new System.Drawing.Point(4, 22);
            this.tbInsertar.Name = "tbInsertar";
            this.tbInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsertar.Size = new System.Drawing.Size(604, 370);
            this.tbInsertar.TabIndex = 0;
            this.tbInsertar.Text = "Insertar Vendedor";
            this.tbInsertar.UseVisualStyleBackColor = true;
            // 
            // lblVendedorR
            // 
            this.lblVendedorR.AutoSize = true;
            this.lblVendedorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVendedorR.Location = new System.Drawing.Point(300, 87);
            this.lblVendedorR.Name = "lblVendedorR";
            this.lblVendedorR.Size = new System.Drawing.Size(0, 13);
            this.lblVendedorR.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(237, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(300, 245);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(300, 187);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(159, 20);
            this.txtContrasena.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(300, 120);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(159, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(300, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(187, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(169, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(184, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(184, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // tbConsultar
            // 
            this.tbConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbConsultar.BackgroundImage")));
            this.tbConsultar.Controls.Add(this.btnFiltrar);
            this.tbConsultar.Controls.Add(this.btnMostrar);
            this.tbConsultar.Controls.Add(this.label5);
            this.tbConsultar.Controls.Add(this.DgvConsulta);
            this.tbConsultar.Controls.Add(this.cmbConsultar);
            this.tbConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultar.Size = new System.Drawing.Size(604, 370);
            this.tbConsultar.TabIndex = 1;
            this.tbConsultar.Text = "Consultar Vendedor";
            this.tbConsultar.UseVisualStyleBackColor = true;
            this.tbConsultar.Enter += new System.EventHandler(this.tbConsultar_Enter);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(245, 120);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(351, 120);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(160, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "VENDEDOR";
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(109, 165);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.Size = new System.Drawing.Size(458, 150);
            this.DgvConsulta.TabIndex = 1;
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Location = new System.Drawing.Point(270, 60);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(200, 21);
            this.cmbConsultar.TabIndex = 0;
            // 
            // tbModificar
            // 
            this.tbModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbModificar.BackgroundImage")));
            this.tbModificar.Controls.Add(this.btnGuardarCambio);
            this.tbModificar.Controls.Add(this.cmbCambio);
            this.tbModificar.Controls.Add(this.txtNCambio);
            this.tbModificar.Controls.Add(this.txtConCambio);
            this.tbModificar.Controls.Add(this.txtCoCambio);
            this.tbModificar.Controls.Add(this.txtUCambio);
            this.tbModificar.Controls.Add(this.label11);
            this.tbModificar.Controls.Add(this.label10);
            this.tbModificar.Controls.Add(this.label9);
            this.tbModificar.Controls.Add(this.label8);
            this.tbModificar.Controls.Add(this.label7);
            this.tbModificar.Location = new System.Drawing.Point(4, 22);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbModificar.Size = new System.Drawing.Size(604, 370);
            this.tbModificar.TabIndex = 2;
            this.tbModificar.Text = "Modificar Vendedor";
            this.tbModificar.UseVisualStyleBackColor = true;
            this.tbModificar.Enter += new System.EventHandler(this.tbModificar_Enter);
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambio.Location = new System.Drawing.Point(286, 310);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(87, 31);
            this.btnGuardarCambio.TabIndex = 11;
            this.btnGuardarCambio.Text = "Guardar";
            this.btnGuardarCambio.UseVisualStyleBackColor = true;
            this.btnGuardarCambio.Click += new System.EventHandler(this.btnGuardarCambio_Click);
            // 
            // cmbCambio
            // 
            this.cmbCambio.FormattingEnabled = true;
            this.cmbCambio.Location = new System.Drawing.Point(286, 52);
            this.cmbCambio.Name = "cmbCambio";
            this.cmbCambio.Size = new System.Drawing.Size(174, 21);
            this.cmbCambio.TabIndex = 10;
            this.cmbCambio.SelectedIndexChanged += new System.EventHandler(this.cmbCambio_SelectedIndexChanged);
            // 
            // txtNCambio
            // 
            this.txtNCambio.Location = new System.Drawing.Point(286, 254);
            this.txtNCambio.Name = "txtNCambio";
            this.txtNCambio.Size = new System.Drawing.Size(174, 20);
            this.txtNCambio.TabIndex = 9;
            // 
            // txtConCambio
            // 
            this.txtConCambio.Location = new System.Drawing.Point(286, 213);
            this.txtConCambio.Name = "txtConCambio";
            this.txtConCambio.Size = new System.Drawing.Size(174, 20);
            this.txtConCambio.TabIndex = 8;
            // 
            // txtCoCambio
            // 
            this.txtCoCambio.Enabled = false;
            this.txtCoCambio.Location = new System.Drawing.Point(286, 129);
            this.txtCoCambio.Name = "txtCoCambio";
            this.txtCoCambio.Size = new System.Drawing.Size(174, 20);
            this.txtCoCambio.TabIndex = 7;
            // 
            // txtUCambio
            // 
            this.txtUCambio.Location = new System.Drawing.Point(286, 169);
            this.txtUCambio.Name = "txtUCambio";
            this.txtUCambio.Size = new System.Drawing.Size(174, 20);
            this.txtUCambio.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(175, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "NOMBRE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(163, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "CONTRASEÑA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(172, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "USUARIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(182, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "CODIGO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(172, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "USUARIO";
            // 
            // tbEliminar
            // 
            this.tbEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEliminar.BackgroundImage")));
            this.tbEliminar.Controls.Add(this.btnEliminar);
            this.tbEliminar.Controls.Add(this.label6);
            this.tbEliminar.Controls.Add(this.cmbEliminar);
            this.tbEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEliminar.Size = new System.Drawing.Size(604, 370);
            this.tbEliminar.TabIndex = 3;
            this.tbEliminar.Text = "Eliminar Vendedor";
            this.tbEliminar.UseVisualStyleBackColor = true;
            this.tbEliminar.Enter += new System.EventHandler(this.tbEliminar_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(270, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(140, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "VENDEDOR";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(239, 156);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(192, 21);
            this.cmbEliminar.TabIndex = 0;
            // 
            // Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 396);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.tabControl1.ResumeLayout(false);
            this.tbInsertar.ResumeLayout(false);
            this.tbInsertar.PerformLayout();
            this.tbConsultar.ResumeLayout(false);
            this.tbConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.tbModificar.ResumeLayout(false);
            this.tbModificar.PerformLayout();
            this.tbEliminar.ResumeLayout(false);
            this.tbEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbInsertar;
        private System.Windows.Forms.TabPage tbConsultar;
        private System.Windows.Forms.TabPage tbModificar;
        private System.Windows.Forms.TabPage tbEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVendedorR;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.ComboBox cmbConsultar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Button btnGuardarCambio;
        private System.Windows.Forms.ComboBox cmbCambio;
        private System.Windows.Forms.TextBox txtNCambio;
        private System.Windows.Forms.TextBox txtConCambio;
        private System.Windows.Forms.TextBox txtCoCambio;
        private System.Windows.Forms.TextBox txtUCambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}