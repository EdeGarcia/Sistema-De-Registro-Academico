using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Empleados
    {
        String _IDEmpleado;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Sexo;
        String _Telefono;
        String _DUI;
        String _NIT;
        String _Titulo;

        public string IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
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
        public string Titulo
        {
            get
            {
                return _Titulo;
            }

            set
            {
                _Titulo = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Empleados(Nombres, Apellidos, FechaNacimiento, Sexo, Telefono, DUI, NIT, Titulo)"
                               +@" VALUES('" +this.Nombres+ "', '"+this._Apellidos+"', '"+this._FechaNacimiento+"', '"+this._Sexo+"', '"+this._Telefono+"', '"+this._DUI+"', '"+this._NIT+"', '"+this._Titulo+"');";

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
            String Sentencia = @"UPDATE Empleados SET Nombres = '"+this._Nombres+"', Apellidos = '"+this._Apellidos
                +"', FechaNacimiento = '"+this._FechaNacimiento+"', Sexo = '"+this._Sexo+"', Telefono = '"+this._Telefono
                +"', DUI = '"+this._DUI+"', NIT = '"+this._NIT+"', Titulo = '"+this._Titulo+"' WHERE IDEmpleado = '"+this._IDEmpleado+"';";
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
            String Sentencia = @"DELETE FROM Empleados WHERE IDEmpleado = '"+this._IDEmpleado+"';";

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
