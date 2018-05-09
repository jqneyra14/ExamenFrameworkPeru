using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace SisMantOT
{
    public partial class frmEquipo : Form
    {
        public frmEquipo()
        {
            InitializeComponent();
        }

        brEquipo obrEquipo = new brEquipo();

        List<beEquipo> lbeEquipo;
        List<beEquipo> lbefiltro;
        private string msgError;
        private void frmEquipo_Load(object sender, EventArgs e)
        {
            this.gvEquipo.RowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            gvEquipo.AutoGenerateColumns = false;
            ListarMarca();
            ListarEquipo();
            tabControl1.TabPages.Remove(tbpMantenimiento);
        }

        public void ListarMarca()
        {
            try
            {
                brGenerales obrGenerales = new brGenerales();
                List<beMarca> lbeMarca = new List<beMarca>();
                lbeMarca = obrGenerales.ListarMarca(ref msgError);
                if (string.IsNullOrWhiteSpace(msgError))
                {
                    lbeMarca.Insert(0, new beMarca { Id_Marca = 0, Descripcion_Marca = "Seleccione" });
                    cboMarca.DataSource = lbeMarca;
                    cboMarca.DisplayMember = "Descripcion_Marca";
                    cboMarca.ValueMember = "Id_Marca";
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al listar las marcas: " + msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        public void ListarEquipo()
        {
            try
            {
                lbeEquipo = obrEquipo.ListarEquipo(ref msgError);
                lbefiltro = lbeEquipo;
                if (string.IsNullOrWhiteSpace(msgError)) gvEquipo.DataSource = lbeEquipo;
                else MessageBox.Show("Ocurrio un error al lista los equipos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lbeEquipo.Count > 0)
            {
                string filtro = txtBuscar.Text.ToLower();

                if (string.IsNullOrEmpty(txtBuscar.Text)) lbefiltro = lbeEquipo;
                else lbefiltro = lbeEquipo.FindAll(x => x.Descripcion_Equipo.ToLower().Contains(filtro));
                gvEquipo.DataSource = lbefiltro;

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(1, null);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbpMantenimiento.Text = "Registrar";

            btnGuardar.Enabled = true;
            tabControl1.TabPages.Add(tbpMantenimiento);
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            tabControl1.TabPages.Remove(tbpListado);
            txtDescripcion.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tbpMantenimiento);
            tabControl1.TabPages.Add(tbpListado);
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            txtDescripcion.Text = string.Empty;
            txtCantidadBase.Value = 0;
            btnGuardar.Enabled = false;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (gvEquipo.CurrentRow != null)
            {

                int Id_Equipo = Convert.ToInt32(gvEquipo.CurrentRow.Cells["Id_Equipo"].Value.ToString());
                string Descripcion_Equipo = gvEquipo.CurrentRow.Cells["Descripcion_Equipo"].Value.ToString();
                string Estado_Equipo = gvEquipo.CurrentRow.Cells["Estado_Equipo"].Value.ToString();
                string acion = string.Empty;
                bool estado = false;
                if (Estado_Equipo == "Activo")
                {
                    acion = "ANULAR"; estado = false;
                }
                else { acion = "ACTIVAR"; estado = true; }

                if (MessageBox.Show("¿Está seguro que desea " + acion + " el Equipo " + Descripcion_Equipo + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.No)
                {
                    bool anul = obrEquipo.CambiarEstadoEquipo(Id_Equipo, estado, ref msgError);

                    if (anul)
                        MessageBox.Show("Acción ejecutada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("Ocurrió un error al ejecutar la acción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    ListarEquipo();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gvEquipo.CurrentRow != null)
            {
                btnGuardar.Enabled = true;

                txtCodProducto.Text = gvEquipo.CurrentRow.Cells["Id_Equipo"].Value.ToString();
                txtDescripcion.Text = gvEquipo.CurrentRow.Cells["Descripcion_Equipo"].Value.ToString();
                txtCantidadBase.Value = int.Parse(gvEquipo.CurrentRow.Cells["CantBase_Equipo"].Value.ToString());
                txtModelo.Text = gvEquipo.CurrentRow.Cells["Modelo_Equipo"].Value.ToString();
                txtSerie.Text = gvEquipo.CurrentRow.Cells["Serie_Equipo"].Value.ToString();
                cboMarca.SelectedIndex = cboMarca.FindString(gvEquipo.CurrentRow.Cells["Descripcion_Marca"].Value.ToString());

                if (!string.IsNullOrEmpty(txtCodProducto.Text))
                {
                    tabControl1.TabPages.Add(tbpMantenimiento);
                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                    tabControl1.TabPages.Remove(tbpListado);
                    tbpMantenimiento.Text = "Editar";
                    txtCodProducto.Enabled = false;
                    txtDescripcion.Focus();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            msgError = string.Empty;
            try
            {
                bool result = false;
                beEquipo obeEquipo = new beEquipo();

                obeEquipo.Descripcion_Equipo = txtDescripcion.Text.Trim();
                obeEquipo.Id_Marca = int.Parse(cboMarca.SelectedValue.ToString());
                obeEquipo.Modelo_Equipo = txtModelo.Text.Trim();
                obeEquipo.Serie_Equipo = txtSerie.Text.Trim();
                obeEquipo.CantBase_Equipo = int.Parse(txtCantidadBase.Value.ToString());

                if (string.IsNullOrWhiteSpace(txtCodProducto.Text))
                {
                    result = obrEquipo.RegistrarEquipo(obeEquipo, ref msgError);
                    if (result && string.IsNullOrWhiteSpace(msgError))
                    {
                        MessageBox.Show("Equipo Registrado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        ListarEquipo();
                        btnCancelar_Click(1, null);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error: " + msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    obeEquipo.Id_Equipo = int.Parse(txtCodProducto.Text);
                    result = obrEquipo.ActualizarEquipo(obeEquipo, ref msgError);
                    if (result && string.IsNullOrWhiteSpace(msgError))
                    {
                        MessageBox.Show("Equipo Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        ListarEquipo();
                        btnCancelar_Click(1, null);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error: " + msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
