namespace Presentacion
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbIngresar = new System.Windows.Forms.TabPage();
            this.lblRepetido = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConsultar = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBuscar = new System.Windows.Forms.ComboBox();
            this.tbModificar = new System.Windows.Forms.TabPage();
            this.btnCambios = new System.Windows.Forms.Button();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.txtV = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CmbCambio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEliminar = new System.Windows.Forms.TabPage();
            this.CmbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbIngresar.SuspendLayout();
            this.tbConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.tbModificar.SuspendLayout();
            this.tbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbIngresar);
            this.tabControl1.Controls.Add(this.tbConsultar);
            this.tabControl1.Controls.Add(this.tbModificar);
            this.tabControl1.Controls.Add(this.tbEliminar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 435);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tbIngresar
            // 
            this.tbIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbIngresar.BackgroundImage")));
            this.tbIngresar.Controls.Add(this.lblRepetido);
            this.tbIngresar.Controls.Add(this.btnGuardar);
            this.tbIngresar.Controls.Add(this.txtDescripcion);
            this.tbIngresar.Controls.Add(this.txtValor);
            this.tbIngresar.Controls.Add(this.txtCantidad);
            this.tbIngresar.Controls.Add(this.txtCodigo);
            this.tbIngresar.Controls.Add(this.label4);
            this.tbIngresar.Controls.Add(this.label3);
            this.tbIngresar.Controls.Add(this.label2);
            this.tbIngresar.Controls.Add(this.label1);
            this.tbIngresar.ImageKey = "(ninguno)";
            this.tbIngresar.Location = new System.Drawing.Point(4, 22);
            this.tbIngresar.Name = "tbIngresar";
            this.tbIngresar.Padding = new System.Windows.Forms.Padding(3);
            this.tbIngresar.Size = new System.Drawing.Size(620, 409);
            this.tbIngresar.TabIndex = 0;
            this.tbIngresar.Text = "Ingresar Producto";
            this.tbIngresar.UseVisualStyleBackColor = true;
            // 
            // lblRepetido
            // 
            this.lblRepetido.AutoSize = true;
            this.lblRepetido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRepetido.Location = new System.Drawing.Point(262, 100);
            this.lblRepetido.Name = "lblRepetido";
            this.lblRepetido.Size = new System.Drawing.Size(0, 13);
            this.lblRepetido.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(304, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 32);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(262, 129);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(262, 186);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(187, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(262, 258);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(187, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(262, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(187, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(138, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(146, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "VALOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(126, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCIÓN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // tbConsultar
            // 
            this.tbConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbConsultar.BackgroundImage")));
            this.tbConsultar.Controls.Add(this.btnMostrar);
            this.tbConsultar.Controls.Add(this.btnConsultar);
            this.tbConsultar.Controls.Add(this.DgvProductos);
            this.tbConsultar.Controls.Add(this.label6);
            this.tbConsultar.Controls.Add(this.CmbBuscar);
            this.tbConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbConsultar.Name = "tbConsultar";
            this.tbConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultar.Size = new System.Drawing.Size(620, 409);
            this.tbConsultar.TabIndex = 1;
            this.tbConsultar.Text = "Consultar Producto";
            this.tbConsultar.UseVisualStyleBackColor = true;
            this.tbConsultar.Enter += new System.EventHandler(this.tbConsultar_Enter);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(333, 103);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(111, 31);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(199, 103);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 31);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(86, 181);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(480, 167);
            this.DgvProductos.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(120, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo";
            // 
            // CmbBuscar
            // 
            this.CmbBuscar.FormattingEnabled = true;
            this.CmbBuscar.Location = new System.Drawing.Point(199, 60);
            this.CmbBuscar.Name = "CmbBuscar";
            this.CmbBuscar.Size = new System.Drawing.Size(236, 21);
            this.CmbBuscar.TabIndex = 0;
            // 
            // tbModificar
            // 
            this.tbModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbModificar.BackgroundImage")));
            this.tbModificar.Controls.Add(this.btnCambios);
            this.tbModificar.Controls.Add(this.txtCa);
            this.tbModificar.Controls.Add(this.txtV);
            this.tbModificar.Controls.Add(this.txtD);
            this.tbModificar.Controls.Add(this.txtC);
            this.tbModificar.Controls.Add(this.label11);
            this.tbModificar.Controls.Add(this.label10);
            this.tbModificar.Controls.Add(this.label9);
            this.tbModificar.Controls.Add(this.label8);
            this.tbModificar.Controls.Add(this.BtnBuscar);
            this.tbModificar.Controls.Add(this.CmbCambio);
            this.tbModificar.Controls.Add(this.label7);
            this.tbModificar.Location = new System.Drawing.Point(4, 22);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbModificar.Size = new System.Drawing.Size(620, 409);
            this.tbModificar.TabIndex = 2;
            this.tbModificar.Text = "Modificar Producto";
            this.tbModificar.UseVisualStyleBackColor = true;
            this.tbModificar.Enter += new System.EventHandler(this.tbModificar_Enter);
            // 
            // btnCambios
            // 
            this.btnCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.Location = new System.Drawing.Point(282, 324);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(104, 27);
            this.btnCambios.TabIndex = 5;
            this.btnCambios.Text = "GUARDAR CAMBIOS";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // txtCa
            // 
            this.txtCa.Location = new System.Drawing.Point(255, 286);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(188, 20);
            this.txtCa.TabIndex = 4;
            this.txtCa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCa_KeyPress);
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(255, 239);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(188, 20);
            this.txtV.TabIndex = 4;
            this.txtV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV_KeyPress);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(255, 188);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(188, 20);
            this.txtD.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(255, 139);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(188, 20);
            this.txtC.TabIndex = 4;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(128, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "CANTIDAD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(141, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "VALOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(128, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "DESCRIPCIÓN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(141, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "CODIGO:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(282, 89);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Consultar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // CmbCambio
            // 
            this.CmbCambio.FormattingEnabled = true;
            this.CmbCambio.Location = new System.Drawing.Point(243, 42);
            this.CmbCambio.Name = "CmbCambio";
            this.CmbCambio.Size = new System.Drawing.Size(236, 21);
            this.CmbCambio.TabIndex = 1;
            this.CmbCambio.SelectedIndexChanged += new System.EventHandler(this.CmbCambio_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(147, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "PRODUCTO";
            // 
            // tbEliminar
            // 
            this.tbEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEliminar.BackgroundImage")));
            this.tbEliminar.Controls.Add(this.CmbEliminar);
            this.tbEliminar.Controls.Add(this.btnEliminar);
            this.tbEliminar.Controls.Add(this.label12);
            this.tbEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEliminar.Size = new System.Drawing.Size(620, 409);
            this.tbEliminar.TabIndex = 3;
            this.tbEliminar.Text = "Eliminar Producto";
            this.tbEliminar.UseVisualStyleBackColor = true;
            // 
            // CmbEliminar
            // 
            this.CmbEliminar.FormattingEnabled = true;
            this.CmbEliminar.Location = new System.Drawing.Point(256, 166);
            this.CmbEliminar.Name = "CmbEliminar";
            this.CmbEliminar.Size = new System.Drawing.Size(179, 21);
            this.CmbEliminar.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(284, 228);
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
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(154, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Producto:";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 435);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.tabControl1.ResumeLayout(false);
            this.tbIngresar.ResumeLayout(false);
            this.tbIngresar.PerformLayout();
            this.tbConsultar.ResumeLayout(false);
            this.tbConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.tbModificar.ResumeLayout(false);
            this.tbModificar.PerformLayout();
            this.tbEliminar.ResumeLayout(false);
            this.tbEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbIngresar;
        private System.Windows.Forms.TabPage tbConsultar;
        private System.Windows.Forms.TabPage tbModificar;
        private System.Windows.Forms.TabPage tbEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CmbCambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRepetido;
    }
}