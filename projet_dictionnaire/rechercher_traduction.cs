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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projet_dictionnaire
{
    public partial class rechercher_traduction : Form
    {
        public rechercher_traduction()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel1);
        }

        private void login_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            login c = new login();
            this.Hide();
            c.Show();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            creer_admin c = new creer_admin();
            this.Hide();
            c.Show();
        }

        private void utilisateur_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                mot.Text="veillez saisir un mot dans la zone du texte ";
            }
            else
               try
                {
                    mot.Text = "";

                    connection_db c = new connection_db();

                    if (radioButton1.Checked && radioButton4.Checked)
                    {
                        c.execute_query("select mot_f as 'MOT' , type as'TYPE' , ex_f as 'EXEMPLE' from francais where mot_f=@mot_f");
                        c.add_sql_value("mot_f", textBox1.Text);
                        dataGridView1.DataSource = c.register();
                        if (c.table_rows() <= 0)
                        {
                            mot.Text="ce mot n'existe pas";
                        }
                        c.close_connection();
                        dataGridView1.Rows.Clear();
                    }
                    else if (radioButton1.Checked && radioButton3.Checked)
                    {
                        mot.Text = "";
                        c.execute_query("select   mot_a as 'Traduction du mot', anglais.type as 'Type',ex_a as 'Exemple'  from anglais, francais where francais.mot_f=anglais.traduction_f and francais.traduction_a=anglais.mot_a and mot_f=@mot_f");
                        c.add_sql_value("@mot_f", textBox1.Text);
                        dataGridView1.DataSource = c.register();
                        if (c.table_rows() <= 0)
                        {
                            MessageBox.Show("ce mot n'existe pas");
                        }
                        c.close_connection();
                        dataGridView1.Rows.Clear();
                    }
                    else if (radioButton2.Checked && radioButton4.Checked)
                    {
                        mot.Text = "";
                        c.execute_query("select mot_a, mot_f,anglais.type,ex_f,ex_a from anglais , francais\r\nwhere mot_a=@mot_a and anglais.mot_a=francais.traduction_a");
                        c.add_sql_value("@mot_a", textBox1.Text);
                        dataGridView1.DataSource = c.register();
                        if (c.table_rows() <= 0)
                        {
                            MessageBox.Show("ce mot n'existe pas");
                        }
                        c.close_connection();
                        dataGridView1.Rows.Clear();
                    }
                    else if (radioButton2.Checked && radioButton3.Checked)
                    {
                        mot.Text = "";
                        c.execute_query("select mot_a , type, ex_a from anglais where mot_a=@mot_a");
                        c.add_sql_value("@mot_a", textBox1.Text);
                        dataGridView1.DataSource = c.register();
                        if (c.table_rows() <= 0)
                        {
                            MessageBox.Show("ce mot n'existe pas");
                        }

                        c.close_connection();
                        dataGridView1.Rows.Clear();

                    }





                }




                catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
