using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{ 
    public partial class ReporteNotasEstudiante : Form
    {
        private void CargarGrados()
        {
            DataTable Grados = new DataTable();

            try
            {
                Grados = CacheManager.CLS.Cache.TODOS_LOS_GRADOS();
                cbbGrados.DataSource = Grados;
                cbbGrados.DisplayMember = "Descripcion";
                cbbGrados.ValueMember = "IDGrado";
                //

            }
            catch
            {
                Grados = new DataTable();
            }
        }

        private void CargarSecciones()
        {
            DataTable Secciones = new DataTable();

            try
            {
                Secciones = CacheManager.CLS.Cache.SECCIONES_DE_UN_GRADO(cbbGrados.SelectedValue.ToString());
                cbbSecciones.DataSource = Secciones;
                cbbSecciones.DisplayMember = "Descripcion";
                cbbSecciones.ValueMember = "IDSeccion";
            }
            catch
            {
                Secciones = new DataTable();
            }
        }

        private void CargarMaterias()
        {
            DataTable Materias = new DataTable();

            try
            {
                Materias = CacheManager.CLS.Cache.MATERIAS_GRADO(cbbGrados.SelectedValue.ToString());
                cbbMateria.DataSource = Materias;
                cbbMateria.DisplayMember = "Nombre";
                cbbMateria.ValueMember = "IDMateria";
            }
            catch
            {
                Materias = new DataTable();
            }
        }

        private void CargarPeriodos()
        {
            DataTable Periodos = new DataTable();

            try
            {
                Periodos = CacheManager.CLS.Cache.TODOS_LOS_PERIODOS();
                cbbPeriodo.DataSource = Periodos;
                cbbPeriodo.DisplayMember = "Periodo";
                cbbPeriodo.ValueMember = "IDPeriodo";
            }
            catch
            {
                Periodos = new DataTable();
            }
        }


        public ReporteNotasEstudiante()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String pM = cbbMateria.SelectedValue.ToString();
            String pP = cbbPeriodo.SelectedValue.ToString();
            String pG = cbbGrados.SelectedValue.ToString();
            String pS = cbbSecciones.SelectedValue.ToString();

            DataTable Datos = new DataTable();
            Datos = CacheManager.CLS.Cache.REPORTE_NOTAS_MATERIA_SECCION(pM, pP, pG, pS);
            REP.ReporteNotasSeccion Reporte = new REP.ReporteNotasSeccion();
            Reporte.SetDataSource(Datos);
            crvVisor.ReportSource = Reporte;
        }

        private void cbbGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
            CargarMaterias();
        }

        private void ReporteNotasEstudiante_Load(object sender, EventArgs e)
        {
            CargarGrados();
            CargarPeriodos();
        }
    }
}
