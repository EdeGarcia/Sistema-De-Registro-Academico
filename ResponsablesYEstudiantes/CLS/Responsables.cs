using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsablesYEstudiantes.CLS
{
    class Responsables
    {
        String _IDResponsable;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Sexo;
        String _TipoDeParentesco;
        String _DUI;
        String _NIT;
        String _Telefono;

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
        public string TipoDeParentesco
        {
            get
            {
                return _TipoDeParentesco;
            }

            set
            {
                _TipoDeParentesco = value;
            }
        }
        public string DUI
        {
            get
            {
                return _DUI;
            }

            set
            {
                _DUI = value;
            }
        }
        public string NIT
        {
            get
            {
                return _NIT;
            }

            set
            {
                _NIT = value;
            }
        }
        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO responsables(Nombres, Apellidos, FechaNacimiento, Sexo, TipoDeParentesco, DUI, NIT, Telefono)
                                 VALUES('"+this._Nombres+"', '"+this._Apellidos+"','"+this._FechaNacimiento+"', '"+this._Sexo+"', '"+this._TipoDeParentesco+"', '"+this._DUI+"', '"+this._NIT+"', '"+this._Telefono+"');";

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
            String Sentencia = @"UPDATE responsables SET Nombres = '" + this._Nombres + "', Apellidos = '" + this._Apellidos + "', FechaNacimiento = '" + this._FechaNacimiento + "',"
                                +@"Sexo = '" + this._Sexo + "', TipoDeParentesco = '"+this._TipoDeParentesco+"', DUI = '"+this._DUI+"', NIT = '"+this._NIT+"', Telefono = '"+this._Telefono+"' WHERE IDResponsable = '"+this._IDResponsable+"' ;";

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
            String Sentencia = @"DELETE FROM responsables WHERE IDResponsable = '"+this._IDResponsable+"';";

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
