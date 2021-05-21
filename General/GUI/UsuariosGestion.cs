using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class UsuariosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_USUARIOS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Usuario LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgUsuarios.AutoGenerateColumns = false;
            dtgUsuarios.DataSource = _DATOS;
            lblUsuarios.Text = dtgUsuarios.Rows.Count.ToString() + " Usuarios Encontrados";
        }

        public UsuariosGestion()
        {
            InitializeComponent();
        }

        private void UsuariosGestion_Load(object sender, EventArgs e)
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
                UsuariosEdicion f = new UsuariosEdicion();
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
                    UsuariosEdicion f = new UsuariosEdicion();
                    f.txbIDUsuario.Text = dtgUsuarios.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    f.txbUsuario.Text = dtgUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                    f.cbbRoles.Text = dtgUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
                    //
                    f.txbClave.Text = "1111";
                    f.txbIDEmpleado.Text = dtgUsuarios.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    f.txbEmpleado.Text = dtgUsuarios.CurrentRow.Cells["Empleado"].Value.ToString();

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
                    CLS.Usuarios oEntidad = new CLS.Usuarios();
                    oEntidad.IDUsuario = dtgUsuarios.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    oEntidad.IDEmpleado = dtgUsuarios.CurrentRow.Cells["IDEmpleado"].Value.ToString();

                    if(dtgUsuarios.CurrentRow.Cells["Rol"].Value.ToString() == "MAESTRO")
                    {
                        oEntidad.EliminarMaestro();
                    }

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
