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
    public partial class modifier : Form
    {
        confirmer c ;
        public modifier()
        {
            InitializeComponent();
        }
        public string TexteCapturé
        {
            get { return textBox1.Text; }
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
                    if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {
                        MessageBox.Show("Veuillez sélectionner une langue !");
                    }



                    if (radioButton1.Checked)
                    {
                        // utilisation d'une transaction pour garantir que les deux requêtes sont exécutées ou aucune si une exception est levée
                        
                        
                            try
                            {
                                SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM francais WHERE mot_f = @motf", con);
                                cmdCheck.Parameters.AddWithValue("@motf", textBox1.Text);
                                int count = (int)cmdCheck.ExecuteScalar();

                                if (count == 0) // si le mot n'existe pas dans la base de données
                                {
                                    MessageBox.Show("Le mot n'existe pas dans la base de données."); // affichage d'un message d'erreur
                                }

                                else
                                {
                                c= new confirmer();   
                                c.motf = textBox1.Text;
                               
                                c.remplirformulaire();
                                c.ShowDialog();
                               
                            }

                        }
                            catch (Exception ex)
                            {
                                
                                MessageBox.Show("Une erreur est survenue lors de la suppression : " + ex.Message);
                            }

                            finally
                            {
                                con.Close();
                                textBox1.Text = "";
                                radioButton1.Checked = false;
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
                                    c = new confirmer();
                                    c.mota = textBox1.Text;

                                    c.remplirformulaire();
                                    c.ShowDialog();



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
            traduire traduire= new traduire();
            traduire.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supprimer supprimer= new supprimer();   
                supprimer.Show();
                this.Hide();    
        }

        private void Admin_Click(object sender, EventArgs e)
        {
               ajouter a=new ajouter();
            a.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           radioButton1.Checked = false;
            radioButton2.Checked = false;
            mot.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extraire extraire=new Extraire();   
             extraire.Show();    
            this.Hide();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            vue_utilistateur vue_Utilistateur = new vue_utilistateur();
            vue_Utilistateur.Show();
            this.Hide();
        }
    }
}
