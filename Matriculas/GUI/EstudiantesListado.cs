using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriculas.GUI
{
    public partial class EstudiantesListado : Form
    {
        BindingSource _DATOS = new BindingSource();

        //
        public INTERFACE.Comunicar contrato { get; set; }

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.LISTADO_DE_ESTUDIANTES();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Estudiante LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgEstudiantes.AutoGenerateColumns = false;
            dtgEstudiantes.DataSource = _DATOS;
            lblRegistros.Text = dtgEstudiantes.Rows.Count.ToString() + " Estudiantes Encontrados";
        }

        public EstudiantesListado()
        {
            InitializeComponent();
        }

        private void EstudiantesListado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String IDEstudiante = dtgEstudiantes.CurrentRow.Cells["IDEstudiante"].Value.ToString();
            String Estudiante = dtgEstudiantes.CurrentRow.Cells["Estudiante"].Value.ToString();
            contrato.Ejecutar(IDEstudiante, Estudiante);
            Close();
        }
    }
}
