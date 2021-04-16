using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager.CLS
{
    public class ConexionBD
    {
        String _CadenaConexion = "Server=localhost;Database=sistema_namae;Uid=root;Pwd=12345678;";
        protected MySqlConnection _Conexion;

        public ConexionBD()
        {
            _Conexion = new MySqlConnection();
            _Conexion.ConnectionString = _CadenaConexion;
        }

        protected Boolean Conectar()
        {
            Boolean conectado = false;

            try
            {
                _Conexion.Open();
                conectado = true;
            }
            catch
            {
                conectado = false;
            }

            return conectado;
        }

        protected void Desconectar()
        {
            try
            {
                if(_Conexion.State == System.Data.ConnectionState.Open)
                {
                    _Conexion.Close();
                }
            }
            catch
            {

            }
        }
    }
}
