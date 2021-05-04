using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.CLS
{
    class Grados_Materias
    {
        String _IDGrado_Materia;
        String _IDGrado;
        String _IDMateria;

        public string IDGrado_Materia
        {
            get
            {
                return _IDGrado_Materia;
            }

            set
            {
                _IDGrado_Materia = value;
            }
        }
        public string IDGrado
        {
            get
            {
                return _IDGrado;
            }

            set
            {
                _IDGrado = value;
            }
        }
        public string IDMateria
        {
            get
            {
                return _IDMateria;
            }

            set
            {
                _IDMateria = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO grados_materias(IDGrado, IDMateria) VALUES('"+this._IDGrado+"', '"+this._IDMateria+"');";
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
            String Sentencia = @"DELETE FROM grados_materias WHERE IDGrado_Materia = '"+this._IDGrado_Materia+"';";
            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Eliminar(Sentencia) > 0)
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
