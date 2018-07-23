using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace CapaDiseño
{
    class Metodos
    {
        public static int Registrar(Libros L_libros)
        {

            int retorno = 0;
            using (OleDbConnection ObjConexion = Conexion.Cn_conexion())
            {
                ObjConexion.Open();
                OleDbCommand Comando = new OleDbCommand(string.Format("insert into Libros(id,Titulo,Autor,Catalogacion,Edicion,Fecha_de_Adquisicion,Editorial,Resumen,Numero_de_paginas,Volumen,Ciudad,Pais,ISBN,Cantidad) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                L_libros.id, L_libros.Titulo, L_libros.Autor, L_libros.Catalogacion, L_libros.Edicion, L_libros.Fecha_de_Adquisicion, L_libros.Resumen, L_libros.Editorial, L_libros.Numero_de_Paginas, L_libros.Volumen, L_libros.Ciudad, L_libros.Pais, L_libros.ISBN, L_libros.Cantidad), ObjConexion);
                retorno = Comando.ExecuteNonQuery();
                ObjConexion.Close();

            }
            return retorno;
        }
        public static int RegistrarPrestamo(Libros P_libros)
        {

            int retorno = 0;
            using (OleDbConnection ObjConexion = Conexion.Cn_conexion())
            {
                ObjConexion.Open();
                OleDbCommand Com = new OleDbCommand(string.Format("insert into Prestamos(id_usuario,fecha_prestamo,fecha_entrega,id_tipo_prestamo, estado_prestamo,id_libro) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                P_libros.id_usuario, P_libros.fecha_prestamo, P_libros.fecha_entrega, P_libros.tipo_prestamo, P_libros.estado_prestamo, P_libros.id_libro), ObjConexion);
                retorno = Com.ExecuteNonQuery();
                ObjConexion.Close();

            }
            return retorno;
        }
        public static int EditarPrestamo(Libros P_libros)
        {

            int retorno = 0;
            using (OleDbConnection ObjConexion = Conexion.Cn_conexion())
            {
                ObjConexion.Open();
                OleDbCommand Com = new OleDbCommand("update Prestamos set ID_Usuario = " + P_libros.id_usuario + ", Fecha_Prestamo = '" + P_libros.fecha_prestamo + "',Fecha_Entrega = '" + P_libros.fecha_entrega + "',ID_Tipo_Prestamo ='" + P_libros.tipo_prestamo + "', Estado_Prestamo = '" + P_libros.estado_prestamo + "',ID_Libro = " + P_libros.id_libro + " where ID_Prestamo = " + P_libros.id_prestamo + " ", ObjConexion);
                retorno = Com.ExecuteNonQuery();
                ObjConexion.Close();

            }
            return retorno;
        }
             
        
        public static int RegistrarUsuario(Libros P_libros)
        {

            int retorno = 0;
            using (OleDbConnection ObjConexion = Conexion.Cn_conexion())
            {
                ObjConexion.Open();
                OleDbCommand Com = new OleDbCommand(string.Format("insert into Usuarios(Nombre_Usuario, Usuario, Contraseña, ID_Rol, Correo, Telefono) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                P_libros.nombre,P_libros.usuario, P_libros.contraseña, P_libros.rol, P_libros.correo, P_libros.telefono), ObjConexion);
                retorno = Com.ExecuteNonQuery();
                ObjConexion.Close();

            }
            return retorno;
        }

    }
}
