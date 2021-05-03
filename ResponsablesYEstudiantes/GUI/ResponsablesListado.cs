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
    public partial class ResponsablesListado : Form
    {
        BindingSource _DATOS = new BindingSource();

        public INTERFACE.Comunicar contrato { get; set; }

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.LISTADO_RESPONSABLES();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if(txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Apellidos LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgListadoResponsables.AutoGenerateColumns = false;
            dtgListadoResponsables.DataSource = _DATOS;
            lblRegistros.Text = dtgListadoResponsables.Rows.Count.ToString() + " Registros Encontrados";
        }

        public ResponsablesListado()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String id = dtgListadoResponsables.CurrentRow.Cells["IDResponsable"].Value.ToString();
            String n = dtgListadoResponsables.CurrentRow.Cells["Nombres"].Value.ToString();
            String a = dtgListadoResponsables.CurrentRow.Cells["Apellidos"].Value.ToString();
            contrato.Ejecutar(id, n, a);
            Close(); 
        }

        private void ResponsablesListado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
