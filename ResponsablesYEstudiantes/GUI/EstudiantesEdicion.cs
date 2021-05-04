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
    public partial class EstudiantesEdicion : Form, INTERFACE.Comunicar
    {
        private void Procesar()
        {
            CLS.Estudiantes oEntidad = new CLS.Estudiantes();
            oEntidad.IDEstudiante = txbIDEstudiante.Text;
            oEntidad.Nombres = txbNombres.Text;
            oEntidad.Apellidos = txbApellidos.Text;
            oEntidad.Direccion = txbDireccion.Text;
            oEntidad.FechaNacimiento = dtpFechaDeNacimiento.Text;
            oEntidad.Sexo = cbbSexo.Text;
            oEntidad.NIE = txbNie.Text;
            oEntidad.IDResponsable = txbIDResponsable.Text;

            try
            {
                if (txbIDEstudiante.TextLength > 0)
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
            if(txbDireccion.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDireccion, "Este campo no puede quedar vacío");
            }

            if(txbNie.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNie, "Este campo no puede quedar vacío");
            }

            if(txbIDResponsable.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(btnSeleccionarR, "Debe Seleccionar un responsable");
            }

            return Resultado;
        }

        public EstudiantesEdicion()
        {
            InitializeComponent();
        }

        //
        public void Ejecutar(string IDResponsable, string Nombres, string Apellidos)
        {
            txbIDResponsable.Text = IDResponsable;
            txbNombresR.Text = Nombres;
            txbApellidosR.Text = Apellidos;

        }

        private void btnSeleccionarR_Click(object sender, EventArgs e)
        {
            ResponsablesListado rl = new ResponsablesListado();
            rl.contrato = this;
            rl.Show();
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
