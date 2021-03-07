using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using ProjectASP.DB;

namespace ProjectASP.Models
{
    public class PeliculaModel 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Actores { get; set; }
        public string Anio { get; set; }
        public string Sipnosis { get; set; }

        public List<PeliculaModel> Consulta()
        {
            var cn = Conexion.conexion();
            string query = "SELECT * FROM peliculas";
            return cn.Query<PeliculaModel>(query).ToList();
        }
        public bool Insertar(PeliculaModel model)
        {
            var cn = Conexion.conexion();
            string query = "INSERT INTO peliculas (nombre, autor, actores, anio, sipnosis) values('" + model.Nombre + "'," +
                "'" + model.Autor + "', '" + model.Actores + "', '" + model.Anio + "', '" + model.Sipnosis + "')";
            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;

        }
        public bool Editar(PeliculaModel model)
        {
            var cn = Conexion.conexion();
            string query = "UPDATE peliculas SET nombre = '" + model.Nombre + "', autor = '" + model.Autor + "', actores = '" + model.Actores + "'," +
                "anio = '" + model.Anio + "', sipnosis = '" + model.Sipnosis + "' WHERE id = '"+model.Id+"'";
            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Eliminar(int id)
        {
            var cn = Conexion.conexion();
            string query = "DELETE FROM peliculas WHERE id = '" + id + "'";
            if (cn.Execute(query) > 0)
            {
                return true;
            }
            return false;
        }
        public List<PeliculaModel> ConsultaId(int id)
        {
            var cn = Conexion.conexion();
            string query = "SELECT * FROM peliculas WHERE id = '" + id + "'";
            return cn.Query<PeliculaModel>(query).ToList();
        }
    }

}