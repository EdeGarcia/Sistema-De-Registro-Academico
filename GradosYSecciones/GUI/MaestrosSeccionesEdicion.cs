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
    public partial class MaestrosSeccionesEdicion : Form, INTERFACE.Comunicar
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

        private void Procesar()
        {
            CLS.Maestros_Secciones oEntidad = new CLS.Maestros_Secciones();
            oEntidad.IDMaestro_Seccion = txbIDMaestro_Seccion.Text;
            oEntidad.IDMaestro = txbIDMaestro.Text;
            oEntidad.IDSeccion = cbbSecciones.SelectedValue.ToString();

            try
            {
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
            catch
            {

            }
            
        }

        private Boolean Comprobar()
        {
            Boolean Resultado = true;

            Notificador.Clear();

            if(txbMaestro.TextLength == 0)
            {
                Notificador.SetError(btnSeleccionar, "Debe seleccionar un maestro");
                Resultado = false;
            }

            return Resultado;
        }

        public MaestrosSeccionesEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                Procesar();
            }
        }

        private void MaestrosSeccionesEdicion_Load(object sender, EventArgs e)
        {
            CargarGrados();
            cbbGrados_SelectedIndexChanged(null, null);
        }

        private void cbbGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                MaestrosListado f = new MaestrosListado();
                f.contrato = this;
                f.Show();
            }
            catch
            {

            }
        }

        public void Ejecutar(string IDMaestro, string Maestro)
        {
            txbIDMaestro.Text = IDMaestro;
            txbMaestro.Text = Maestro;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
