using Datos;
using Datos.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class PacientesCrud
    {

        private PacientesBD _pacientes;

        public PacientesCrud(SqlConnection conexion)
        {
            _pacientes = new PacientesBD(conexion);
        }
        public bool Agregar(Pacientes paciente)
        {
            return _pacientes.Agregar(paciente);
        }

        public bool Editar(Pacientes paciente)
        {
            return _pacientes.Editar(paciente);
        }

        public bool Eliminar(int id)
        {
            return _pacientes.Eliminar(id);
        }

        public bool GuardarFoto(int id, string destino)
        {
            return _pacientes.GuardarFoto(id, destino);
        }

        public int UltimoId()
        {
            return _pacientes.UltimoId();
        }

        public Pacientes ObtenerporID(int id)
        {
            return _pacientes.ObtenerporID(id);
        }

        public DataTable ObtenerTodo()
        {
            return _pacientes.ObtenerTodo();
        }

    }
}
