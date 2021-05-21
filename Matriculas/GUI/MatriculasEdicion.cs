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
    public partial class MatriculasEdicion : Form, INTERFACE.Comunicar
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
            }
            catch
            {

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

            }
        }

        private void CargarDatosSeccion()
        {
            DataTable DatosSeccion = new DataTable();

            try
            {
                DatosSeccion = CacheManager.CLS.Cache.DATOS_SECCION(cbbSecciones.SelectedValue.ToString());

                if(DatosSeccion.Rows.Count == 1)
                {
                    txbTurno.Text = DatosSeccion.Rows[0]["Turno"].ToString();
                    txbCupo.Text = DatosSeccion.Rows[0]["Cupo"].ToString();
                }
            }
            catch
            {

            }
        }

        private void Procesar()
        {
            CLS.Matriculas oEntidad = new CLS.Matriculas();
            oEntidad.IDMatricula = txbIDMatricula.Text;
            oEntidad.IDEstudiante = txbIDEstudiante.Text;
            oEntidad.IDGrado = cbbGrados.SelectedValue.ToString();
            oEntidad.IDSeccion = cbbSecciones.SelectedValue.ToString();
            oEntidad.FechaMatricula = dtpFechaMatricula.Text;

            try
            {
                if (txbIDMatricula.TextLength > 0)
                {
                    //Esta actualizando 
                    if (oEntidad.Editar())
                    {
                        MessageBox.Show("Registro actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un problema al actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //Esta guardando
                    if (oEntidad.Guardar())
                    {
                        MessageBox.Show("Registro ingresado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un problema al guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch
            {

            }
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;

            Notificador.Clear();

            if(txbIDEstudiante.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(btnSeleccionarEstudiante, "Se debe seleccionar un estudiante a matricular");
            }

            return Resultado;
        }

        public MatriculasEdicion()
        {
            InitializeComponent();
        }

        private void btnSeleccionarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                EstudiantesListado f = new EstudiantesListado();
                f.contrato = this;
                f.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Procesar();
            }
        }

        private void MatriculasEdicion_Load(object sender, EventArgs e)
        {
            CargarGrados();
            cbbGrados_SelectedIndexChanged(null, null);
            cbbSecciones_SelectedIndexChanged(null, null);
        }

        private void cbbGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
        }

        public void Ejecutar(string IDEstudiante, string Estudiante)
        {
            txbIDEstudiante.Text = IDEstudiante;
            txbEstudiante.Text = Estudiante;
        }

        private void cbbSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosSeccion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
