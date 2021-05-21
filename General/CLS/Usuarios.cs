using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Usuarios
    {
        String _IDUsuario;
        String _Usuario;
        String _IDRol;
        String _Clave;
        String _IDEmpleado;


        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }

            set
            {
                _IDUsuario = value;
            }
        }
        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }
        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }
        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
            }
        }
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

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Usuarios(Usuario, IDRol, Clave, IDEmpleado)"+
                               @"VALUES('"+this._Usuario+"', '"+this._IDRol+"', SHA1(MD5('"+this._Clave+"')), '"+this._IDEmpleado+"');";

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
            String Sentencia = @"UPDATE Usuarios SET Usuario = '"+this._Usuario+"', IDRol = '"+this._IDRol+"'," +
                                @"Clave = SHA1(MD5('"+this._Clave+"')) , IDEmpleado = '"+this._IDEmpleado+"';";

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
            String Sentencia = @"DELETE FROM Usuarios WHERE IDUsuario = '"+this._IDUsuario+"'; ";

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


        //Crear Maestro
        public Boolean GuardarMaestro()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Maestros(IDEmpleado) VALUES('"+this._IDEmpleado+"')";

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

        //Eliminar Maestro
        public Boolean EliminarMaestro()
        {
            Boolean Resultado = false;
            String Sentencia = @"DELETE FROM Maestros WHERE IDEmpleado = '" + this._IDEmpleado + "'; ";

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
