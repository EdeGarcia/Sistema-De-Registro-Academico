using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosYSecciones.CLS
{
    class Maestros_Secciones
    {
        String _IDMaestro_Seccion;
        String _IDMaestro;
        String _IDSeccion;

        public string IDMaestro_Seccion
        {
            get
            {
                return _IDMaestro_Seccion;
            }

            set
            {
                _IDMaestro_Seccion = value;
            }
        }
        public string IDMaestro
        {
            get
            {
                return _IDMaestro;
            }

            set
            {
                _IDMaestro = value;
            }
        }
        public string IDSeccion
        {
            get
            {
                return _IDSeccion;
            }

            set
            {
                _IDSeccion = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Maestros_Secciones(IDMaestro, IDSeccion) VALUES('"+this._IDMaestro+"', '"+this._IDSeccion+"');";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }

            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM Maestros_Secciones WHERE IDMaestro_Seccion = '"+this._IDMaestro_Seccion+"'; ";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch
            {
                Resultado = false;
            }

            return Resultado;
        }

    }
}
