using General.INTERFACE;
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
    public partial class UsuariosEdicion : Form, Comunicar
    {
        private void CargarRoles()
        {
            DataTable Roles = new DataTable();

            try
            {
                Roles = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
                cbbRoles.DataSource = Roles;
                cbbRoles.DisplayMember = "Rol";
                cbbRoles.ValueMember = "IDRol";
                //
                //cbbRoles.SelectedIndex = 1;

            }
            catch
            {
                Roles = new DataTable();
            }
        }

        private void Procesar()
        {
            CLS.Usuarios oEntidad = new CLS.Usuarios();
            oEntidad.IDUsuario = txbIDUsuario.Text;
            oEntidad.Usuario = txbUsuario.Text;
            oEntidad.IDRol = cbbRoles.SelectedValue.ToString();
            oEntidad.Clave = txbClave.Text;
            oEntidad.IDEmpleado = txbIDEmpleado.Text;

            try
            {

                if (txbIDUsuario.TextLength > 0)
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
                    //Esta agregando
                    if(cbbRoles.Text == "MAESTRO")
                    {
                        if (oEntidad.GuardarMaestro())
                        {

                        }
                    }

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

            if(txbUsuario.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbUsuario, "Este campo no puedo quedar vacio");
            }

            if(txbClave.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbClave, "Este campo no puedo quedar vacio");
            }

            if(txbEmpleado.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(btnSeleccionar, "Seleccione un empleado para el usuario creado");
            }

            return Resultado;   
        }

        public UsuariosEdicion()
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

        private void UsuariosEdicion_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosListado el = new EmpleadosListado();
                el.contrato = this;
                el.Show();

            }
            catch
            {

            }
        }

        public void Ejecutar(string IDEmpleado, string Empleado)
        {
            txbIDEmpleado.Text = IDEmpleado;
            txbEmpleado.Text = Empleado;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
