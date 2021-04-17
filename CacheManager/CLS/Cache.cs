using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.CLS
{
    public static class Cache
    {
        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDRol, Rol FROM Roles ORDER BY Rol;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        public static DataTable TODOS_LOS_GRADOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDGrado, Descripcion FROM Grados ORDER BY Descripcion;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        public static DataTable PERMISOS_DE_UN_ROL(String pIDRol)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.IDOpcion,
                                a.Opcion,
                                IF(IFNULL((SELECT IDPermiso FROM permisos z WHERE z.IDRol = "+pIDRol+@" AND z.IDOpcion = a.IDOpcion),0)=0,0,1) AS Seleccion,
                                IFNULL((SELECT IDPermiso FROM permisos z WHERE " + pIDRol+@" = 1 AND z.IDOpcion = a.IDOpcion),0) AS IDPermiso
                                FROM opciones a ORDER BY Opcion ASC;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        public static DataTable INICIAR_SESION(String pUsuario, String pClave)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDUsuario, a.Usuario, a.IDEmpleado, a.IDRol, CONCAT(b.Nombres, ' ', b.Apellidos) Empleado,c.Rol 
                              FROM usuarios a, Empleados b, Roles c
                              WHERE a.Usuario = '"+pUsuario+ @"'
                              AND a.Clave=SHA1(MD5('"+pClave+ @"'))
                              AND a.IDEmpleado=b.IDEmpleado
                              AND a.IDRol=c.IDRol;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }
    }
}
