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
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Autor { get; set; }
        private string Anio { get; set; }
        private string Sipnosis { get; set; }
        private string Actores { get; set; }

        public List<PeliculaModel> Consulta()
        {
            var cn = Conexion.conexion();
            string query = "SELECT * FROM pelicula";
            cn.Query<>
        } 
    }

}