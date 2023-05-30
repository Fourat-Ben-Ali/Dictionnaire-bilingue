using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dictionnaire
{
    public partial class vue_admin : Form
    {
        public vue_admin()
        {
            InitializeComponent();
        }

        private void traduire_Click(object sender, EventArgs e)
        {

        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            vue_utilistateur vu = new vue_utilistateur();   
            vu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void utilisateur_Click(object sender, EventArgs e)
        {
            traduire t = new traduire();
            t.Show();
            this.Hide();

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            ajouter t = new ajouter();
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
        {modifier modifier= new modifier(); 
            modifier.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extraire extraire = new Extraire();
            extraire.Show();
            this.Hide();
        }
    }
}
