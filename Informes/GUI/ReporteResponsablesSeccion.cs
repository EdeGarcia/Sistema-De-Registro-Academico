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
    public partial class ReporteResponsablesSeccion : Form
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

        public ReporteResponsablesSeccion()
        {
            InitializeComponent();
            CargarGrados();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String pG = cbbGrados.SelectedValue.ToString();
            String pS = cbbSecciones.SelectedValue.ToString();

            DataTable Datos = new DataTable();
            Datos = CacheManager.CLS.Cache.REPORTE_RESPONSABLES_DE_UNA_SECCION(pG, pS);
            REP.ReporteResponsablesSeccion Reporte = new REP.ReporteResponsablesSeccion();
            Reporte.SetDataSource(Datos);
            crvVisor.ReportSource = Reporte;

        }

        private void cbbGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSecciones();
        }
    }
}
