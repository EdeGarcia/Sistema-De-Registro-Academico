using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas.GUI
{
    public partial class NotasGestion : Form
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

        private void CargarSecciones()
        {
            DataTable Secciones = new DataTable();

            try
            {
                Secciones = CacheManager.CLS.Cache.SECCIONES_DE_UN_GRADO(cbbGrados.SelectedValue.ToString());
                cbbSecciones.DataSource = Secciones;
                cbbSecciones.DisplayMember = "Descripcion";
                cbbSecciones.ValueMember = "IDSeccion";
            }
            catch
            {
                Secciones = new DataTable();
            }
        }

        private void CargarMaterias()
        {
            DataTable Materias = new DataTable();

            try
            {
                Materias = CacheManager.CLS.Cache.MATERIAS_GRADO(cbbGrados.SelectedValue.ToString());
                cbbMaterias.DataSource = Materias;
                cbbMaterias.DisplayMember = "Nombre";
                cbbMaterias.ValueMember = "IDMateria";
            }
            catch
            {
                Materias = new DataTable();
            }
        }

        private void CargarPeriodos()
        {
            DataTable Periodos = new DataTable();

            try
            {
                Periodos = CacheManager.CLS.Cache.TODOS_LOS_PERIODOS();
                cbbPeriodos.DataSource = Periodos;
                cbbPeriodos.DisplayMember = "Periodo";
                cbbPeriodos.ValueMember = "IDPeriodo";
            }
            catch
            {
                Periodos = new DataTable();
            }
        }

        private void CargarNotas()
        {
            DataTable Notas = new DataTable();

            try
            {
                String IDGrado = cbbGrados.SelectedValue.ToString();
                String IDSeccion = cbbSecciones.SelectedValue.ToString();
                String IDMateria = cbbMaterias.SelectedValue.ToString();
                String IDPeriodo = cbbPeriodos.SelectedValue.ToString();

                Notas = CacheManager.CLS.Cache.TODAS_LAS_NOTAS_DE_UNA_SECCION_MATERIA(IDGrado, IDSeccion, IDMateria, IDPeriodo);
                dtgNotas.AutoGenerateColumns = false;
                dtgNotas.DataSource = Notas;
                lblRegistros.Text = dtgNotas.Rows.Count.ToString() + " Notas Asignadas";
            }
            catch
            {

            }
        }

        public NotasGestion()
        {
            InitializeComponent();
        }

        private void NotasGestion_Load(object sender, EventArgs e)
        {
            CargarGrados();
            CargarPeriodos();
        }

        private void cbbGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
            CargarMaterias();
        }

        private void cbbPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarNotas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String pE = dtgNotas.CurrentRow.Cells["IDEstudiante"].Value.ToString();
                String pM = cbbMaterias.SelectedValue.ToString();
                String pP = cbbPeriodos.SelectedValue.ToString();

                NotasEdicion f = new NotasEdicion(pM, pP, pE);
                f.Show();
                CargarNotas();
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
                    String pE = dtgNotas.CurrentRow.Cells["IDEstudiante"].Value.ToString();
                    String pM = cbbMaterias.SelectedValue.ToString();
                    String pP = cbbPeriodos.SelectedValue.ToString();

                    NotasEdicion f = new NotasEdicion(pM, pP, pE);

                    f.txbIDNota.Text = dtgNotas.CurrentRow.Cells["IDNota"].Value.ToString();
                    f.txbNota.Text = dtgNotas.CurrentRow.Cells["Nota"].Value.ToString();
                    f.dtpFechaNota.Text = dtgNotas.CurrentRow.Cells["FechaNota"].Value.ToString();
                    f.ShowDialog();
                    CargarNotas();
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
                    CLS.Notas oEntidad = new CLS.Notas();
                    oEntidad.IDNota = dtgNotas.CurrentRow.Cells["IDNota"].Value.ToString();

                    if (oEntidad.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarNotas();
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
