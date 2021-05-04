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
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

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

        private void gestionarSeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GradosYSecciones.GUI.SeccionesGestion f = new GradosYSecciones.GUI.SeccionesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }

        private void gestiónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = oSesion.Usuario;
        }

        private void gestiónDeResponsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ResponsablesYEstudiantes.GUI.ResponsablesGestion f = new ResponsablesYEstudiantes.GUI.ResponsablesGestion();    
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }

        private void gestiónDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ResponsablesYEstudiantes.GUI.EstudiantesGestion f = new ResponsablesYEstudiantes.GUI.EstudiantesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }

        private void gestiónDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Materias.GUI.MateriasGestion f = new Materias.GUI.MateriasGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }

        }

        private void asignarMateriasAGradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Materias.GUI.MateriasPorGradoGestion f = new Materias.GUI.MateriasPorGradoGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch
            {

            }
        }
    }
}
