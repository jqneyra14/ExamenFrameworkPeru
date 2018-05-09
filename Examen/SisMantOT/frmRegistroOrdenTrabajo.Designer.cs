namespace SisMantOT
{
    partial class frmRegistroOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroOrdenTrabajo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteDetalle = new System.Windows.Forms.Button();
            this.btnEditDetalle = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadDetalle = new System.Windows.Forms.TextBox();
            this.txtDescEquipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDetalleOT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.CantEquipo_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.btnProcesarTrabajo = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gvOT = new System.Windows.Forms.DataGridView();
            this.Id_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.gvDetalleOT = new System.Windows.Forms.DataGridView();
            this.Id_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpListado.SuspendLayout();
            this.gbxControles.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOT)).BeginInit();
            this.tbpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleOT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteDetalle);
            this.panel2.Controls.Add(this.btnEditDetalle);
            this.panel2.Location = new System.Drawing.Point(948, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 164);
            this.panel2.TabIndex = 29;
            // 
            // btnDeleteDetalle
            // 
            this.btnDeleteDetalle.Image = global::SisMantOT.Properties.Resources.delete_24;
            this.btnDeleteDetalle.Location = new System.Drawing.Point(15, 83);
            this.btnDeleteDetalle.Name = "btnDeleteDetalle";
            this.btnDeleteDetalle.Size = new System.Drawing.Size(59, 38);
            this.btnDeleteDetalle.TabIndex = 15;
            this.btnDeleteDetalle.UseVisualStyleBackColor = true;
            this.btnDeleteDetalle.Click += new System.EventHandler(this.btnDeleteDetalle_Click);
            // 
            // btnEditDetalle
            // 
            this.btnEditDetalle.Image = global::SisMantOT.Properties.Resources.edit_property_24;
            this.btnEditDetalle.Location = new System.Drawing.Point(15, 25);
            this.btnEditDetalle.Name = "btnEditDetalle";
            this.btnEditDetalle.Size = new System.Drawing.Size(59, 39);
            this.btnEditDetalle.TabIndex = 14;
            this.btnEditDetalle.UseVisualStyleBackColor = true;
            this.btnEditDetalle.Click += new System.EventHandler(this.btnEditDetalle_Click);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackColor = System.Drawing.Color.Ivory;
            this.pnlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetalle.Controls.Add(this.txtDisponible);
            this.pnlDetalle.Controls.Add(this.label8);
            this.pnlDetalle.Controls.Add(this.btnBuscarEquipo);
            this.pnlDetalle.Controls.Add(this.btnLimpiar);
            this.pnlDetalle.Controls.Add(this.btnAdd);
            this.pnlDetalle.Controls.Add(this.label6);
            this.pnlDetalle.Controls.Add(this.txtCantidadDetalle);
            this.pnlDetalle.Controls.Add(this.txtDescEquipo);
            this.pnlDetalle.Controls.Add(this.label5);
            this.pnlDetalle.Location = new System.Drawing.Point(10, 150);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(932, 68);
            this.pnlDetalle.TabIndex = 28;
            // 
            // txtDisponible
            // 
            this.txtDisponible.Location = new System.Drawing.Point(576, 24);
            this.txtDisponible.MaxLength = 12;
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.ReadOnly = true;
            this.txtDisponible.Size = new System.Drawing.Size(84, 20);
            this.txtDisponible.TabIndex = 33;
            this.txtDisponible.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Disponible:";
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.Image = global::SisMantOT.Properties.Resources.search_3_24;
            this.btnBuscarEquipo.Location = new System.Drawing.Point(459, 14);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(46, 39);
            this.btnBuscarEquipo.TabIndex = 31;
            this.btnBuscarEquipo.UseVisualStyleBackColor = true;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::SisMantOT.Properties.Resources.minus_2_24;
            this.btnLimpiar.Location = new System.Drawing.Point(874, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 39);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SisMantOT.Properties.Resources.plus_6_24green;
            this.btnAdd.Location = new System.Drawing.Point(822, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 39);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cantidad:";
            // 
            // txtCantidadDetalle
            // 
            this.txtCantidadDetalle.Location = new System.Drawing.Point(732, 24);
            this.txtCantidadDetalle.MaxLength = 12;
            this.txtCantidadDetalle.Name = "txtCantidadDetalle";
            this.txtCantidadDetalle.Size = new System.Drawing.Size(84, 20);
            this.txtCantidadDetalle.TabIndex = 27;
            this.txtCantidadDetalle.TabStop = false;
            this.txtCantidadDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDetalle_KeyPress);
            // 
            // txtDescEquipo
            // 
            this.txtDescEquipo.Location = new System.Drawing.Point(50, 24);
            this.txtDescEquipo.MaxLength = 12;
            this.txtDescEquipo.Name = "txtDescEquipo";
            this.txtDescEquipo.ReadOnly = true;
            this.txtDescEquipo.Size = new System.Drawing.Size(395, 20);
            this.txtDescEquipo.TabIndex = 26;
            this.txtDescEquipo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Equipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDetalleOT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNumOT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 116);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cabecera OT";
            // 
            // txtDetalleOT
            // 
            this.txtDetalleOT.Location = new System.Drawing.Point(155, 64);
            this.txtDetalleOT.MaxLength = 100;
            this.txtDetalleOT.Name = "txtDetalleOT";
            this.txtDetalleOT.Size = new System.Drawing.Size(766, 20);
            this.txtDetalleOT.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descripcion Trabajo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(633, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha Programada:";
            // 
            // txtNumOT
            // 
            this.txtNumOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOT.ForeColor = System.Drawing.Color.Red;
            this.txtNumOT.Location = new System.Drawing.Point(155, 12);
            this.txtNumOT.MaxLength = 12;
            this.txtNumOT.Multiline = true;
            this.txtNumOT.Name = "txtNumOT";
            this.txtNumOT.ReadOnly = true;
            this.txtNumOT.Size = new System.Drawing.Size(366, 46);
            this.txtNumOT.TabIndex = 25;
            this.txtNumOT.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Numero OT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(185, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 60);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SisMantOT.Properties.Resources.arrow_121_241;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(327, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 42);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::SisMantOT.Properties.Resources.save_24;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(126, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 42);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CantEquipo_OT
            // 
            this.CantEquipo_OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantEquipo_OT.DataPropertyName = "CantEquipo_OT";
            this.CantEquipo_OT.HeaderText = "Cantidad Solicitada";
            this.CantEquipo_OT.Name = "CantEquipo_OT";
            this.CantEquipo_OT.ReadOnly = true;
            this.CantEquipo_OT.Width = 150;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpListado);
            this.tabControl1.Controls.Add(this.tbpMantenimiento);
            this.tabControl1.Location = new System.Drawing.Point(-4, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 615);
            this.tabControl1.TabIndex = 22;
            // 
            // tbpListado
            // 
            this.tbpListado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbpListado.Controls.Add(this.label7);
            this.tbpListado.Controls.Add(this.gbxControles);
            this.tbpListado.Controls.Add(this.gbBusqueda);
            this.tbpListado.Controls.Add(this.gvOT);
            this.tbpListado.Controls.Add(this.btnBuscar);
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListado.Size = new System.Drawing.Size(1074, 589);
            this.tbpListado.TabIndex = 0;
            this.tbpListado.Text = "Listado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(277, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(510, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Al termino del trabajo seleccionar la opción <<Procesar Trabajo>> para culiminar " +
    "y liberar stock de equipos.\r\n";
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.btnProcesarTrabajo);
            this.gbxControles.Controls.Add(this.btnNuevo);
            this.gbxControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxControles.Location = new System.Drawing.Point(322, 501);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(405, 60);
            this.gbxControles.TabIndex = 19;
            this.gbxControles.TabStop = false;
            // 
            // btnProcesarTrabajo
            // 
            this.btnProcesarTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarTrabajo.Image = global::SisMantOT.Properties.Resources.services_24;
            this.btnProcesarTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesarTrabajo.Location = new System.Drawing.Point(210, 12);
            this.btnProcesarTrabajo.Name = "btnProcesarTrabajo";
            this.btnProcesarTrabajo.Size = new System.Drawing.Size(175, 42);
            this.btnProcesarTrabajo.TabIndex = 15;
            this.btnProcesarTrabajo.Text = "Procesar Trabajo";
            this.btnProcesarTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesarTrabajo.UseVisualStyleBackColor = true;
            this.btnProcesarTrabajo.Click += new System.EventHandler(this.btnProcesarTrabajo_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::SisMantOT.Properties.Resources.plus_6_24;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(31, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 42);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblinfo);
            this.gbBusqueda.Controls.Add(this.Label1);
            this.gbBusqueda.Controls.Add(this.txtBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(15, 25);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(454, 64);
            this.gbBusqueda.TabIndex = 17;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.Red;
            this.lblinfo.Location = new System.Drawing.Point(124, 46);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(155, 13);
            this.lblinfo.TabIndex = 6;
            this.lblinfo.Text = "Ingresar texto y presionar enter.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 15);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Numero OT";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(126, 22);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(311, 21);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // gvOT
            // 
            this.gvOT.AllowUserToAddRows = false;
            this.gvOT.AllowUserToDeleteRows = false;
            this.gvOT.AllowUserToResizeColumns = false;
            this.gvOT.AllowUserToResizeRows = false;
            this.gvOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_OT,
            this.Numero_OT,
            this.Descripcion_OT,
            this.Fecha_OT,
            this.Estado_OT});
            this.gvOT.Location = new System.Drawing.Point(15, 95);
            this.gvOT.MultiSelect = false;
            this.gvOT.Name = "gvOT";
            this.gvOT.ReadOnly = true;
            this.gvOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOT.Size = new System.Drawing.Size(1026, 402);
            this.gvOT.TabIndex = 13;
            // 
            // Id_OT
            // 
            this.Id_OT.DataPropertyName = "Id_OT";
            this.Id_OT.HeaderText = "Id_OT";
            this.Id_OT.Name = "Id_OT";
            this.Id_OT.ReadOnly = true;
            this.Id_OT.Visible = false;
            // 
            // Numero_OT
            // 
            this.Numero_OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numero_OT.DataPropertyName = "Numero_OT";
            this.Numero_OT.HeaderText = "Numero OT";
            this.Numero_OT.Name = "Numero_OT";
            this.Numero_OT.ReadOnly = true;
            this.Numero_OT.Width = 150;
            // 
            // Descripcion_OT
            // 
            this.Descripcion_OT.DataPropertyName = "Descripcion_OT";
            this.Descripcion_OT.HeaderText = "Descripcion Trabajo";
            this.Descripcion_OT.Name = "Descripcion_OT";
            this.Descripcion_OT.ReadOnly = true;
            // 
            // Fecha_OT
            // 
            this.Fecha_OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha_OT.DataPropertyName = "Fecha_OT";
            this.Fecha_OT.HeaderText = "Fecha de Trabajo";
            this.Fecha_OT.Name = "Fecha_OT";
            this.Fecha_OT.ReadOnly = true;
            this.Fecha_OT.Width = 150;
            // 
            // Estado_OT
            // 
            this.Estado_OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado_OT.DataPropertyName = "Estado_OT";
            this.Estado_OT.HeaderText = "Estado";
            this.Estado_OT.Name = "Estado_OT";
            this.Estado_OT.ReadOnly = true;
            this.Estado_OT.Width = 150;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::SisMantOT.Properties.Resources.active_search_48;
            this.btnBuscar.Location = new System.Drawing.Point(487, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 82);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbpMantenimiento
            // 
            this.tbpMantenimiento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbpMantenimiento.Controls.Add(this.gvDetalleOT);
            this.tbpMantenimiento.Controls.Add(this.panel2);
            this.tbpMantenimiento.Controls.Add(this.pnlDetalle);
            this.tbpMantenimiento.Controls.Add(this.groupBox2);
            this.tbpMantenimiento.Controls.Add(this.groupBox1);
            this.tbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenimiento.Name = "tbpMantenimiento";
            this.tbpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMantenimiento.Size = new System.Drawing.Size(1074, 589);
            this.tbpMantenimiento.TabIndex = 1;
            this.tbpMantenimiento.Text = "Mantenimiento";
            // 
            // gvDetalleOT
            // 
            this.gvDetalleOT.AllowUserToAddRows = false;
            this.gvDetalleOT.AllowUserToDeleteRows = false;
            this.gvDetalleOT.AllowUserToResizeColumns = false;
            this.gvDetalleOT.AllowUserToResizeRows = false;
            this.gvDetalleOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDetalleOT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvDetalleOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalleOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Equipo,
            this.Descripcion_Equipo,
            this.Descripcion_Marca,
            this.CantEquipo_OT});
            this.gvDetalleOT.Location = new System.Drawing.Point(10, 235);
            this.gvDetalleOT.MultiSelect = false;
            this.gvDetalleOT.Name = "gvDetalleOT";
            this.gvDetalleOT.ReadOnly = true;
            this.gvDetalleOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetalleOT.Size = new System.Drawing.Size(932, 235);
            this.gvDetalleOT.TabIndex = 30;
            // 
            // Id_Equipo
            // 
            this.Id_Equipo.DataPropertyName = "Id_Equipo";
            this.Id_Equipo.HeaderText = "Id_Equipo";
            this.Id_Equipo.Name = "Id_Equipo";
            this.Id_Equipo.ReadOnly = true;
            this.Id_Equipo.Visible = false;
            // 
            // Descripcion_Equipo
            // 
            this.Descripcion_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion_Equipo.DataPropertyName = "Descripcion_Equipo";
            this.Descripcion_Equipo.HeaderText = "Descripcion del Equipo";
            this.Descripcion_Equipo.Name = "Descripcion_Equipo";
            this.Descripcion_Equipo.ReadOnly = true;
            // 
            // Descripcion_Marca
            // 
            this.Descripcion_Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descripcion_Marca.DataPropertyName = "Descripcion_Marca";
            this.Descripcion_Marca.HeaderText = "Marca";
            this.Descripcion_Marca.Name = "Descripcion_Marca";
            this.Descripcion_Marca.ReadOnly = true;
            this.Descripcion_Marca.Width = 300;
            // 
            // frmRegistroOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 606);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistroOrdenTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Trabajo";
            this.Load += new System.EventHandler(this.frmRegistroOrdenTrabajo_Load);
            this.panel2.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpListado.ResumeLayout(false);
            this.tbpListado.PerformLayout();
            this.gbxControles.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOT)).EndInit();
            this.tbpMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleOT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteDetalle;
        private System.Windows.Forms.Button btnEditDetalle;
        private System.Windows.Forms.Panel pnlDetalle;
        internal System.Windows.Forms.TextBox txtDisponible;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtCantidadDetalle;
        internal System.Windows.Forms.TextBox txtDescEquipo;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDetalleOT;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtNumOT;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantEquipo_OT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpListado;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox gbxControles;
        internal System.Windows.Forms.Button btnProcesarTrabajo;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblinfo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.DataGridView gvOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_OT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_OT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_OT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_OT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_OT;
        internal System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        internal System.Windows.Forms.DataGridView gvDetalleOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Marca;
    }
}