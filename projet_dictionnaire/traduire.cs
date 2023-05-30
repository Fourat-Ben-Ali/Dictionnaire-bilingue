using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dictionnaire
{
    public partial class traduire : Form
    {
        public traduire()
        {
            InitializeComponent();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                mot.Text = "veillez saisir un mot dans la zone du texte ";
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
                            mot.Text = "ce mot n'existe pas";
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
                        c.execute_query("select mot_f as 'Traduction en français' ,anglais.type as 'Type',ex_f as 'Exemple' from anglais , francais\r\nwhere mot_a=@mot_a and anglais.mot_a=francais.traduction_a");
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
                        c.execute_query("select mot_a as 'MOT' , type as 'TYPE', ex_a as'EXEMPLE' from anglais where mot_a=@mot_a");
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

        private void utilisateur_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked=false; 
            radioButton3.Checked=false; 
            radioButton4.Checked=false;
            mot.Text = "";
            textBox1.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            vue_utilistateur vu = new vue_utilistateur();
            vu.Show();
            this.Hide();
        }

        private void traduire_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            ajouter t= new ajouter();   
            t.Show();   
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            supprimer t = new supprimer();
            t.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modifier m = new modifier();    
            m.Show();   
            this.Hide();    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extraire extraire  = new Extraire();
            extraire.Show();
            this.Hide();
        }
    }
}
