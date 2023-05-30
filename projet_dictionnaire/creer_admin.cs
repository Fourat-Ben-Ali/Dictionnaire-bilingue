using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace projet_dictionnaire
{
    public partial class creer_admin : Form
    {
        public creer_admin()
        {
            InitializeComponent();
            CustumizeDesign();
        }
        private void CustumizeDesign()
        {
            subMenuPanel1.Visible = false;
            subMenuPanel2.Visible = false;

        }
        public void HideSubMenu()
        {
            if (subMenuPanel1.Visible == true)
            {
                subMenuPanel1.Visible = false;
            }
            if (subMenuPanel2.Visible == true)
            {
                subMenuPanel2.Visible = false;
            }


        }
        public void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Boolean test (string s) 
        {
            string pattern = @"^[a-zA-Z0-9]*$";
            bool containsSpecialCharsAndDigits = !Regex.IsMatch(s, pattern);
            if (containsSpecialCharsAndDigits)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void verifier()
        {
            //controle saisie sur le nom

            if (namet.Text == "")
            {
                noml.Text = "veuillez saisir le nom !";
            }
            else if (namet.Text.Length < 4)
            {
                noml.Text = " le nom est trop court!";
            }

            else
                noml.Text = "";
            //controle saisie du prenom
            if (surnamet.Text == "")
            {
                prenoml.Text = "veuillez saisir le prènom!";
            }
            else if (surnamet.Text.Length < 4)
            {
                prenoml.Text = " le prènom est trop court!";
            }
            else if (test(surnamet.Text))
            {
                prenoml.Text = " le prénom ne doit pas contenir des caracteres speciaux et des chiffres!";
            }
            else
                prenoml.Text = "";
            //controle saisie du nom d'utilisateur

            if (usernamet.Text == "")
            {
                usernameL.Text = "veuillez saisir le nom  d'utilisateur !";
            }
            else if (usernamet.Text.Length < 4)
            {
                usernameL.Text = " le nom d'utilisateur est trop court!";
            }
            else
                usernameL.Text = "";
            //controle saisie du nom d'utilisateur

            if (passwordt.Text == "")
            {
                passwordl.Text = "veuillez saisir le mot de passe !";
            }
            else if (passwordt.Text.Length < 4)
            {
                passwordl.Text = " le mot de passe est trés court!";
            }
            else if (passwordt.Text.Length > 4)
                passwordl.Text = "";
        }
        private void log_Click(object sender, EventArgs e)
        {


            verifier();
            if((namet.Text=="") || (surnamet.Text == "") || (usernamet.Text == "") || (passwordt.Text == ""))
            {
                MessageBox.Show("tous les champs sont indisponsables");
            }

            else
                try
                {
                    string connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand("insert into admin_login values ( @nom,@prenom,@username,@password)", conn);
                    cmd.Parameters.AddWithValue("@nom", namet.Text);
                    cmd.Parameters.AddWithValue("@prenom", surnamet.Text);
                    cmd.Parameters.AddWithValue("@username", usernamet.Text);
                    cmd.Parameters.AddWithValue("@password", passwordt.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    MessageBox.Show("utilisateur inserer avec succées !");
                    adapter.Fill(dt);
                    if(dt.Rows.Count > 0) 
                    {
                        namet.Text = "";
                        surnamet.Text = "";
                        usernamet.Text = "";
                        passwordt.Text = "";
                    }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            login c = new login();
            c.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel1);
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            namet.Text = "";
            surnamet.Text = "";
            usernamet.Text = "";
            passwordt.Text = "";
            noml.Text = "";
            prenoml.Text = "";
            usernameL.Text = "";
            passwordl.Text = "";
        }
          

        private void traduire_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HideSubMenu();
            rechercher_traduction c = new rechercher_traduction();
            this.Hide();
            c.Show();
        }

        private void utilisateur_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel2);
        }
    }
}
