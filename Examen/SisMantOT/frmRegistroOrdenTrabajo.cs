using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace SisMantOT
{
    public partial class frmRegistroOrdenTrabajo : Form
    {
        public frmRegistroOrdenTrabajo()
        {
            InitializeComponent();
        }

        private int IdEquipo = 0;
        string msgError = string.Empty;
        string parametro = "R";
        private string strMarca = string.Empty;
        brOrdenTrabajo obrOrdenTrabajo = new brOrdenTrabajo();
        private List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle = new List<beOrdenTrabajoDetalle>();
        List<beOrdenTrabajo> lbeOrdenTrabajo = new List<beOrdenTrabajo>();
        List<beOrdenTrabajo> lbeFiltro = new List<beOrdenTrabajo>();
        private List<beEquipo> lbeEquipo = new List<beEquipo>();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbpMantenimiento.Text = "Registrar Orden de Trabajo";
            btnGuardar.Enabled = true;
            tabControl1.TabPages.Add(tbpMantenimiento);
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            tabControl1.TabPages.Remove(tbpListado);
            txtDetalleOT.Focus();
        }

        private void frmRegistroOrdenTrabajo_Load(object sender, EventArgs e)
        {
            gvOT.AutoGenerateColumns = false;
            gvDetalleOT.AutoGenerateColumns = false;
            tabControl1.TabPages.Remove(tbpMantenimiento);
            ListarOrdenesTrabajo();
        }
        public void ListarOrdenesTrabajo()
        {
            lbeOrdenTrabajo = obrOrdenTrabajo.ListarOrdenTrabajo(ref msgError);
            lbeFiltro = lbeOrdenTrabajo;
            if (string.IsNullOrWhiteSpace(msgError)) gvOT.DataSource = lbeOrdenTrabajo;
            else
                MessageBox.Show("Ourrió un error: " + msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        private void txtCantidadDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(1, null);
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
        public void limpiarControlesBusqueda()
        {
            txtDescEquipo.Text = string.Empty;
            txtCantidadDetalle.Text = string.Empty;
            txtDisponible.Text = string.Empty;
            IdEquipo = 0;

        }
        public bool validarExiste(int id_equipo)
        {
            bool resultado = lbeOrdenTrabajoDetalle.Exists(x => x.Id_Equipo == id_equipo);
            return resultado;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescEquipo.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtCantidadDetalle.Text))
                {
                    beOrdenTrabajoDetalle obeOrdenTrabajoDetalle = new beOrdenTrabajoDetalle();
                    if (parametro == "R")
                    {
                        if (validarExiste(IdEquipo))
                        {
                            MessageBox.Show("El equipo ingresado ya se encuentra en el detalle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            obeOrdenTrabajoDetalle.Id_Equipo = IdEquipo;
                            obeOrdenTrabajoDetalle.Descripcion_Equipo = txtDescEquipo.Text;
                            obeOrdenTrabajoDetalle.Descripcion_Marca = strMarca;
                            obeOrdenTrabajoDetalle.CantEquipo_OT = int.Parse(txtCantidadDetalle.Text);
                            lbeOrdenTrabajoDetalle.Add(obeOrdenTrabajoDetalle);
                            gvDetalleOT.DataSource = null;
                            gvDetalleOT.DataSource = lbeOrdenTrabajoDetalle;
                            gvDetalleOT.Refresh();
                        }
                    }
                    else
                    {
                        int i = lbeOrdenTrabajoDetalle.FindIndex(x => x.Id_Equipo == IdEquipo);
                        lbeOrdenTrabajoDetalle[i].CantEquipo_OT = int.Parse(txtCantidadDetalle.Text);
                        gvDetalleOT.DataSource = null;
                    }
                    gvDetalleOT.DataSource = lbeOrdenTrabajoDetalle;
                    limpiarControlesBusqueda();
                    parametro = "R";
                }
                else
                {
                    MessageBox.Show("Ingrese cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    btnBuscarEquipo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un equipo para agregar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lbeOrdenTrabajo.Count > 0)
            {
                string filtro = txtBuscar.Text.ToLower();
                if (string.IsNullOrEmpty(txtBuscar.Text)) lbeFiltro = lbeOrdenTrabajo;
                else lbeFiltro = lbeOrdenTrabajo.FindAll(x => x.Numero_OT.ToLower().Contains(filtro));
                gvOT.DataSource = lbeFiltro;

            }
        }
        public void ListarEquipo()
        {
            try
            {
                brEquipo obrEquipo = new brEquipo();
                lbeEquipo = obrEquipo.ListarEquipo(ref msgError);

                if (string.IsNullOrWhiteSpace(msgError)) gvOT.DataSource = lbeEquipo;
                else MessageBox.Show("Ocurrio un error al lista los equipos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            ListarEquipo();
            using (frmBusquedaEquipo frm = new frmBusquedaEquipo())
            {
                frm.lbeEquipo = lbeEquipo;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtDisponible.Text = frm.strCantDisponible_Equipo;
                    txtDescEquipo.Text = frm.strDescripcion_Equipo;
                    IdEquipo = int.Parse(frm.strId_Equipo);
                    strMarca = frm.strDescripcion_Marca;
                    txtCantidadDetalle.Focus();
                }
            }
        }

        private void btnEditDetalle_Click(object sender, EventArgs e)
        {
            if (gvDetalleOT.CurrentRow != null)
            {
                int srtIdEquipo = int.Parse(gvDetalleOT.CurrentRow.Cells["Id_Equipo"].Value.ToString());
                string strCantEquipo_OT = gvDetalleOT.CurrentRow.Cells["CantEquipo_OT"].Value.ToString();
                if (!string.IsNullOrEmpty(strCantEquipo_OT))
                {
                    int i = lbeEquipo.FindIndex(x => x.Id_Equipo == srtIdEquipo);
                    IdEquipo = lbeEquipo[i].Id_Equipo;
                    txtDescEquipo.Text = lbeEquipo[i].Descripcion_Equipo;
                    strMarca = lbeEquipo[i].Descripcion_Marca.ToString();
                    txtDisponible.Text = lbeEquipo[i].CantDisponible_Equipo.ToString();
                    txtCantidadDetalle.Text = strCantEquipo_OT;
                    parametro = "E";
                    txtCantidadDetalle.Focus();

                }
            }
        }

        private void btnDeleteDetalle_Click(object sender, EventArgs e)
        {
            if (gvDetalleOT.CurrentRow != null)
            {
                int srtIdEquipo = int.Parse(gvDetalleOT.CurrentRow.Cells["Id_Equipo"].Value.ToString());
                if (srtIdEquipo > 0)
                {
                    lbeOrdenTrabajoDetalle.RemoveAll(x => x.Id_Equipo == srtIdEquipo);
                    gvDetalleOT.DataSource = null;
                    gvDetalleOT.DataSource = lbeOrdenTrabajoDetalle;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControlesBusqueda();
            parametro = "R";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tbpMantenimiento);
            tabControl1.TabPages.Add(tbpListado);
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            limpiarControlesBusqueda();
            btnGuardar.Enabled = false;
            txtBuscar.Focus();
            ListarOrdenesTrabajo();
            gvDetalleOT.DataSource = null;
            gvDetalleOT.Refresh();
            txtNumOT.Text = string.Empty;
            IdEquipo = 0;
            txtDetalleOT.Text = string.Empty;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(1, null);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbeOrdenTrabajoDetalle.Count > 0)
                {
                    if (!string.IsNullOrWhiteSpace(txtDetalleOT.Text))
                    {
                        beOrdenTrabajo obeOrdenTrabajo = new beOrdenTrabajo();

                        obeOrdenTrabajo.Descripcion_OT = txtDetalleOT.Text.Trim();
                        obeOrdenTrabajo.Estado_OT = "Programado";
                        string Numero_OT = string.Empty;
                        bool registro = obrOrdenTrabajo.RegistrarOT(obeOrdenTrabajo, lbeOrdenTrabajoDetalle, ref Numero_OT, ref msgError);
                        if (registro || string.IsNullOrWhiteSpace(msgError))
                        {
                            txtNumOT.Text = Numero_OT;
                            btnGuardar.Enabled = false;
                            MessageBox.Show("Se registró correctamente la orden de trabajo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            ListarOrdenesTrabajo();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error: " + msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa una descripción del trabajo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                        txtDetalleOT.Focus();
                    }
                  
                }
                else
                {
                    MessageBox.Show("Ingrese equipos al detalle del trabajo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnProcesarTrabajo_Click(object sender, EventArgs e)
        {
            if (gvOT.CurrentRow != null)
            {
                if (MessageBox.Show("¿Está seguro que desea cambiar estado a Trabajado y liberar stock de Equipos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.No)
                {
                    List<beOrdenTrabajoDetalle> ldetalleEquipos = new List<beOrdenTrabajoDetalle>();
                    beOrdenTrabajo obeOrdenTrabajo = new beOrdenTrabajo();
                    obeOrdenTrabajo.Estado_OT = "Trabajado";
                    obeOrdenTrabajo.Id_OT = int.Parse(gvOT.CurrentRow.Cells["Id_OT"].Value.ToString());

                    ldetalleEquipos = obrOrdenTrabajo.ListarDetalleOT(obeOrdenTrabajo.Id_OT, ref msgError);
                    if (string.IsNullOrWhiteSpace(msgError))
                    {
                        bool result = obrOrdenTrabajo.CambiarEstadoOT(obeOrdenTrabajo, ldetalleEquipos, ref msgError);
                        if (result || string.IsNullOrWhiteSpace(msgError))
                        {
                            MessageBox.Show("Se cambió correctamente el estado de la Orden de Trabajo y se liberó el stock de Equipos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            ListarOrdenesTrabajo();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error cambiar el estado: " + msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al obtener el detalle de la OT: " + msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
    }
}
