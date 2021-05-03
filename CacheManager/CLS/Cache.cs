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
        //Metodos del sistema NAMAE
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

        public static DataTable TODAS_LAS_SECCIONES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDSeccion AS ID,b.Descripcion AS Grado, a.Descripcion AS Seccion, a.Cupo, a.Turno, a.Aula
                               FROM secciones a, grados b 
                               WHERE a.IDGrado = b.IDGrado 
                               ORDER BY Grado;";
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

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDEmpleado, Nombres, Apellidos, FechaNacimiento, Sexo, Telefono, DUI, NIT, Titulo FROM Empleados;";
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

        public static DataTable TODOS_LOS_RESPONSABLES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDResponsable, Nombres, Apellidos, FechaNacimiento, Sexo, TipoDeParentesco, DUI, NIT, Telefono FROM responsables;";
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

        public static DataTable TODOS_LOS_ESTUDIANTES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDEstudiante, a.Nombres, a.Apellidos, a.Direccion, a.FechaNacimiento, a.Sexo, a.NIE, CONCAT(b.Nombres, ' ', b.Apellidos) AS Responsable, a.IDResponsable
                               FROM estudiantes a, responsables b
                               WHERE a.IDResponsable = b.IDResponsable;";
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

        public static DataTable LISTADO_RESPONSABLES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDResponsable, Nombres, Apellidos, DUI
                                FROM responsables ORDER BY Apellidos;";
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

        public static DataTable DATOS_DE_UN_RESPONSABLE(String pIDResponsable)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDResponsable, Nombres, Apellidos FROM responsables WHERE IDResponsable = '"+pIDResponsable+"';";
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

        //
        public static DataTable PERMISOS_DE_UN_USUARIO(String pIDRol)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT DISTINCT a.IDOpcion, b.Opcion
                                FROM permisos a, opciones b
                                WHERE a.IDOpcion = b.IDOpcion
                                AND a.IDRol = "+pIDRol+";";

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
