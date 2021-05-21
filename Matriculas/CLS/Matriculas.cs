using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.CLS
{
    class Matriculas
    {
        String _IDMatricula;
        String _IDEstudiante;
        String _IDGrado;
        String _IDSeccion;
        String _FechaMatricula;

        public string IDMatricula
        {
            get
            {
                return _IDMatricula;
            }

            set
            {
                _IDMatricula = value;
            }
        }
        public string IDEstudiante
        {
            get
            {
                return _IDEstudiante;
            }

            set
            {
                _IDEstudiante = value;
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
        public string FechaMatricula
        {
            get
            {
                return _FechaMatricula;
            }

            set
            {
                _FechaMatricula = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO matriculas(IDEstudiante, IDGrado, IDSeccion, FechaMatricula)"
                                 + @"VALUES('"+this._IDEstudiante+"', '"+this._IDGrado+"', '"+this._IDSeccion+"', '"+this._FechaMatricula+"');";

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
        public Boolean Editar()
        {
            Boolean Resultado = false;
            String Sentencia = @"UPDATE matriculas SET IDEstudiante = '"+this._IDEstudiante+"', IDGrado = '"+this._IDGrado+"', IDSeccion = '"+this._IDSeccion+"', FechaMatricula = '"+this._FechaMatricula+"'; ";

            try
            {
                DataManager.CLS.OperacionBD Operacion = new DataManager.CLS.OperacionBD();
                if (Operacion.Actualizar(Sentencia) > 0)
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
            String Sentencia = @"DELETE FROM matriculas WHERE IDMatricula = '"+this._IDMatricula+"';";

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
