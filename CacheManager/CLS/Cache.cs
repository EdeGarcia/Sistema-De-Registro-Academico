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

        public static DataTable TODAS_LAS_MATERIAS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDMateria, Nombre, Descripcion FROM materias ORDER BY Nombre;";
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

        public static DataTable MATERIAS_DE_UN_GRADO(String pIDGrado)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT c.IDMateria, c.Nombre, C.Descripcion, a.IDGrado_Materia
                                FROM grados_materias a, grados b, materias c
                                WHERE a.IDGrado = b.IDGrado AND a.IDMateria = c.IDMateria AND a.IDGrado = '"+pIDGrado+"';";
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

        public static DataTable LISTADO_DE_MATERIAS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDMateria, Nombre FROM materias;";
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

        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDUsuario, a.Usuario, b.Rol, CONCAT(c.Nombres, ' ', c.Apellidos) AS Empleado, a.IDEmpleado
                                FROM usuarios a, roles b, empleados c
                                WHERE a.IDRol = b.IDRol AND a.IDEmpleado = c.IDEmpleado;";
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

        public static DataTable LISTADO_DE_EMPLEADOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDEmpleado, Nombres, Apellidos, Titulo, DUI FROM empleados;";
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

        public static DataTable MAESTRO_POR_SECCION()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDMaestro_Seccion, CONCAT(d.Nombres, ' ', d.Apellidos) AS Maestro, e.Descripcion AS Grado ,c.Descripcion AS Seccion, c.Turno
                                FROM maestros_secciones a, maestros b, secciones c, empleados d, grados e
                                WHERE a.IDMaestro = b.IDMaestro AND a.IDSeccion = c.IDSeccion AND b.IDEmpleado = d.IDEmpleado AND c.IDGrado = e.IDGrado;";
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

        public static DataTable SECCIONES_DE_UN_GRADO(String pIDGrado)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDSeccion, Descripcion FROM secciones WHERE IDGrado = '"+pIDGrado+"';";
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

        public static DataTable LISTADO_DE_MAESTROS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDMaestro, CONCAT(b.Nombres, ' ', b.Apellidos) AS Maestro,b.Titulo ,b.DUI
                                FROM maestros a, empleados b
                                WHERE a.IDEmpleado = b.IDEmpleado;";
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

        public static DataTable LISTADO_DE_ESTUDIANTES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDEstudiante, NIE, CONCAT(Nombres, ' ', Apellidos) AS Estudiante FROM Estudiantes;";
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

        public static DataTable DATOS_SECCION(String pIDSeccion)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT Turno, Cupo FROM Secciones WHERE IDSeccion = '"+pIDSeccion+"';";
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

        public static DataTable TODAS_LAS_MATRICULAS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.IDMatricula, a.IDEstudiante ,CONCAT(b.Nombres, ' ', b.Apellidos) AS Estudiante, c.Descripcion AS Grado, d.Descripcion AS Seccion, d.Turno, a.FechaMatricula,
                                (SELECT CONCAT(z.Nombres, ' ', z.Apellidos) FROM maestros_secciones x, maestros y, empleados z WHERE x.IDMaestro = y.IDMaestro AND y.IDEmpleado = z.IDEmpleado AND x.IDSeccion = a.IDSeccion) AS Maestro
                                FROM matriculas a, estudiantes b, grados c, secciones d
                                WHERE a.IDEstudiante = b.IDEstudiante AND a.IDGrado = c.IDGrado AND a.IDSeccion = d.IDSeccion
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

        public static DataTable TODAS_LAS_NOTAS_DE_UNA_SECCION_MATERIA(String pIDGrado, String pIDSeccion, String pIDMateria, String pIDPeriodo)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT b.NIE, b.Nombres, b.Apellidos,
                               (SELECT Nota FROM Notas WHERE IDEstudiante = a.IDEstudiante AND IDMateria = '"+pIDMateria+@"' AND IDPeriodo = '"+pIDPeriodo+@"') AS Nota,
                               (SELECT FechaNota FROM Notas WHERE IDEstudiante = a.IDEstudiante AND IDMateria = '"+pIDMateria+@"' AND IDPeriodo = '"+pIDPeriodo+@"') AS FechaNota,
                               (SELECT IDNota FROM Notas WHERE IDEstudiante = a.IDEstudiante AND IDMateria = '"+pIDMateria+@"' AND IDPeriodo = '"+pIDPeriodo+@"') AS IDNota,
                               a.IDEstudiante
                               FROM Matriculas a, Estudiantes b
                               WHERE a.IDEstudiante = b.IDEstudiante AND IDGrado = '"+pIDGrado+"' AND IDSeccion = '"+pIDSeccion+"';";
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

        public static DataTable MATERIAS_GRADO(String pIDGrado)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT c.IDMateria, c.Nombre
                                FROM grados_materias a, grados b, materias c
                                WHERE a.IDGrado = b.IDGrado AND a.IDMateria = c.IDMateria AND a.IDGrado = '" + pIDGrado + "';";
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

        public static DataTable TODOS_LOS_PERIODOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT IDPeriodo, Periodo FROM Periodo";
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

        //Reportes del sistema
        public static DataTable REPORTE_RESPONSABLES_DE_UNA_SECCION(String pIDGrado, String pIDSeccion)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT CONCAT(c.Nombres, ' ', c.Apellidos) AS Responsable,c.TipoDeParentesco AS Parentesco, c.DUI, c.NIT, CONCAT(b.Nombres, ' ', b.Apellidos) AS Estudiante 
                                FROM matriculas a, estudiantes b, responsables c
                                WHERE a.IDEstudiante = b.IDEstudiante AND b.IDResponsable = c.IDResponsable
                                AND a.IDGrado = '"+pIDGrado+"' AND a.IDSeccion = '"+pIDSeccion+"';";
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

        public static DataTable REPORTE_ESTUDIANTES_SECCION(String pIDGrado, String pIDSeccion)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT b.NIE, b.Apellidos, b.Nombres,b.Direccion 
                                FROM matriculas a, estudiantes b
                                WHERE a.IDEstudiante = b.IDEstudiante AND a.IDGrado = '"+pIDGrado+"' AND a.IDSeccion = '"+pIDSeccion+"';";
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

        public static DataTable REPORTE_NOTAS_MATERIA_SECCION(String pIDMateria, String pIDPeriodo, String pIDGrado, String pIDSeccion)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                b.Apellidos,
                                b.Nombres,
                                (SELECT Nota FROM Notas WHERE IDEstudiante = a.IDEstudiante AND IDMateria = '"+pIDMateria+@"' AND IDPeriodo = '"+pIDPeriodo+@"') AS Nota
                                FROM matriculas a, estudiantes b
                                WHERE a.idEstudiante = b.IDEstudiante AND a.IDGrado = '"+pIDGrado+"' AND a.IDSeccion = '"+pIDSeccion+"';";
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
                                AND a.IDRol = '"+pIDRol+"';";

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
                                IF(IFNULL((SELECT IDPermiso FROM permisos z WHERE z.IDRol = '"+pIDRol+@"' AND z.IDOpcion = a.IDOpcion),0)=0,0,1) AS Seleccion,
                                IFNULL((SELECT IDPermiso FROM permisos z WHERE z.IDRol =  '"+pIDRol+@"' AND z.IDOpcion = a.IDOpcion),0) AS IDPermiso
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
