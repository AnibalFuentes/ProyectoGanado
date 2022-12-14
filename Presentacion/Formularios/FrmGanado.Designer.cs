namespace Presentacion.Formularios
{
    partial class FrmGanado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxEstado = new System.Windows.Forms.ComboBox();
            this.TxPesoVenta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxVenta = new System.Windows.Forms.Label();
            this.TxCompra = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxRaza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.ListaGanado = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxIdGanado = new System.Windows.Forms.TextBox();
            this.TxIndice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.Label();
            this.TxConsultar = new System.Windows.Forms.TextBox();
            this.BtnSeleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdGanado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesesRecuperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BoxEstado);
            this.groupBox1.Controls.Add(this.TxPesoVenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BoxMeses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxVenta);
            this.groupBox1.Controls.Add(this.TxCompra);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxPeso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BoxSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BoxRaza);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar de ganados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado";
            // 
            // BoxEstado
            // 
            this.BoxEstado.FormattingEnabled = true;
            this.BoxEstado.Location = new System.Drawing.Point(491, 53);
            this.BoxEstado.Name = "BoxEstado";
            this.BoxEstado.Size = new System.Drawing.Size(93, 26);
            this.BoxEstado.TabIndex = 18;
            // 
            // TxPesoVenta
            // 
            this.TxPesoVenta.AutoSize = true;
            this.TxPesoVenta.Location = new System.Drawing.Point(607, 53);
            this.TxPesoVenta.Name = "TxPesoVenta";
            this.TxPesoVenta.Size = new System.Drawing.Size(17, 18);
            this.TxPesoVenta.TabIndex = 17;
            this.TxPesoVenta.Text = "0";
            this.TxPesoVenta.TextChanged += new System.EventHandler(this.TxPesoVenta_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(593, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Peso venta(Kg)";
            // 
            // BoxMeses
            // 
            this.BoxMeses.FormattingEnabled = true;
            this.BoxMeses.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.BoxMeses.Location = new System.Drawing.Point(311, 53);
            this.BoxMeses.Name = "BoxMeses";
            this.BoxMeses.Size = new System.Drawing.Size(65, 26);
            this.BoxMeses.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recuperacion(Meses)";
            // 
            // TxVenta
            // 
            this.TxVenta.AutoSize = true;
            this.TxVenta.Location = new System.Drawing.Point(892, 55);
            this.TxVenta.Name = "TxVenta";
            this.TxVenta.Size = new System.Drawing.Size(17, 18);
            this.TxVenta.TabIndex = 13;
            this.TxVenta.Text = "0";
            // 
            // TxCompra
            // 
            this.TxCompra.AutoSize = true;
            this.TxCompra.Location = new System.Drawing.Point(736, 56);
            this.TxCompra.Name = "TxCompra";
            this.TxCompra.Size = new System.Drawing.Size(17, 18);
            this.TxCompra.TabIndex = 5;
            this.TxCompra.Text = "0";
            this.TxCompra.Click += new System.EventHandler(this.TxCompra_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(1021, 40);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 36);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(880, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio de venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(725, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio de compra:";
            // 
            // TxPeso
            // 
            this.TxPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxPeso.Location = new System.Drawing.Point(205, 53);
            this.TxPeso.Name = "TxPeso";
            this.TxPeso.Size = new System.Drawing.Size(87, 26);
            this.TxPeso.TabIndex = 5;
            this.TxPeso.TextChanged += new System.EventHandler(this.TxPeso_TextChanged);
            this.TxPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxPeso_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peso: (Kg)";
            // 
            // BoxSexo
            // 
            this.BoxSexo.FormattingEnabled = true;
            this.BoxSexo.Items.AddRange(new object[] {
            "M",
            "H"});
            this.BoxSexo.Location = new System.Drawing.Point(136, 50);
            this.BoxSexo.Name = "BoxSexo";
            this.BoxSexo.Size = new System.Drawing.Size(50, 26);
            this.BoxSexo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo:";
            // 
            // BoxRaza
            // 
            this.BoxRaza.FormattingEnabled = true;
            this.BoxRaza.Items.AddRange(new object[] {
            "Brahamman Rojo",
            "Brahamman Blanco",
            "Gyr",
            "Guzera",
            ""});
            this.BoxRaza.Location = new System.Drawing.Point(9, 50);
            this.BoxRaza.Name = "BoxRaza";
            this.BoxRaza.Size = new System.Drawing.Size(121, 26);
            this.BoxRaza.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raza:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(1113, 40);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(78, 36);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ListaGanado
            // 
            this.ListaGanado.AllowUserToAddRows = false;
            this.ListaGanado.AllowUserToDeleteRows = false;
            this.ListaGanado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaGanado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaGanado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaGanado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(0)))));
            this.ListaGanado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaGanado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaGanado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaGanado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccion,
            this.IdGanado,
            this.Raza,
            this.Sexo,
            this.Peso,
            this.PesoVenta,
            this.MesesRecuperacion,
            this.PrecioCompra,
            this.PrecioVenta,
            this.FechaRegistro,
            this.Referencia,
            this.Estado,
            this.EstadoValor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaGanado.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaGanado.EnableHeadersVisualStyles = false;
            this.ListaGanado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ListaGanado.Location = new System.Drawing.Point(10, 57);
            this.ListaGanado.Name = "ListaGanado";
            this.ListaGanado.ReadOnly = true;
            this.ListaGanado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListaGanado.RowHeadersWidth = 15;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaGanado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaGanado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaGanado.Size = new System.Drawing.Size(1179, 441);
            this.ListaGanado.TabIndex = 1;
            this.ListaGanado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaGanado_CellClick);
            this.ListaGanado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaGanado_CellContentClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(1113, 621);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(1007, 621);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 30);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TxIdGanado);
            this.groupBox2.Controls.Add(this.TxIndice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Contador);
            this.groupBox2.Controls.Add(this.TxConsultar);
            this.groupBox2.Controls.Add(this.ListaGanado);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1201, 509);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de registros";
            // 
            // TxIdGanado
            // 
            this.TxIdGanado.Location = new System.Drawing.Point(672, 21);
            this.TxIdGanado.Name = "TxIdGanado";
            this.TxIdGanado.Size = new System.Drawing.Size(22, 26);
            this.TxIdGanado.TabIndex = 6;
            this.TxIdGanado.Text = "0";
            this.TxIdGanado.Visible = false;
            // 
            // TxIndice
            // 
            this.TxIndice.Location = new System.Drawing.Point(642, 21);
            this.TxIndice.Name = "TxIndice";
            this.TxIndice.Size = new System.Drawing.Size(24, 26);
            this.TxIndice.TabIndex = 5;
            this.TxIndice.Text = "-1";
            this.TxIndice.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(955, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consultar:";
            // 
            // Contador
            // 
            this.Contador.AutoSize = true;
            this.Contador.ForeColor = System.Drawing.Color.White;
            this.Contador.Location = new System.Drawing.Point(6, 33);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(172, 18);
            this.Contador.TabIndex = 3;
            this.Contador.Text = "Ganados registrados: 0";
            // 
            // TxConsultar
            // 
            this.TxConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(0)))));
            this.TxConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxConsultar.Location = new System.Drawing.Point(1039, 25);
            this.TxConsultar.Name = "TxConsultar";
            this.TxConsultar.Size = new System.Drawing.Size(150, 26);
            this.TxConsultar.TabIndex = 2;
            this.TxConsultar.TextChanged += new System.EventHandler(this.TxConsultar_TextChanged);
            // 
            // BtnSeleccion
            // 
            this.BtnSeleccion.FillWeight = 27.91878F;
            this.BtnSeleccion.HeaderText = "";
            this.BtnSeleccion.Name = "BtnSeleccion";
            this.BtnSeleccion.ReadOnly = true;
            // 
            // IdGanado
            // 
            this.IdGanado.HeaderText = "ID";
            this.IdGanado.Name = "IdGanado";
            this.IdGanado.ReadOnly = true;
            this.IdGanado.Visible = false;
            // 
            // Raza
            // 
            this.Raza.FillWeight = 107.2081F;
            this.Raza.HeaderText = "RAZA";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.FillWeight = 107.2081F;
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.FillWeight = 107.2081F;
            this.Peso.HeaderText = "PESO";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // PesoVenta
            // 
            this.PesoVenta.FillWeight = 107.2081F;
            this.PesoVenta.HeaderText = "PESO_VENTA";
            this.PesoVenta.Name = "PesoVenta";
            this.PesoVenta.ReadOnly = true;
            // 
            // MesesRecuperacion
            // 
            this.MesesRecuperacion.FillWeight = 107.2081F;
            this.MesesRecuperacion.HeaderText = "MESES_RECUPERACION";
            this.MesesRecuperacion.Name = "MesesRecuperacion";
            this.MesesRecuperacion.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.FillWeight = 107.2081F;
            this.PrecioCompra.HeaderText = "PRECIO_COMPRA";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.FillWeight = 107.2081F;
            this.PrecioVenta.HeaderText = "PRECIO_VENTA";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.FillWeight = 107.2081F;
            this.FechaRegistro.HeaderText = "FECHA_REGISTRO";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.FillWeight = 107.2081F;
            this.Referencia.HeaderText = "REFERENCIA";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADOVALOR";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // EstadoValor
            // 
            this.EstadoValor.FillWeight = 107.2081F;
            this.EstadoValor.HeaderText = "ESTADO";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            // 
            // FrmGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1221, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1237, 700);
            this.Name = "FrmGanado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGanado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGanado_FormClosing);
            this.Load += new System.EventHandler(this.FrmGanado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView ListaGanado;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Contador;
        private System.Windows.Forms.TextBox TxConsultar;
        private System.Windows.Forms.ComboBox BoxRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label TxVenta;
        private System.Windows.Forms.Label TxCompra;
        private System.Windows.Forms.ComboBox BoxMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxPesoVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxIdGanado;
        private System.Windows.Forms.TextBox TxIndice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BoxEstado;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGanado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesesRecuperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}