using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradosYSecciones.GUI
{
    public partial class SeccionesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_SECCIONES();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Grado LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgSecciones.AutoGenerateColumns = false;
            dtgSecciones.DataSource = _DATOS;
            lblRegistros.Text = dtgSecciones.Rows.Count.ToString() + " Registros Encontrados";
        }

        public SeccionesGestion()
        {
            InitializeComponent();
        }

        private void SeccionesGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SeccionesEdicion f = new SeccionesEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SeccionesEdicion f = new SeccionesEdicion();
                    f.txbIDSeccion.Text = dtgSecciones.CurrentRow.Cells["ID"].Value.ToString();
                    f.txbDescripcion.Text = dtgSecciones.CurrentRow.Cells["Seccion"].Value.ToString();
                    f.cbbTurno.Text = dtgSecciones.CurrentRow.Cells["Turno"].Value.ToString();
                    f.txbAula.Text = dtgSecciones.CurrentRow.Cells["Aula"].Value.ToString();
                    f.txbCupo.Text = dtgSecciones.CurrentRow.Cells["Cupo"].Value.ToString();
                    //f.cbbGrados.DisplayMember = dtgSecciones.CurrentRow.Cells["Grado"].Value.ToString();
                    f.ShowDialog();
                    Cargar();
                }
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Secciones oEntidad = new CLS.Secciones();
                    oEntidad.IDSeccion = dtgSecciones.CurrentRow.Cells["ID"].Value.ToString();

                    if (oEntidad.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
