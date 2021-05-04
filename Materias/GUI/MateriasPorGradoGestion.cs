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
    public partial class MateriasPorGradoGestion : Form
    {
        private void CargarGrados()
        {
            DataTable Grados = new DataTable();

            try
            {
                Grados = CacheManager.CLS.Cache.TODOS_LOS_GRADOS();
                cbbGrados.DataSource = Grados;
                cbbGrados.DisplayMember = "Descripcion";
                cbbGrados.ValueMember = "IDGrado";
                //

            }
            catch
            {
                Grados = new DataTable();
            }
        }

        private void CargarMateriasPorGrado()
        {
            DataTable MateriasPorGrado = new DataTable();

            try
            {
                MateriasPorGrado = CacheManager.CLS.Cache.MATERIAS_DE_UN_GRADO(cbbGrados.SelectedValue.ToString());
                dtgMateriasGrado.AutoGenerateColumns = false;
                dtgMateriasGrado.DataSource = MateriasPorGrado;
                lblMateriasAsignadas.Text = dtgMateriasGrado.Rows.Count.ToString() + " Materias Asignadas";
            }
            catch
            {
                MateriasPorGrado = new DataTable();
            }
        }

        public MateriasPorGradoGestion()
        {
            InitializeComponent();
        }

        private void MateriasPorGradoGestion_Load(object sender, EventArgs e)
        {
            CargarGrados();
        }

        private void cbbGrados_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarMateriasPorGrado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriasListado f = new MateriasListado(cbbGrados.SelectedValue.ToString());
                f.ShowDialog();
                CargarMateriasPorGrado();
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
                    CLS.Grados_Materias oEntidad = new CLS.Grados_Materias();
                    oEntidad.IDGrado_Materia = dtgMateriasGrado.CurrentRow.Cells["IDGrado_Materia"].Value.ToString();

                    if (oEntidad.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMateriasPorGrado();
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
