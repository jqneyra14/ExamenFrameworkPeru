using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Globalization;

namespace SisMantOT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void tiempo_hora()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(1 * 1000);
                    CultureInfo ci = CultureInfo.InvariantCulture;
                    lblhora.Text = DateTime.Now.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Juan Quiroz Neira";

            Thread time_actual;

            time_actual = new Thread(this.tiempo_hora);
            time_actual.IsBackground = true;
            time_actual.Start();
            Computer myComputer = new Computer();
            this.Size = myComputer.Screen.WorkingArea.Size;
            this.Location = new System.Drawing.Point(0, 0);

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipo newMDIChild = new frmEquipo();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroOrdenTrabajo newMDIChild = new frmRegistroOrdenTrabajo();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
