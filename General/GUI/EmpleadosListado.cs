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
    public partial class EmpleadosListado : Form
    {
        BindingSource _DATOS = new BindingSource();

        //
        public INTERFACE.Comunicar contrato { get; set; }

        private void Cargar()
        {
            _DATOS.DataSource = CacheManager.CLS.Cache.LISTADO_DE_EMPLEADOS();
            FiltrarLocalmente();
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength > 0)
            {
                _DATOS.Filter = "Nombres LIKE '%" + txbFiltrar + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }

            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _DATOS;
            lblEmpleados.Text = dtgEmpleados.Rows.Count.ToString() + " Empleados Encontrados";
        }

        public EmpleadosListado()
        {
            InitializeComponent();
        }

        private void EmpleadosListado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String IDEmpleado = dtgEmpleados.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            String Empleado = dtgEmpleados.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgEmpleados.CurrentRow.Cells["Apellidos"].Value.ToString();
            contrato.Ejecutar(IDEmpleado,Empleado);
            Close();
        }
    }
}
