using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaMaE.GUI
{
    public partial class Login : Form
    {
        Boolean _Validado = false;

        public bool Validado
        {
            get
            {
                return _Validado;
            }
        }

        private void Validar()
        {
            try
            {
                SesionManager.CLS.Sesion SesionInicial = SesionManager.CLS.Sesion.Instancia;
                _Validado = SesionInicial.IniciarSesion(txbUsuario.Text, txbClave.Text);
                if (_Validado)
                {
                    Close();
                }
                else
                {
                    lblMensaje.Text = "USUARIO / CLAVE ERRONEOS, VUELVA A INTENTARLO";
                }
            }
            catch
            {
                _Validado = false;
            }

        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txbClave.Focus();
                txbClave.SelectAll();
            }
        }

        private void txbClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
