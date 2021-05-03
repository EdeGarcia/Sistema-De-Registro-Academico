using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsablesYEstudiantes.CLS
{
    class Estudiantes
    {
        String _IDEstudiante;
        String _Nombres;
        String _Apellidos;
        String _Direccion;
        String _FechaNacimiento;
        String _Sexo;
        String _NIE;
        String _IDResponsable;

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
        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }
        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }
        public string FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }

            set
            {
                _FechaNacimiento = value;
            }
        }
        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }
        public string NIE
        {
            get
            {
                return _NIE;
            }

            set
            {
                _NIE = value;
            }
        }
        public string IDResponsable
        {
            get
            {
                return _IDResponsable;
            }

            set
            {
                _IDResponsable = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO estudiantes(Nombres, Apellidos, Direccion, FechaNacimiento, Sexo, NIE, IDResponsable)"
                                +@"VALUES('"+this._Nombres+"', '"+this._Apellidos+"', '"+this._Direccion+"', '"+this._FechaNacimiento+"', '"+this._Sexo+"', '"+this._NIE+"', '"+this._IDResponsable+"');";
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
            String Sentencia = @"UPDATE estudiantes SET Nombres = '"+this._Nombres+"', Apellidos = '"+this._Apellidos+"', Direccion = '"+this._Direccion+"', FechaNacimiento = '"+this._FechaNacimiento+"',"
                                +@"Sexo = '"+this._Sexo+"', NIE = '"+this._NIE+"', IDResponsable = '"+this._IDResponsable+"' WHERE IDEstudiante = '"+this._IDEstudiante+"'; ";
            
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
            String Sentencia = @"DELETE FROM estudiantes WHERE IDEstudiante = '"+this._IDEstudiante+"'; ";

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
