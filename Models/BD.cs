using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace TP10.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=LAPTOP-IARA\SQLEXPRESS;Database=BDSeries;Trusted_Connection=True;";

        public static List<Temporada> ObtenerTemporadas(int idSerie){
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @idSerie";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Temporada>(sql, new {idSerie}).ToList();
            }
        }

        public static List<Actor> ObtenerActores(int idSerie){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @idSerie";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Actor>(sql, new {idSerie}).ToList();
            }
        }

        public static List<Serie> ObtenerSeries(){
            string sql = "SELECT * FROM Series";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Serie>(sql).ToList();
            }
        }

        public static Serie? ObtenerSerie(int idSerie){
            Serie? serie = null;
            string sql = "SELECT * FROM Series WHERE IdSerie = @idSerie";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                serie = connection.Query<Serie>(sql, new {idSerie}).FirstOrDefault();
            }
            return serie;
        }
    }
}
