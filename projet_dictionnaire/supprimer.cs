using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dictionnaire
{
    public partial class supprimer : Form
    {
        public supprimer()
        {
            InitializeComponent();
        }

        private void supr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) // utilisation de la méthode IsNullOrEmpty pour vérifier si la TextBox est vide
            {
                mot.Text = "Veuillez saisir le mot à effacer !"; // correction de la faute d'orthographe
            }
            else
            {
                string connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connection)) // utilisation du bloc using pour garantir que la connexion sera fermée même si une exception est levée
                {
                    con.Open();
                    if(radioButton1.Checked==false && radioButton2.Checked==false)
                    {
                        MessageBox.Show("Veuillez sélectionner une langue !");
                    }



                        if (radioButton1.Checked)
                    {
                        // utilisation d'une transaction pour garantir que les deux requêtes sont exécutées ou aucune si une exception est levée
                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM francais WHERE mot_f = @motf", con, transaction);
                                cmdCheck.Parameters.AddWithValue("@motf", textBox1.Text);
                                int count = (int)cmdCheck.ExecuteScalar();

                                if (count == 0) // si le mot n'existe pas dans la base de données
                                {
                                    MessageBox.Show("Le mot n'existe pas dans la base de données."); // affichage d'un message d'erreur
                                }

                                else
                                {
                                    SqlCommand cmd = new SqlCommand("DELETE FROM francais WHERE mot_f = @motf", con, transaction); // ajout du mot-clé FROM dans la requête
                                    cmd.Parameters.AddWithValue("@motf", textBox1.Text);
                                    cmd.ExecuteNonQuery();
                                    if (MessageBox.Show("Voulez-vous supprimer cette mot ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        SqlCommand cmd1 = new SqlCommand("DELETE FROM anglais WHERE traduction_f = @motf", con, transaction); // ajout du mot-clé FROM dans la requête
                                        cmd1.Parameters.AddWithValue("@motf", textBox1.Text);
                                        cmd1.ExecuteNonQuery();

                                        transaction.Commit(); // validation de la transaction
                                        MessageBox.Show("Mot supprimé avec succées ");

                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback(); // annulation de la transaction en cas d'erreur
                                MessageBox.Show("Une erreur est survenue lors de la suppression : " + ex.Message);
                            }

                            finally {
                                con.Close();
                                textBox1.Text = "";
                                radioButton1.Checked = false;
                            }    
                        }
                    }
                    if (radioButton2.Checked)
                    {
                        // utilisation d'une transaction pour garantir que les deux requêtes sont exécutées ou aucune si une exception est levée
                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM anglais WHERE mot_a = @mota", con, transaction);
                                cmdCheck.Parameters.AddWithValue("@mota", textBox1.Text);
                                int count = (int)cmdCheck.ExecuteScalar();

                                if (count == 0) // si le mot n'existe pas dans la base de données
                                {
                                    MessageBox.Show("Le mot n'existe pas dans la base de données."); // affichage d'un message d'erreur
                                }

                                else
                                {


                                    SqlCommand cmd = new SqlCommand("DELETE FROM anglais WHERE mot_a = @mota", con, transaction); // ajout du mot-clé FROM dans la requête
                                    cmd.Parameters.AddWithValue("@mota", textBox1.Text);
                                    cmd.ExecuteNonQuery();
                                    if (MessageBox.Show("Voulez-vous supprimer cette mot ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        SqlCommand cmd1 = new SqlCommand("DELETE FROM francais WHERE traduction_a = @mota", con, transaction); // ajout du mot-clé FROM dans la requête
                                        cmd1.Parameters.AddWithValue("@mota", textBox1.Text);
                                        cmd1.ExecuteNonQuery();

                                        transaction.Commit(); // validation de la transaction
                                        MessageBox.Show("Mot supprimé !");
                                    }
                                }  

                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback(); // annulation de la transaction en cas d'erreur
                                MessageBox.Show("Une erreur est survenue lors de la suppression : " + ex.Message);
                            }
                            finally
                            {
                                con.Close();
                                textBox1.Text = "";
                                radioButton2.Checked = false;
                            }
                        }
                    }
                    
                 
                        
                    
                }
            }

        }

        private void utilisateur_Click(object sender, EventArgs e)
        {
            traduire t= new traduire();
            t.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            ajouter t= new ajouter();
            t.Show();
            this.Hide();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            vue_utilistateur vu = new vue_utilistateur();
            vu.Show();
            this.Hide();
        }

        private void supprimer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modifier modifier = new modifier(); 
            modifier.Show();    
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extraire extraire = new Extraire();   
            extraire.Show();    
            this.Hide();
        }
    }
}
