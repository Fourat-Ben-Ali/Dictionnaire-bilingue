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
    public partial class vue_utilistateur : Form
    {
        public vue_utilistateur()
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vueutilistateur_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            login c = new login();
            this.Hide();
            c.Show();

        }

        private void subMenuPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            rechercher_traduction c = new rechercher_traduction();
            this.Hide();    
            c.Show();   
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
