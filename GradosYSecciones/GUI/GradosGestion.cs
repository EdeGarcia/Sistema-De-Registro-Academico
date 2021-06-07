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
    public partial class GradosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        //Permiso
        SesionManager.CLS.Sesion oSesion = SesionManager.CLS.Sesion.Instancia;

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_GRADOS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if(txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Descripcion LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgGrados.AutoGenerateColumns = false;
            dtgGrados.DataSource = _DATOS;
            lblRegistros.Text = dtgGrados.Rows.Count.ToString() + " Registros Encontrados";
        }

        public GradosGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (oSesion.ComprobarPermiso(12))
                {
                    GradosEdicion f = new GradosEdicion();
                    f.ShowDialog();
                    Cargar();
                }
            }
            catch
            {

            }
        }

        private void GradosGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermiso(12))
            {
                try
                {
                    if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GradosEdicion f = new GradosEdicion();
                        f.txbIDGrado.Text = dtgGrados.CurrentRow.Cells["IDGrado"].Value.ToString();
                        f.txbDescripcion.Text = dtgGrados.CurrentRow.Cells["Descripcion"].Value.ToString();
                        f.ShowDialog();
                        Cargar();
                    }
                }
                catch
                {

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (oSesion.ComprobarPermiso(12))
            {
                try
                {
                    if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLS.Grados oEntidad = new CLS.Grados();
                        oEntidad.IDGrado = dtgGrados.CurrentRow.Cells["IDGrado"].Value.ToString();

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
}
