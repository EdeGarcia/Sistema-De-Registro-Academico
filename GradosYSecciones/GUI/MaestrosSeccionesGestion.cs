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
    public partial class MaestrosSeccionesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.MAESTRO_POR_SECCION();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Maestro LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgMaestrosSecciones.AutoGenerateColumns = false;
            dtgMaestrosSecciones.DataSource = _DATOS;
            lblRegistros.Text = dtgMaestrosSecciones.Rows.Count.ToString() + " Secciones Asignadas";
        }

        public MaestrosSeccionesGestion()
        {
            InitializeComponent();
        }

        private void MaestrosSeccionesGestion_Load(object sender, EventArgs e)
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
                MaestrosSeccionesEdicion f = new MaestrosSeccionesEdicion();
                f.ShowDialog();
                Cargar();
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
                    CLS.Maestros_Secciones oEntidad = new CLS.Maestros_Secciones();
                    oEntidad.IDMaestro_Seccion = dtgMaestrosSecciones.CurrentRow.Cells["IDMaestro_Seccion"].Value.ToString();

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
