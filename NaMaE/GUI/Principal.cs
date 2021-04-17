using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaMaE.GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void rolesDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.RolesGestion f = new General.GUI.RolesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.PermisosEdicion f = new General.GUI.PermisosEdicion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }

        private void gestionarGradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GradosYSecciones.GUI.GradosGestion f = new GradosYSecciones.GUI.GradosGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }
    }
}
