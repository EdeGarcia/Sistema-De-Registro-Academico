using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsablesYEstudiantes.GUI
{
    public partial class EstudiantesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_ESTUDIANTES();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Nombres LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgEstudiantes.AutoGenerateColumns = false;
            dtgEstudiantes.DataSource = _DATOS;
            lblRegistros.Text = dtgEstudiantes.Rows.Count.ToString() + " Registros Encontrados";
        }

        public EstudiantesGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EstudiantesEdicion f = new EstudiantesEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch
            {

            }
        }

        private void EstudiantesGestion_Load(object sender, EventArgs e)
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
                    EstudiantesEdicion f = new EstudiantesEdicion();

                    //
                    f.txbIDEstudiante.Text = dtgEstudiantes.CurrentRow.Cells["IDEstudiante"].Value.ToString();
                    f.txbNombres.Text = dtgEstudiantes.CurrentRow.Cells["Nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgEstudiantes.CurrentRow.Cells["Apellidos"].Value.ToString();
                    f.txbDireccion.Text = dtgEstudiantes.CurrentRow.Cells["Direccion"].Value.ToString();
                    f.dtpFechaDeNacimiento.Text = dtgEstudiantes.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                    f.txbSexo.Text = dtgEstudiantes.CurrentRow.Cells["Sexo"].Value.ToString();
                    f.txbNie.Text = dtgEstudiantes.CurrentRow.Cells["NIE"].Value.ToString();

                    //
                    DataTable DatosResponsable = new DataTable();

                    try
                    {
                        DatosResponsable = CacheManager.CLS.Cache.DATOS_DE_UN_RESPONSABLE(dtgEstudiantes.CurrentRow.Cells["IDResponsable"].Value.ToString());

                        if (DatosResponsable.Rows.Count == 1)
                        {
                            f.txbIDResponsable.Text = DatosResponsable.Rows[0]["IDResponsable"].ToString();
                            f.txbNombresR.Text = DatosResponsable.Rows[0]["Nombres"].ToString();
                            f.txbApellidosR.Text = DatosResponsable.Rows[0]["Apellidos"].ToString();
                        }
                    }
                    catch
                    {

                    }

                    //
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
                    CLS.Estudiantes oEntidad = new CLS.Estudiantes();
                    oEntidad.IDEstudiante = dtgEstudiantes.CurrentRow.Cells["IDEstudiante"].Value.ToString();

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
