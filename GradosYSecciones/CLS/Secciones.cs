using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosYSecciones.CLS
{
    class Secciones
    {
        String _IDSeccion;
        String _Descripcion;
        String _Turno;
        String _Aula;
        String _Cupo;
        String _IDGrado;

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
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }
        public string Turno
        {
            get
            {
                return _Turno;
            }

            set
            {
                _Turno = value;
            }
        }
        public string Aula
        {
            get
            {
                return _Aula;
            }

            set
            {
                _Aula = value;
            }
        }
        public string Cupo
        {
            get
            {
                return _Cupo;
            }

            set
            {
                _Cupo = value;
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

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Secciones(Descripcion, Turno, Aula, Cupo, IDGrado) 
                                VALUES('" + this._Descripcion + "', '"+this._Turno+"', '"+this._Aula+"', '"+this._Cupo+"', '"+this._IDGrado+"');";

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
            String Sentencia = @"UPDATE Secciones SET Descripcion = '"+this._Descripcion+"', Turno = '"+this._Turno+"', Aula =  '"+this._Aula+"', Cupo ='"+this._Cupo+"', IDGrado = '"+this._IDGrado+"' WHERE IDSeccion = '"+this._IDSeccion+"';";

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
            String Sentencia = @"DELETE FROM Secciones WHERE IDSeccion = '"+this._IDSeccion+"' ;";

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
