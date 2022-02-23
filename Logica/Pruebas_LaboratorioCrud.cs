using Datos;
using Datos.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class Pruebas_LaboratorioCrud
    {

        private Pruebas_LaboratorioBD _pruebas;

        public Pruebas_LaboratorioCrud(SqlConnection conexion)
        {
            _pruebas = new Pruebas_LaboratorioBD(conexion);
        }
        public bool Agregar(Pruebas_Laboratorio prueba)
        {
            return _pruebas.Agregar(prueba);
        }

        public bool Editar(Pruebas_Laboratorio prueba)
        {
            return _pruebas.Editar(prueba);
        }

        public bool Eliminar(int id)
        {
            return _pruebas.Eliminar(id);
        }

        public Pruebas_Laboratorio ObtenerporID(int id)
        {
            return _pruebas.ObtenerporID(id);
        }

        public DataTable ObtenerTodo()
        {
            return _pruebas.ObtenerTodo();
        }

    }
}
