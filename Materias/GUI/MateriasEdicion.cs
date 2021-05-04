using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materias.GUI
{
    public partial class MateriasEdicion : Form
    {
        private void Procesar()
        {
            CLS.Materias oEntidad = new CLS.Materias();
            oEntidad.IDMateria = txbIDMateria.Text;
            oEntidad.Nombre = txbNombre.Text;
            oEntidad.Descripcion = txbDescripcion.Text;

            try
            {
                if (txbIDMateria.TextLength > 0)
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

            if(txbNombre.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbNombre, "Este campo no puede quedar vacío");
            }
            if(txbDescripcion.TextLength == 0)
            {
                Resultado = false;
                Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacío");
            }

            return Resultado;
        }

        public MateriasEdicion()
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
