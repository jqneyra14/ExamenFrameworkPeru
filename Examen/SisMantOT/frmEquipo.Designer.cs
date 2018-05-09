namespace SisMantOT
{
    partial class frmEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipo));
            this.CantDisponible_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpMantenimiento = new System.Windows.Forms.TabPage();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadBase = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Estado_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantComprometida_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpListado = new System.Windows.Forms.TabPage();
            this.gbxControles = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gvEquipo = new System.Windows.Forms.DataGridView();
            this.Id_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantBase_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpListado.SuspendLayout();
            this.gbxControles.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // CantDisponible_Equipo
            // 
            this.CantDisponible_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantDisponible_Equipo.DataPropertyName = "CantDisponible_Equipo";
            this.CantDisponible_Equipo.HeaderText = "Cant. Disponible";
            this.CantDisponible_Equipo.Name = "CantDisponible_Equipo";
            this.CantDisponible_Equipo.ReadOnly = true;
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
            this.tbpMantenimiento.Controls.Add(this.txtSerie);
            this.tbpMantenimiento.Controls.Add(this.label9);
            this.tbpMantenimiento.Controls.Add(this.txtModelo);
            this.tbpMantenimiento.Controls.Add(this.label8);
            this.tbpMantenimiento.Controls.Add(this.cboMarca);
            this.tbpMantenimiento.Controls.Add(this.label7);
            this.tbpMantenimiento.Controls.Add(this.txtCantidadBase);
            this.tbpMantenimiento.Controls.Add(this.label4);
            this.tbpMantenimiento.Controls.Add(this.label3);
            this.tbpMantenimiento.Controls.Add(this.txtCodProducto);
            this.tbpMantenimiento.Controls.Add(this.label2);
            this.tbpMantenimiento.Controls.Add(this.txtDescripcion);
            this.tbpMantenimiento.Controls.Add(this.groupBox1);
            this.tbpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenimiento.Name = "tbpMantenimiento";
            this.tbpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMantenimiento.Size = new System.Drawing.Size(1303, 491);
            this.tbpMantenimiento.TabIndex = 1;
            this.tbpMantenimiento.Text = "Mantenimiento";
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(155, 135);
            this.txtSerie.MaxLength = 50;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(457, 20);
            this.txtSerie.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Serie:";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(155, 109);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(457, 20);
            this.txtModelo.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Modelo:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(155, 80);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(328, 21);
            this.cboMarca.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Marca:";
            // 
            // txtCantidadBase
            // 
            this.txtCantidadBase.Location = new System.Drawing.Point(155, 161);
            this.txtCantidadBase.Name = "txtCantidadBase";
            this.txtCantidadBase.Size = new System.Drawing.Size(132, 20);
            this.txtCantidadBase.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cantidad Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cod. Equipo";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(155, 28);
            this.txtCodProducto.MaxLength = 12;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(132, 20);
            this.txtCodProducto.TabIndex = 25;
            this.txtCodProducto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(155, 54);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(457, 20);
            this.txtDescripcion.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 60);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SisMantOT.Properties.Resources.close_window_24;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(327, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 42);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
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
            // Estado_Equipo
            // 
            this.Estado_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado_Equipo.DataPropertyName = "Estado_Equipo";
            this.Estado_Equipo.HeaderText = "Estado";
            this.Estado_Equipo.Name = "Estado_Equipo";
            this.Estado_Equipo.ReadOnly = true;
            this.Estado_Equipo.Width = 80;
            // 
            // CantComprometida_Equipo
            // 
            this.CantComprometida_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantComprometida_Equipo.DataPropertyName = "CantComprometida_Equipo";
            this.CantComprometida_Equipo.HeaderText = "Cant. Compromt.";
            this.CantComprometida_Equipo.Name = "CantComprometida_Equipo";
            this.CantComprometida_Equipo.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpListado);
            this.tabControl1.Controls.Add(this.tbpMantenimiento);
            this.tabControl1.Location = new System.Drawing.Point(-6, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 517);
            this.tabControl1.TabIndex = 21;
            // 
            // tbpListado
            // 
            this.tbpListado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbpListado.Controls.Add(this.gbxControles);
            this.tbpListado.Controls.Add(this.gbBusqueda);
            this.tbpListado.Controls.Add(this.gvEquipo);
            this.tbpListado.Controls.Add(this.btnBuscar);
            this.tbpListado.Location = new System.Drawing.Point(4, 22);
            this.tbpListado.Name = "tbpListado";
            this.tbpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListado.Size = new System.Drawing.Size(1303, 491);
            this.tbpListado.TabIndex = 0;
            this.tbpListado.Text = "Listado";
            // 
            // gbxControles
            // 
            this.gbxControles.Controls.Add(this.btnEditar);
            this.gbxControles.Controls.Add(this.btnAnular);
            this.gbxControles.Controls.Add(this.btnNuevo);
            this.gbxControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxControles.Location = new System.Drawing.Point(273, 403);
            this.gbxControles.Name = "gbxControles";
            this.gbxControles.Size = new System.Drawing.Size(784, 60);
            this.gbxControles.TabIndex = 19;
            this.gbxControles.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SisMantOT.Properties.Resources.edit_property_24;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(317, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 42);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = global::SisMantOT.Properties.Resources.close_window_24;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(466, 12);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(137, 42);
            this.btnAnular.TabIndex = 15;
            this.btnAnular.Text = "Anular/Activar";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::SisMantOT.Properties.Resources.plus_6_24;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(169, 12);
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
            this.Label1.Size = new System.Drawing.Size(75, 15);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Descripcion:";
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
            // gvEquipo
            // 
            this.gvEquipo.AllowUserToAddRows = false;
            this.gvEquipo.AllowUserToDeleteRows = false;
            this.gvEquipo.AllowUserToResizeColumns = false;
            this.gvEquipo.AllowUserToResizeRows = false;
            this.gvEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvEquipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Equipo,
            this.Descripcion_Equipo,
            this.Id_Marca,
            this.Descripcion_Marca,
            this.Serie_Equipo,
            this.Modelo_Equipo,
            this.CantBase_Equipo,
            this.CantComprometida_Equipo,
            this.CantDisponible_Equipo,
            this.Estado_Equipo});
            this.gvEquipo.Location = new System.Drawing.Point(15, 95);
            this.gvEquipo.MultiSelect = false;
            this.gvEquipo.Name = "gvEquipo";
            this.gvEquipo.ReadOnly = true;
            this.gvEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEquipo.Size = new System.Drawing.Size(1274, 302);
            this.gvEquipo.TabIndex = 13;
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
            this.Descripcion_Equipo.HeaderText = "Equipo";
            this.Descripcion_Equipo.Name = "Descripcion_Equipo";
            this.Descripcion_Equipo.ReadOnly = true;
            // 
            // Id_Marca
            // 
            this.Id_Marca.DataPropertyName = "Id_Marca";
            this.Id_Marca.HeaderText = "Id_Marca";
            this.Id_Marca.Name = "Id_Marca";
            this.Id_Marca.ReadOnly = true;
            this.Id_Marca.Visible = false;
            // 
            // Descripcion_Marca
            // 
            this.Descripcion_Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion_Marca.DataPropertyName = "Descripcion_Marca";
            this.Descripcion_Marca.HeaderText = "Marca";
            this.Descripcion_Marca.Name = "Descripcion_Marca";
            this.Descripcion_Marca.ReadOnly = true;
            // 
            // Serie_Equipo
            // 
            this.Serie_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Serie_Equipo.DataPropertyName = "Serie_Equipo";
            this.Serie_Equipo.HeaderText = "Serie";
            this.Serie_Equipo.Name = "Serie_Equipo";
            this.Serie_Equipo.ReadOnly = true;
            // 
            // Modelo_Equipo
            // 
            this.Modelo_Equipo.DataPropertyName = "Modelo_Equipo";
            this.Modelo_Equipo.HeaderText = "Modelo";
            this.Modelo_Equipo.Name = "Modelo_Equipo";
            this.Modelo_Equipo.ReadOnly = true;
            this.Modelo_Equipo.Visible = false;
            // 
            // CantBase_Equipo
            // 
            this.CantBase_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantBase_Equipo.DataPropertyName = "CantBase_Equipo";
            this.CantBase_Equipo.HeaderText = "Cant. Base";
            this.CantBase_Equipo.Name = "CantBase_Equipo";
            this.CantBase_Equipo.ReadOnly = true;
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 515);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.frmEquipo_Load);
            this.tbpMantenimiento.ResumeLayout(false);
            this.tbpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpListado.ResumeLayout(false);
            this.gbxControles.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisponible_Equipo;
        internal System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbpMantenimiento;
        internal System.Windows.Forms.TextBox txtSerie;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtModelo;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMarca;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtCantidadBase;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCodProducto;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantComprometida_Equipo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpListado;
        internal System.Windows.Forms.GroupBox gbxControles;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnAnular;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblinfo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.DataGridView gvEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantBase_Equipo;
    }
}