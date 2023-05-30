using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dictionnaire
{
    public partial class Extraire : Form
    {
        public Extraire()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            openFileDialog1.Title = "Sélectionnez un fichier texte";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void supr_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = FOURAT\\SQLEXPRESS; Initial Catalog = master; Integrated Security = True";
            string query = "SELECT anglais.mot_a, francais.traduction_a, anglais.type AS type_a, anglais.ex_a, francais.ex_f FROM anglais JOIN francais ON anglais.traduction_f = francais.mot_f";

            string outputFilePath = textBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        using (StreamWriter writer = new StreamWriter(outputFilePath))
                        {
                            // Write headers to the output file
                            writer.WriteLine("Mot anglais,Traduction français,Type,Exemple anglais,Exemple français");

                            // Write data to the output file
                            while (reader.Read())
                            {
                                writer.WriteLine(reader.GetString(0) + "," + reader.GetString(1) + "," + reader.GetString(2) + "," + reader.GetString(3) + "," + reader.GetString(4));
                            }
                        }
                    }
                    MessageBox.Show("Exportation des données réussie dans le fichier " + outputFilePath);
                }
            }
        }

        private void utilisateur_Click(object sender, EventArgs e)
        {
            traduire traduire   = new traduire();
              traduire.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            ajouter ajouter = new ajouter();
            ajouter.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            supprimer supprimer = new supprimer();
            supprimer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modifier modifier = new modifier();
            modifier.Show();
            this.Hide();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            vue_utilistateur vue_Utilistateur= new vue_utilistateur();
            vue_Utilistateur.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
