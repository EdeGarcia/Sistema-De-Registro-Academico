using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriculas.GUI
{
    public partial class MatriculasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_MATRICULAS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Estudiante LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgMatriculas.AutoGenerateColumns = false;
            dtgMatriculas.DataSource = _DATOS;
            lblMatriculas.Text = dtgMatriculas.Rows.Count.ToString() + " Registros Encontrados";
        }

        public MatriculasGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                MatriculasEdicion f = new MatriculasEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch
            {

            }
        }

        private void MatriculasGestion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MatriculasEdicion f = new MatriculasEdicion();
                    f.txbIDMatricula.Text = dtgMatriculas.CurrentRow.Cells["IDMatricula"].Value.ToString();
                    f.txbIDEstudiante.Text = dtgMatriculas.CurrentRow.Cells["IDEstudiante"].Value.ToString();
                    f.txbEstudiante.Text = dtgMatriculas.CurrentRow.Cells["Estudiante"].Value.ToString();
                    //f.cbbGrados.Text = dtgMatriculas.CurrentRow.Cells["Grado"].Value.ToString();
                    //f.cbbSecciones.Text = dtgMatriculas.CurrentRow.Cells["Secciones"].Value.ToString();
                    //f.txbTurno.Text = dtgMatriculas.CurrentRow.Cells["Turno"].Value.ToString();
                    //f.txbCupo.Text = dtgMatriculas.CurrentRow.Cells["Cupo"].Value.ToString();
                    //f.dtpFechaMatricula.Text = dtgMatriculas.CurrentRow.Cells["FechaMatricula"].Value.ToString();
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
                    CLS.Matriculas oEntidad = new CLS.Matriculas();
                    oEntidad.IDMatricula = dtgMatriculas.CurrentRow.Cells["IDMatricula"].Value.ToString();

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
