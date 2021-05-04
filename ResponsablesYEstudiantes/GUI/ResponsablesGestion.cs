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
    public partial class ResponsablesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_RESPONSABLES();
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

            dtgResponsables.AutoGenerateColumns = false;
            dtgResponsables.DataSource = _DATOS;
            lblRegistros.Text = dtgResponsables.Rows.Count.ToString() + " Registros Encontrados";
        }

        public ResponsablesGestion()
        {
            InitializeComponent();
        }

        private void ResponsablesGestion_Load(object sender, EventArgs e)
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
                ResponsablesEdicion f = new ResponsablesEdicion();
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
                    ResponsablesEdicion f = new ResponsablesEdicion();
                    f.txbIDResponsable.Text = dtgResponsables.CurrentRow.Cells["ID"].Value.ToString();
                    f.txbNombres.Text = dtgResponsables.CurrentRow.Cells["Nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgResponsables.CurrentRow.Cells["Apellidos"].Value.ToString();
                    f.dtpFechaDeNacimiento.Text = dtgResponsables.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                    f.cbbSexo.Text = dtgResponsables.CurrentRow.Cells["Sexo"].Value.ToString();
                    f.txbTipoDeParentesco.Text = dtgResponsables.CurrentRow.Cells["TipoDeParentesco"].Value.ToString();
                    f.txbDui.Text = dtgResponsables.CurrentRow.Cells["DUI"].Value.ToString();
                    f.txbNit.Text = dtgResponsables.CurrentRow.Cells["NIT"].Value.ToString();
                    f.txbTelefono.Text = dtgResponsables.CurrentRow.Cells["Telefono"].Value.ToString();
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
                    CLS.Responsables oEntidad = new CLS.Responsables();
                    oEntidad.IDResponsable = dtgResponsables.CurrentRow.Cells["ID"].Value.ToString();

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
