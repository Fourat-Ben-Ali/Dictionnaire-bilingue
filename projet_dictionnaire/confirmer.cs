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
    public partial class confirmer : Form
    {
         public string motf;
        public  string mota;
        public confirmer()
        {
            InitializeComponent();
        }

        private void ajout_Click(object sender, EventArgs e)
        {
            if ((mot_a.Text == "") && (mot_f.Text == "") && (type.Text == "") && (ex_a.Text == "") && (ex_f.Text == ""))
            {
                MessageBox.Show("veuillez remplir ce formulaire SVP!");
            }
            else if (mot_a.Text == "")
            {
                mot_al.Text = "ce champs est obligatoire !";
            }
            else if (mot_f.Text == "")
            {
                mot_fl.Text = "ce champs est obligatoire !";
            }
            else if (type.Text == "")
            {
                typel.Text = "ce champs est obligatoire !";
            }
            else if (ex_a.Text == "")
            {
                ex_al.Text = "ce champs est obligatoire !";
            }
            else if (ex_f.Text == "")
            {
                ex_fl.Text = "ce champs est obligatoire !";
            }
            else
                try
                {
                    string connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();

                        // Mise à jour de la table "francais"
                        using (SqlCommand cmd = new SqlCommand("update francais set mot_f = @new_mot_f, traduction_a = @traduction_a, type = @type, ex_f = @ex_f where mot_f = @old_mot_f", con))
                        {
                            cmd.Parameters.AddWithValue("@new_mot_f", mot_f.Text);
                            cmd.Parameters.AddWithValue("@traduction_a", mot_a.Text);
                            cmd.Parameters.AddWithValue("@type", type.Text);
                            cmd.Parameters.AddWithValue("@ex_f", ex_f.Text);
                            cmd.Parameters.AddWithValue("@old_mot_f", motf);

                            cmd.ExecuteNonQuery();
                        }

                        // Mise à jour de la table "anglais"
                        using (SqlCommand cmd1 = new SqlCommand("update anglais set mot_a=@new_mot_a, traduction_f=@traduction_f, type=@type, ex_a=@ex_a where mot_a=@old_mot_a", con))
                        {
                            cmd1.Parameters.AddWithValue("@new_mot_a", mot_a.Text);
                            cmd1.Parameters.AddWithValue("@traduction_f", mot_f.Text);
                            cmd1.Parameters.AddWithValue("@type", type.Text);
                            cmd1.Parameters.AddWithValue("@ex_a", ex_a.Text);
                            cmd1.Parameters.AddWithValue("@old_mot_a", mota);

                            cmd1.ExecuteNonQuery();
                        }

                        // Nettoyage des champs de saisie
                        mot_a.Text = "";
                        mot_f.Text = "";
                        type.Text = "";
                        ex_a.Text = "";
                        ex_f.Text = "";
                        mot_al.Text = "";
                        mot_fl.Text = "";
                        typel.Text = "";
                        ex_al.Text = "";
                        ex_fl.Text = "";

                        MessageBox.Show("Modifié avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la mise à jour : " + ex.Message);
                }



        }
        public void remplirformulaire()
        {   string connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                SqlConnection con = new SqlConnection(connection);
            if (motf != null)
            {
                mot_f.Text = motf;

                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("select traduction_a from francais where mot_f=@motf", con);
                    cmd.Parameters.AddWithValue("@motf", motf);
                    mot_a.Text = (String)cmd.ExecuteScalar();
                    SqlCommand cmd1 = new SqlCommand("select type from francais where mot_f=@motf", con);
                    cmd1.Parameters.AddWithValue("@motf", motf);
                    type.Text = (String)cmd1.ExecuteScalar();
                    SqlCommand cmd2 = new SqlCommand("select ex_f from francais where mot_f=@motf", con);
                    cmd2.Parameters.AddWithValue("@motf", motf);
                    ex_f.Text = (String)cmd2.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand("select ex_a from anglais where traduction_f=@motf", con);
                    cmd3.Parameters.AddWithValue("@motf", motf);
                    ex_a.Text = (String)cmd3.ExecuteScalar();
                    mota=mot_a.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue : " + ex.Message);
                }
            }

            else if (mota != null)
            {
                mot_a.Text = mota;

                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("select traduction_f from anglais where mot_a=@mota", con);
                    cmd.Parameters.AddWithValue("@mota", mota);
                    mot_f.Text = (String)cmd.ExecuteScalar();
                    SqlCommand cmd1 = new SqlCommand("select type from anglais where mot_a=@mota", con);
                    cmd1.Parameters.AddWithValue("@mota", mota);
                    type.Text = (String)cmd1.ExecuteScalar();
                    SqlCommand cmd2 = new SqlCommand("select ex_a from anglais where mot_a=@mota", con);
                    cmd2.Parameters.AddWithValue("@mota", mota);
                    ex_a.Text = (String)cmd2.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand("select ex_f from francais where traduction_a=@mota", con);
                    cmd3.Parameters.AddWithValue("@mota", mota);
                    ex_f.Text = (String)cmd3.ExecuteScalar();
                    motf = mot_f.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue  : " + ex.Message);
                }

            }
            
        }

        private void mot_f_TextChanged(object sender, EventArgs e)
        {
          
          
        }

        private void confirmer_Load(object sender, EventArgs e)
        {

        }
    }
}
