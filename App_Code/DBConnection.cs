using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace todo_cdan8.App_Code
{
    public static class DBConnection
    {
        public static NpgsqlConnection connectionString =
            new NpgsqlConnection(
                ConfigurationManager.ConnectionStrings["TodoDatabaseConnection"].ConnectionString
                );

        public static bool VerifierUtilisateur(Utilisateur utilisateur)
        {
            var req = $"SELECT * FROM public.\"User\" WHERE username ='{utilisateur.NomUtilisateur}' AND \"password\"='{utilisateur.Password}'";
            var hasUser = false;
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.HasRows;
                connectionString.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            return hasUser;
        }

        public static void InsertionTache(Tache tache)
        {
            var req = $"INSERT INTO public.\"Tache\"(username, tachenom, state)	" +
                $"VALUES('{tache.Username}', '{tache.Tachenom}', '{tache.State}'); ";

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();
            }catch (Exception e)
            {
                throw e;
            }
        }

        public static List<Tache> retrouverTaches(string username)
        {
            var req = $"SELECT * FROM public.\"Tache\" WHERE username = '{username}'";
            var taches = new List<Tache>();
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    var tache = new Tache(rd.GetInt32(0),rd.GetString(1),rd.GetString(2), rd.GetBoolean(3));
                    taches.Add(tache);
                }
                connectionString.Close();
            }catch(Exception e)
            {
                throw e;
            }

            return taches;
        }

    }
}