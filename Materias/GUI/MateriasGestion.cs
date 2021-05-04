using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materias.GUI
{
    public partial class MateriasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_MATERIAS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Nombre LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgMaterias.AutoGenerateColumns = false;
            dtgMaterias.DataSource = _DATOS;
            lblRegistros.Text = dtgMaterias.Rows.Count.ToString() + " Registros Encontrados";
        }

        public MateriasGestion()
        {
            InitializeComponent();
        }

        private void MateriasGestion_Load(object sender, EventArgs e)
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
                MateriasEdicion f = new MateriasEdicion();
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
                    MateriasEdicion f = new MateriasEdicion();
                    f.txbIDMateria.Text = dtgMaterias.CurrentRow.Cells["IDMateria"].Value.ToString();
                    f.txbNombre.Text = dtgMaterias.CurrentRow.Cells["Nombre"].Value.ToString();
                    f.txbDescripcion.Text = dtgMaterias.CurrentRow.Cells["Descripcion"].Value.ToString();
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
                    CLS.Materias oEntidad = new CLS.Materias();
                    oEntidad.IDMateria = dtgMaterias.CurrentRow.Cells["IDMateria"].Value.ToString();

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
