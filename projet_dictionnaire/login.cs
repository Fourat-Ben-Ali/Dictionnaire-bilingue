using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet_dictionnaire
{
    public partial class login : Form
    {
        public login()
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

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            username.Text = "";
            password.Text = "";
            usernameL.Text = "";
            passwordL.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subMenuPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel1);
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            creer_admin creer= new creer_admin();
            creer.Show();
            this.Hide();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                usernameL.Text = "entrer le nom d'utilisateur SVP!";
            }
            else if (password.Text == "")
            {
                passwordL.Text = "entrer votre mot de passe SVP!";
            }
            else if( (password.Text == "") && (username.Text == ""))
                    {
                usernameL.Text = "entrer le nom d'utilisateur SVP!";
                passwordL.Text = "entrer votre mot de passe SVP!";
            }
        
            else


                try
                {
                    string connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand("select * from admin_login where username=@username and password=@password", conn);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)

                    {
                        vue_admin va= new vue_admin();
                        va.Show();
                        this.Hide();

                    }
                    else { MessageBox.Show("Nom d'utilisateur ou mot de passe incorrecte !"); }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



        }

            private void usernameL_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

