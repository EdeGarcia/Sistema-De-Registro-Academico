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
    public partial class RolesEdicion : Form
    {
        private void Procesar()
        {
            CLS.Roles oEntidad = new CLS.Roles();
            oEntidad.IDRol = txbIDRol.Text;
            oEntidad.Rol = txbRol.Text;

            try
            {
                if (txbIDRol.TextLength > 0)
                {
                    //Esta actualizando
                    if (oEntidad.Editar())
                    {
                        MessageBox.Show("Registro actualizado correctamente","Confirmación",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

            if(txbRol.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbRol, "Este campo no puede quedar vacío");
            }

            return Resultado;
        }


        public RolesEdicion()
        {
            InitializeComponent();
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
