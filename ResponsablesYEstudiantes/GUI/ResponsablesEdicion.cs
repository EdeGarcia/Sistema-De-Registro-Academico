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
    public partial class ResponsablesEdicion : Form
    {
        private void Procesar()
        {
            CLS.Responsables oEntidad = new CLS.Responsables();
            oEntidad.IDResponsable = txbIDResponsable.Text;
            oEntidad.Nombres = txbNombres.Text;
            oEntidad.Apellidos = txbApellidos.Text;
            oEntidad.FechaNacimiento = dtpFechaDeNacimiento.Text;
            oEntidad.Sexo = cbbSexo.Text;
            oEntidad.TipoDeParentesco = txbTipoDeParentesco.Text;
            oEntidad.DUI = txbDui.Text;
            oEntidad.NIT = txbNit.Text;
            oEntidad.Telefono = txbTelefono.Text;

            try
            {
                if (txbIDResponsable.TextLength > 0)
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

            if(txbNombres.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNombres, "Este campo no puede quedar vacío");
            }
            if(txbApellidos.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbApellidos, "Este campo no puede quedar vacío");
            }
            if(txbTipoDeParentesco.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbTipoDeParentesco, "Este campo no puede quedar vacío");
            }
            if(txbDui.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDui, "Este campo no puede quedar vacío");
            }
            if(txbNit.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNit, "Este campo no puede quedar vacío");
            }
            if(txbTelefono.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbTelefono, "Este campo no puede quedar vacío");
            }

            return Resultado;
        }

        public ResponsablesEdicion()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
