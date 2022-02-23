using Datos;
using Datos.Modelos;
using Correo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class UsuariosCrud
    {
        private UsuariosBD _usuarios;
        private EnviadorCorreo _correo;


        public UsuariosCrud(SqlConnection conexion)
        {

            _usuarios = new UsuariosBD(conexion);
            _correo = new EnviadorCorreo();
        }
        public bool Agregar(Usuarios usuario)
        {
            bool respuesta = _usuarios.Agregar(usuario);

            if (respuesta)
            {
                _correo.Enviar(usuario.Correo, "Nuevo usuario", "Se ha agregado este nuevo usuario: " + usuario.Nombre + " " + usuario.Apellido);
            }

            return respuesta;
        }

        public bool Editar(Usuarios usuario)
        {
            return _usuarios.Editar(usuario);
        }

        public bool Eliminar(int id)
        {
            return _usuarios.Eliminar(id);
        }

        public Usuarios ObtenerporID(int id)
        {
            return _usuarios.ObtenerporID(id);
        }

        public DataTable ObtenerTodo()
        {
            return _usuarios.ObtenerTodo();
        }

        public DataTable ValidarLogin(string usuario, string contra)
        {
            return _usuarios.ValidarLogin(usuario, contra);
        }

        public DataTable ValidarRol(string usuario)
        {
            return _usuarios.ValidarRol(usuario);
        }

    }
}
