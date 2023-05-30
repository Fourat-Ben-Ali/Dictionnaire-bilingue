using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace projet_dictionnaire
{
    public class Traduction
    {
        public string Mot_L1 { get; set; }
        public string Mot_L2 { get; set; }
        public string Type { get; set; }
        public string Expl1 { get; set; }
        public string Expl2 { get; set; }

        public static List<Traduction> LireFichierTraductions(string cheminFichier)
        {
            List<Traduction> traductions = new List<Traduction>();
            if (File.Exists(cheminFichier))
            {
                using (StreamReader sr = new StreamReader(cheminFichier))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        Traduction traduction = new Traduction
                        {
                            Mot_L1 = values[0],
                            Mot_L2 = values[1],
                            Type = values[2],
                            Expl1 = values[3],
                            Expl2 = values[4]
                        };

                        traductions.Add(traduction);
                    }

                }
            }
            else
            {
                Console.WriteLine("Le fichier n'existe pas.");
            }
            return traductions;
        }

        public void InsererTraductions(List<Traduction> traductions, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    foreach (Traduction traduction in traductions)
                    {
                        using (SqlCommand command = new SqlCommand("INSERT INTO francais(mot_f, type, traduction_a, ex_f) VALUES (@mot_l1, @type, @mot_l2,@expl1); INSERT INTO anglais(mot_a, type, traduction_f, ex_a) VALUES (@mot_l2, @type, @mot_l1,@expl2);", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@mot_l1", traduction.Mot_L1);
                            command.Parameters.AddWithValue("@mot_l2", traduction.Mot_L2);
                            command.Parameters.AddWithValue("@type", traduction.Type);
                            command.Parameters.AddWithValue("@expl1", traduction.Expl1);
                            command.Parameters.AddWithValue("@expl2", traduction.Expl2);

                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Erreur lors de l'insertion des données : " + ex.Message);
                }
            }
        }
    }
}
