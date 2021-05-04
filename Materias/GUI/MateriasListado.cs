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
    public partial class MateriasListado : Form
    {
        String _IDGrado;
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.LISTADO_DE_MATERIAS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Nombre LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgMaterias.AutoGenerateColumns = false;
            dtgMaterias.DataSource = _DATOS;
            lblMaterias.Text = dtgMaterias.Rows.Count.ToString() + " Materias Encontradas";
        }

        public MateriasListado(String pIDGrado)
        {
            InitializeComponent();
            _IDGrado = pIDGrado;
        }

        private void MateriasListado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CLS.Grados_Materias oEntidad = new CLS.Grados_Materias();
            oEntidad.IDGrado = _IDGrado;
            oEntidad.IDMateria = dtgMaterias.CurrentRow.Cells["IDMateria"].Value.ToString();

            try
            {
                if (oEntidad.Guardar())
                {
                    MessageBox.Show("¡Materia asignada con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch
            {

            }

        }
    }
}
