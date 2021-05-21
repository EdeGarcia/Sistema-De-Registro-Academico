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
    public partial class SeccionesEdicion : Form
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

        private void Procesar()
        {
            CLS.Secciones oEntidad = new CLS.Secciones();
            oEntidad.IDSeccion = txbIDSeccion.Text;
            oEntidad.Descripcion = txbDescripcion.Text;
            oEntidad.Turno = cbbTurno.Text;
            oEntidad.Aula = txbAula.Text;
            oEntidad.Cupo = txbCupo.Text;
            oEntidad.IDGrado = cbbGrados.SelectedValue.ToString();

            try
            {
                if(txbIDSeccion.TextLength > 0)
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

            if (txbDescripcion.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacío");
            }

            if(txbAula.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbAula, "Este campo no puede quedar vacío");
            }

            if(txbCupo.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbCupo, "Este campo no puede quedar vacío");
            }

            return Resultado;
        }

        public SeccionesEdicion()
        {
            InitializeComponent();  
        }

        private void SeccionesEdicion_Load(object sender, EventArgs e)
        {
            CargarGrados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Procesar();
            }
        }
    }
}
