using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dictionnaire
{
    public partial class chemin : Form
    {
        public chemin()
        {
            InitializeComponent();
        }

        private void chemin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void supr_Click(object sender, EventArgs e)
        {
            String C = textBox1.Text;
            var lineNumber = 0;
            bool inserer = false;
            using (SqlConnection conn = new SqlConnection("Data Source = FOURAT\\SQLEXPRESS; Initial Catalog = master; Integrated Security = True"))
            {
                conn.Open();
                try
                {
                    using (StreamReader reader = new StreamReader(C))
                    {
                        MessageBox.Show("fichier ouvert");
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (lineNumber != 0)
                            {
                                var values = line.Split(',');

                                var sqlFr = "INSERT INTO francais (mot_f, traduction_a, type, ex_f) VALUES (@mot_f, @traduction_a, @type, @ex_f)";
                                var cmdFr = new SqlCommand(sqlFr, conn);
                                cmdFr.Parameters.AddWithValue("@mot_f", values[0]);
                                cmdFr.Parameters.AddWithValue("@traduction_a", values[1]);
                                cmdFr.Parameters.AddWithValue("@type", values[2]);
                                cmdFr.Parameters.AddWithValue("@ex_f", values[3]);
                                cmdFr.ExecuteNonQuery();

                                var sqlEn = "INSERT INTO anglais (mot_a, traduction_f, type, ex_a) VALUES (@mot_a, @traduction_f, @type, @ex_a)";
                                var cmdEn = new SqlCommand(sqlEn, conn);
                                cmdEn.Parameters.AddWithValue("@mot_a", values[1]);
                                cmdEn.Parameters.AddWithValue("@traduction_f", values[0]);
                                cmdEn.Parameters.AddWithValue("@type", values[2]);
                                cmdEn.Parameters.AddWithValue("@ex_a", values[4]);
                                cmdEn.ExecuteNonQuery();
                                inserer = true;
                            }
                            lineNumber++;
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("An exception occurred: " + ex.Message);
                }
                finally
                {
                    if(inserer== true)
                    {
                        MessageBox.Show("Données du fichier CSV ajouter avec succées ");
                    }
                    else
                    {
                        MessageBox.Show("Données non insérer ! veuillez verifier le chemin d'accées ou le fichier csv ");

                    }
                    conn.Close();
                    textBox1.Text = "";
                }
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
