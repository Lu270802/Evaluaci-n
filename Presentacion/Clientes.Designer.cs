namespace Presentacion
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbICliente = new System.Windows.Forms.TabPage();
            this.lblDoc = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCCliente = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostar = new System.Windows.Forms.Button();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.tbMoCliente = new System.Windows.Forms.TabPage();
            this.txtDocC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCambio = new System.Windows.Forms.Button();
            this.txtCoC = new System.Windows.Forms.TextBox();
            this.txtTeC = new System.Windows.Forms.TextBox();
            this.txtDiC = new System.Windows.Forms.TextBox();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.cmbCambio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbElCliente = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbEliminar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbICliente.SuspendLayout();
            this.tbCCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.tbMoCliente.SuspendLayout();
            this.tbElCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbICliente);
            this.tabControl1.Controls.Add(this.tbCCliente);
            this.tabControl1.Controls.Add(this.tbMoCliente);
            this.tabControl1.Controls.Add(this.tbElCliente);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tbICliente
            // 
            this.tbICliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbICliente.BackgroundImage")));
            this.tbICliente.Controls.Add(this.lblDoc);
            this.tbICliente.Controls.Add(this.btnGuardar);
            this.tbICliente.Controls.Add(this.txtDocumento);
            this.tbICliente.Controls.Add(this.txtDireccion);
            this.tbICliente.Controls.Add(this.txtTelefono);
            this.tbICliente.Controls.Add(this.txtCorreo);
            this.tbICliente.Controls.Add(this.label5);
            this.tbICliente.Controls.Add(this.label4);
            this.tbICliente.Controls.Add(this.label3);
            this.tbICliente.Controls.Add(this.label2);
            this.tbICliente.Controls.Add(this.txtNombre);
            this.tbICliente.Controls.Add(this.label1);
            this.tbICliente.Location = new System.Drawing.Point(4, 22);
            this.tbICliente.Name = "tbICliente";
            this.tbICliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbICliente.Size = new System.Drawing.Size(620, 409);
            this.tbICliente.TabIndex = 0;
            this.tbICliente.Text = "Ingresar Cliente ";
            this.tbICliente.UseVisualStyleBackColor = true;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(296, 85);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(0, 13);
            this.lblDoc.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(288, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 37);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(288, 62);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(167, 20);
            this.txtDocumento.TabIndex = 9;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(288, 154);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(288, 195);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(288, 243);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(167, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(152, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "CORREO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(152, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(152, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "DIRECCIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(152, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(288, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(152, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCUMENTO:";
            // 
            // tbCCliente
            // 
            this.tbCCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbCCliente.BackgroundImage")));
            this.tbCCliente.Controls.Add(this.label6);
            this.tbCCliente.Controls.Add(this.btnFiltrar);
            this.tbCCliente.Controls.Add(this.btnMostar);
            this.tbCCliente.Controls.Add(this.DgvConsulta);
            this.tbCCliente.Controls.Add(this.cmbConsulta);
            this.tbCCliente.Location = new System.Drawing.Point(4, 22);
            this.tbCCliente.Name = "tbCCliente";
            this.tbCCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbCCliente.Size = new System.Drawing.Size(620, 409);
            this.tbCCliente.TabIndex = 1;
            this.tbCCliente.Text = "Conusltar Cliente";
            this.tbCCliente.UseVisualStyleBackColor = true;
            this.tbCCliente.Enter += new System.EventHandler(this.tbCCliente_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(122, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "CLIENTE:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(216, 105);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 30);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Consultar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostar
            // 
            this.btnMostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostar.Location = new System.Drawing.Point(316, 105);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(90, 30);
            this.btnMostar.TabIndex = 2;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(95, 179);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.Size = new System.Drawing.Size(442, 150);
            this.DgvConsulta.TabIndex = 1;
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Location = new System.Drawing.Point(216, 66);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(214, 21);
            this.cmbConsulta.TabIndex = 0;
            // 
            // tbMoCliente
            // 
            this.tbMoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMoCliente.BackgroundImage")));
            this.tbMoCliente.Controls.Add(this.txtDocC);
            this.tbMoCliente.Controls.Add(this.label13);
            this.tbMoCliente.Controls.Add(this.btnCambio);
            this.tbMoCliente.Controls.Add(this.txtCoC);
            this.tbMoCliente.Controls.Add(this.txtTeC);
            this.tbMoCliente.Controls.Add(this.txtDiC);
            this.tbMoCliente.Controls.Add(this.txtNC);
            this.tbMoCliente.Controls.Add(this.cmbCambio);
            this.tbMoCliente.Controls.Add(this.label11);
            this.tbMoCliente.Controls.Add(this.label10);
            this.tbMoCliente.Controls.Add(this.label9);
            this.tbMoCliente.Controls.Add(this.label8);
            this.tbMoCliente.Controls.Add(this.label7);
            this.tbMoCliente.Location = new System.Drawing.Point(4, 22);
            this.tbMoCliente.Name = "tbMoCliente";
            this.tbMoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbMoCliente.Size = new System.Drawing.Size(620, 409);
            this.tbMoCliente.TabIndex = 2;
            this.tbMoCliente.Text = "Modificar Cliente";
            this.tbMoCliente.UseVisualStyleBackColor = true;
            this.tbMoCliente.Enter += new System.EventHandler(this.tbMoCliente_Enter);
            // 
            // txtDocC
            // 
            this.txtDocC.Enabled = false;
            this.txtDocC.Location = new System.Drawing.Point(266, 93);
            this.txtDocC.Name = "txtDocC";
            this.txtDocC.Size = new System.Drawing.Size(171, 20);
            this.txtDocC.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(170, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Doc";
            // 
            // btnCambio
            // 
            this.btnCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambio.Location = new System.Drawing.Point(306, 344);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(75, 29);
            this.btnCambio.TabIndex = 11;
            this.btnCambio.Text = "Guardar";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // txtCoC
            // 
            this.txtCoC.Location = new System.Drawing.Point(266, 298);
            this.txtCoC.Name = "txtCoC";
            this.txtCoC.Size = new System.Drawing.Size(171, 20);
            this.txtCoC.TabIndex = 10;
            // 
            // txtTeC
            // 
            this.txtTeC.Location = new System.Drawing.Point(266, 245);
            this.txtTeC.Name = "txtTeC";
            this.txtTeC.Size = new System.Drawing.Size(171, 20);
            this.txtTeC.TabIndex = 9;
            // 
            // txtDiC
            // 
            this.txtDiC.Location = new System.Drawing.Point(266, 196);
            this.txtDiC.Name = "txtDiC";
            this.txtDiC.Size = new System.Drawing.Size(171, 20);
            this.txtDiC.TabIndex = 7;
            // 
            // txtNC
            // 
            this.txtNC.Location = new System.Drawing.Point(266, 141);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(171, 20);
            this.txtNC.TabIndex = 6;
            // 
            // cmbCambio
            // 
            this.cmbCambio.FormattingEnabled = true;
            this.cmbCambio.Location = new System.Drawing.Point(271, 41);
            this.cmbCambio.Name = "cmbCambio";
            this.cmbCambio.Size = new System.Drawing.Size(171, 21);
            this.cmbCambio.TabIndex = 5;
            this.cmbCambio.SelectedIndexChanged += new System.EventHandler(this.cmbCambio_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(157, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "NOMBRE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(162, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "CLIENTE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(157, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "CORREO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(157, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "DIRECIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(157, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "TELÉFONO";
            // 
            // tbElCliente
            // 
            this.tbElCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbElCliente.BackgroundImage")));
            this.tbElCliente.Controls.Add(this.btnEliminar);
            this.tbElCliente.Controls.Add(this.label12);
            this.tbElCliente.Controls.Add(this.CmbEliminar);
            this.tbElCliente.Location = new System.Drawing.Point(4, 22);
            this.tbElCliente.Name = "tbElCliente";
            this.tbElCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbElCliente.Size = new System.Drawing.Size(620, 409);
            this.tbElCliente.TabIndex = 3;
            this.tbElCliente.Text = "Eliminar Cliente";
            this.tbElCliente.UseVisualStyleBackColor = true;
            this.tbElCliente.Enter += new System.EventHandler(this.tbElCliente_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(274, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(173, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "CLIENTE";
            // 
            // CmbEliminar
            // 
            this.CmbEliminar.FormattingEnabled = true;
            this.CmbEliminar.Location = new System.Drawing.Point(249, 159);
            this.CmbEliminar.Name = "CmbEliminar";
            this.CmbEliminar.Size = new System.Drawing.Size(188, 21);
            this.CmbEliminar.TabIndex = 0;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 435);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tbICliente.ResumeLayout(false);
            this.tbICliente.PerformLayout();
            this.tbCCliente.ResumeLayout(false);
            this.tbCCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.tbMoCliente.ResumeLayout(false);
            this.tbMoCliente.PerformLayout();
            this.tbElCliente.ResumeLayout(false);
            this.tbElCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbICliente;
        private System.Windows.Forms.TabPage tbCCliente;
        private System.Windows.Forms.TabPage tbMoCliente;
        private System.Windows.Forms.TabPage tbElCliente;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCoC;
        private System.Windows.Forms.TextBox txtTeC;
        private System.Windows.Forms.TextBox txtDiC;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.ComboBox cmbCambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.ComboBox CmbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtDocC;
        private System.Windows.Forms.Label label13;
    }
}