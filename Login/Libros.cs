using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDiseño
{
    class Libros
    {
        public int id;
        public string Titulo;
        public string Autor;
        public string Catalogacion;
        public string Edicion;
        public string Fecha_de_Adquisicion;
        public string Resumen;
        public string Editorial;
        public int Numero_de_Paginas;
        public int Volumen;
        public string Ciudad;
        public string Pais;
        public int ISBN;
        public int Cantidad;
        public string ID_Libro_Estado;



        public Libros() { }

        public Libros(int id, string Titulo, string Autor, string Catalogacion, string Edicion, string Fecha_de_Adquisicion,
           string Resumen, string Editorial, int Numero_de_Paginas, int Volumen, string Ciudad, string Pais, int ISBN, int Cantidad, string ID_Libro_Estado)
        {
            this.id = id;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Catalogacion = Catalogacion;
            this.Edicion = Edicion;
            this.Fecha_de_Adquisicion = Fecha_de_Adquisicion;
            this.Resumen = Resumen;
            this.Editorial = Editorial;
            this.Numero_de_Paginas = Numero_de_Paginas;
            this.Volumen = Volumen;
            this.Ciudad = Ciudad;
            this.Pais = Pais;
            this.ISBN = ISBN;
            this.Cantidad = Cantidad;
            this.ID_Libro_Estado = ID_Libro_Estado;
        }
        public int id_prestamo;
        public int id_usuario;
        public DateTime fecha_prestamo;
        public DateTime fecha_entrega;
        public string tipo_prestamo;
        public string estado_prestamo;
        public int id_libro;
        public Libros(int id_usuario, DateTime fecha_prestamo, DateTime fecha_entrega, string tipo_prestamo, string estado_prestamo, int id_libro)
        {
            this.id_usuario= id_usuario;
            this.fecha_prestamo= fecha_prestamo;
            this.fecha_entrega= fecha_entrega;
            this.tipo_prestamo= tipo_prestamo;           
            this.estado_prestamo= estado_prestamo;
            this.id_libro= id_libro;
        }
        public Libros(int id_prestamo,int id_usuario, DateTime fecha_prestamo, DateTime fecha_entrega, string tipo_prestamo, string estado_prestamo, int id_libro)
        {
            this.id_prestamo = id_prestamo;
            this.id_usuario = id_usuario;
            this.fecha_prestamo = fecha_prestamo;
            this.fecha_entrega = fecha_entrega;
            this.tipo_prestamo = tipo_prestamo;            
            this.estado_prestamo = estado_prestamo;
            this.id_libro = id_libro;
        }
        public string nombre, usuario, contraseña, rol, correo, telefono;
        public Libros(string nombre, string usuario, string contraseña, string rol, string correo, string telefono)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.rol = rol;
            this.correo = correo;
            this.telefono = telefono;
        }
    }
}
