using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.CLS
{
    class Notas
    {
        String _IDNota;
        String _Nota;
        String _FechaNota;
        String _IDEstudiante;
        String _IDMateria;
        String _IDPeriodo;

        public string IDNota
        {
            get
            {
                return _IDNota;
            }

            set
            {
                _IDNota = value;
            }
        }
        public string Nota
        {
            get
            {
                return _Nota;
            }

            set
            {
                _Nota = value;
            }
        }
        public string FechaNota
        {
            get
            {
                return _FechaNota;
            }

            set
            {
                _FechaNota = value;
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
        public string IDPeriodo
        {
            get
            {
                return _IDPeriodo;
            }

            set
            {
                _IDPeriodo = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            String Sentencia = @"INSERT INTO Notas(Nota, FechaNota, IDEstudiante, IDMateria, IDPeriodo)" 
                                 +@"VALUES('"+this._Nota+"', '"+this._FechaNota+"', '"+this._IDEstudiante+"', '"+this._IDMateria+"', '"+this._IDPeriodo+"');";
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
            String Sentencia = @"UPDATE Notas SET Nota = '"+this._Nota+"', FechaNota = '"+this._FechaNota+"', IDEstudiante = '"+this._IDEstudiante+"', IDMateria = '"+this._IDMateria+"',IDPeriodo = '"+this._IDPeriodo+"' WHERE IDNota = '"+this._IDNota+"';";
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
            String Sentencia = @"DELETE FROM Notas WHERE IDNota = '"+this._IDNota+"';";
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
