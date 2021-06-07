using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas.GUI
{
    public partial class NotasEdicion : Form
    {
        String _IDMateria;
        String _IDPeriodo;
        String _IDEstudiante;

        private void Procesar()
        {
            CLS.Notas oEntidad = new CLS.Notas();
            oEntidad.IDNota = txbIDNota.Text;
            oEntidad.Nota = txbNota.Text;
            oEntidad.FechaNota = dtpFechaNota.Text;
            oEntidad.IDEstudiante = _IDEstudiante;
            oEntidad.IDMateria = _IDMateria;
            oEntidad.IDPeriodo = _IDPeriodo;

            try
            {
                if (txbIDNota.TextLength > 0)
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

            if(txbNota.TextLength == 0)
            {
                Resultado = false;

                Notificador.SetError(txbNota, "No puede guardar sin antes agregar una nota");
            }

            return Resultado;
        }

        public NotasEdicion(String pIDMateria, String pIDPeriodo, String pIDEstudiante)
        {
            InitializeComponent();
            _IDEstudiante = pIDEstudiante;
            _IDMateria = pIDMateria;
            _IDPeriodo = pIDPeriodo;
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
