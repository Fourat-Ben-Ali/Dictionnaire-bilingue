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
using System.IO;

namespace projet_dictionnaire
{
    public partial class ajouter : Form
    {
        public ajouter()
        {
            InitializeComponent();
        }

        private void ajouter_Load(object sender, EventArgs e)
        {

        }

        private void utilisateur_Click(object sender, EventArgs e)
        {
            traduire traduire= new traduire();
            traduire.Show();
            this.Hide();
        }

        private void ajout_Click(object sender, EventArgs e)
        {

        }

        private void ajout_Click_1(object sender, EventArgs e)
        {
              if ((mot_a.Text == "") && (mot_f.Text == "") && (type.Text == "") && (ex_a.Text == "") && (ex_f.Text == ""))
            {
                MessageBox.Show("veuillez remplir ce formulaire SVP!");
            }
            else if (mot_a.Text=="")
            {
                mot_al.Text = "ce champs est obligatoire !";
            }
            else if(mot_f.Text=="")
            {
                mot_fl.Text = "ce champs est obligatoire !";
            }
            else if (type.Text=="")
            {
                typel.Text = "ce champs est obligatoire !";
            }
            else if(ex_a.Text=="")
            {
                ex_al.Text = "ce champs est obligatoire !";
            }
            else if(ex_f.Text=="")
            {
                ex_fl.Text = "ce champs est obligatoire !";
            }
          
            else
            try
            {
                String connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

                SqlConnection con;
                DataTable dt;
                con = new SqlConnection(connection);
                dt = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into francais(mot_f, type, traduction_a, ex_f) values (@mot_f, @type, @traduction_a, @ex_f)", con);
                
                cmd.Parameters.AddWithValue("@mot_f", mot_f.Text);
                cmd.Parameters.AddWithValue("@traduction_a", mot_a.Text);
                cmd.Parameters.AddWithValue("@type", type.Text);
                cmd.Parameters.AddWithValue("@ex_a", ex_a.Text);
                cmd.Parameters.AddWithValue("@ex_f", ex_f.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("insert into anglais(mot_a,type,traduction_f,ex_a )    values (@traduction_a,@type,@mot_f, @ex_a)", con);
                

                cmd1.Parameters.AddWithValue("@mot_f", mot_f.Text);
                cmd1.Parameters.AddWithValue("@traduction_a", mot_a.Text);
                cmd1.Parameters.AddWithValue("@type", type.Text);
                cmd1.Parameters.AddWithValue("@ex_a", ex_a.Text);

                cmd1.ExecuteNonQuery();
                con.Close();
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
                    
                MessageBox.Show("ajoutées avec succées !!");
               
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supprimer t = new supprimer();
            t.Show();
            this.Hide();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            vue_utilistateur vu = new vue_utilistateur();
            vu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modifier modifier= new modifier();  
            modifier.Show();    
                this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
           chemin chemin = new chemin();
            chemin.ShowDialog(); 
           




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extraire extraire = new Extraire();
            extraire.Show();
            this.Hide();
        }
    }
}
