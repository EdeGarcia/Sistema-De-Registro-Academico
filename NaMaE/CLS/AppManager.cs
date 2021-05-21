using NaMaE.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaMaE.CLS
{
    class AppManager : ApplicationContext
    {
        private Boolean SplashScreen()
        {
            Boolean resultado = true;
            Splash f = new Splash();
            f.ShowDialog();
            return resultado;
        }
        private Boolean LoginScreen()
        {
            Boolean resultado = true;
            Login f = new Login();
            f.ShowDialog();
            resultado = f.Validado;
            return resultado;
        }
        public AppManager()
        {
            if (SplashScreen())
            {
                if (LoginScreen())
                {
                    Principal f = new Principal();
                    f.ShowDialog();
                    //
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    Application.Exit();
                }
            }
        }

    }
}
