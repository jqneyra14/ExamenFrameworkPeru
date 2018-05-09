namespace SisMantOT
{
    partial class frmBusquedaEquipo
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gvEquipo = new System.Windows.Forms.DataGridView();
            this.Id_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDisponible_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipo)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::SisMantOT.Properties.Resources.active_search_48;
            this.btnBuscar.Location = new System.Drawing.Point(485, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 82);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.txtBuscar.TabIndex = 1;
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
            this.Descripcion_Marca,
            this.Serie_Equipo,
            this.Modelo_Equipo,
            this.CantDisponible_Equipo});
            this.gvEquipo.Location = new System.Drawing.Point(14, 97);
            this.gvEquipo.MultiSelect = false;
            this.gvEquipo.Name = "gvEquipo";
            this.gvEquipo.ReadOnly = true;
            this.gvEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEquipo.Size = new System.Drawing.Size(980, 302);
            this.gvEquipo.TabIndex = 23;
            this.gvEquipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEquipo_CellDoubleClick);
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
            // CantDisponible_Equipo
            // 
            this.CantDisponible_Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CantDisponible_Equipo.DataPropertyName = "CantDisponible_Equipo";
            this.CantDisponible_Equipo.HeaderText = "Cant. Disponible";
            this.CantDisponible_Equipo.Name = "CantDisponible_Equipo";
            this.CantDisponible_Equipo.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(14, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Para seleccionar el Equipo haga doble clic en la fila.";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblinfo);
            this.gbBusqueda.Controls.Add(this.Label1);
            this.gbBusqueda.Controls.Add(this.txtBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(14, 27);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(454, 64);
            this.gbBusqueda.TabIndex = 24;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // frmBusquedaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1009, 435);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvEquipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBusquedaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda de Equipo";
            this.Load += new System.EventHandler(this.frmBusquedaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipo)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblinfo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.DataGridView gvEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisponible_Equipo;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox gbBusqueda;
    }
}