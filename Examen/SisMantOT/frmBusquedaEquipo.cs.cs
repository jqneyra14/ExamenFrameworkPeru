using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
namespace SisMantOT
{
    public partial class frmBusquedaEquipo : Form
    {
        public frmBusquedaEquipo()
        {
            InitializeComponent();
        }

        public string strId_Equipo = string.Empty;
        public string strDescripcion_Equipo = string.Empty;
        public string strCantDisponible_Equipo = string.Empty;
        public string strDescripcion_Marca = string.Empty;
        brEquipo obrEquipo = new brEquipo();

        public List<beEquipo> lbeEquipo;
        List<beEquipo> lbefiltro;
        private string msgError;
        private void frmBusquedaEquipo_Load(object sender, EventArgs e)
        {
            gvEquipo.AutoGenerateColumns = false;
            ListarEquipo();
        }

        public void ListarEquipo()
        {
            gvEquipo.DataSource = lbeEquipo;
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

        private void gvEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvEquipo.CurrentRow != null)
            {
                strId_Equipo = gvEquipo.CurrentRow.Cells["Id_Equipo"].Value.ToString();
                strDescripcion_Equipo = gvEquipo.CurrentRow.Cells["Descripcion_Equipo"].Value.ToString();
                strCantDisponible_Equipo = gvEquipo.CurrentRow.Cells["CantDisponible_Equipo"].Value.ToString();
                strDescripcion_Marca = gvEquipo.CurrentRow.Cells["Descripcion_Marca"].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(1, null);
            }
        }
    }
}
