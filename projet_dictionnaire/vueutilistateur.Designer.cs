namespace projet_dictionnaire
{
    partial class vue_utilistateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.subMenuPanel2 = new System.Windows.Forms.Panel();
            this.traduire = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.utilisateur = new System.Windows.Forms.Button();
            this.subMenuPanel1 = new System.Windows.Forms.Panel();
            this.createaccount = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.subMenuPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.subMenuPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.subMenuPanel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.subMenuPanel1);
            this.panel1.Controls.Add(this.Admin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 416);
            this.panel1.TabIndex = 0;
            // 
            // subMenuPanel2
            // 
            this.subMenuPanel2.BackColor = System.Drawing.Color.White;
            this.subMenuPanel2.Controls.Add(this.traduire);
            this.subMenuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuPanel2.Location = new System.Drawing.Point(0, 275);
            this.subMenuPanel2.Name = "subMenuPanel2";
            this.subMenuPanel2.Size = new System.Drawing.Size(177, 42);
            this.subMenuPanel2.TabIndex = 5;
            this.subMenuPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // traduire
            // 
            this.traduire.Dock = System.Windows.Forms.DockStyle.Top;
            this.traduire.FlatAppearance.BorderSize = 0;
            this.traduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traduire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.traduire.Image = global::projet_dictionnaire.Properties.Resources.translate;
            this.traduire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.traduire.Location = new System.Drawing.Point(0, 0);
            this.traduire.Name = "traduire";
            this.traduire.Size = new System.Drawing.Size(177, 38);
            this.traduire.TabIndex = 0;
            this.traduire.Text = "Rechercher traduction";
            this.traduire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traduire.UseVisualStyleBackColor = true;
            this.traduire.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.utilisateur);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 47);
            this.panel4.TabIndex = 3;
            // 
            // utilisateur
            // 
            this.utilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.utilisateur.FlatAppearance.BorderSize = 0;
            this.utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilisateur.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.utilisateur.Location = new System.Drawing.Point(0, 0);
            this.utilisateur.Name = "utilisateur";
            this.utilisateur.Size = new System.Drawing.Size(177, 47);
            this.utilisateur.TabIndex = 4;
            this.utilisateur.Text = "Utilisateur";
            this.utilisateur.UseVisualStyleBackColor = true;
            this.utilisateur.Click += new System.EventHandler(this.utilisateur_Click);
            // 
            // subMenuPanel1
            // 
            this.subMenuPanel1.BackColor = System.Drawing.Color.White;
            this.subMenuPanel1.Controls.Add(this.createaccount);
            this.subMenuPanel1.Controls.Add(this.login);
            this.subMenuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subMenuPanel1.Location = new System.Drawing.Point(0, 147);
            this.subMenuPanel1.Name = "subMenuPanel1";
            this.subMenuPanel1.Size = new System.Drawing.Size(177, 81);
            this.subMenuPanel1.TabIndex = 2;
            this.subMenuPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.subMenuPanel1_Paint);
            // 
            // createaccount
            // 
            this.createaccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.createaccount.FlatAppearance.BorderSize = 0;
            this.createaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createaccount.Image = global::projet_dictionnaire.Properties.Resources.add_people_interface_symbol_of_black_person_close_up_with_plus_sign_in_small_circle;
            this.createaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createaccount.Location = new System.Drawing.Point(0, 38);
            this.createaccount.Name = "createaccount";
            this.createaccount.Size = new System.Drawing.Size(177, 41);
            this.createaccount.TabIndex = 1;
            this.createaccount.Text = "Créer un compte";
            this.createaccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createaccount.UseVisualStyleBackColor = true;
            this.createaccount.Click += new System.EventHandler(this.button3_Click);
            // 
            // login
            // 
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.Dock = System.Windows.Forms.DockStyle.Top;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Image = global::projet_dictionnaire.Properties.Resources.exit;
            this.login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(177, 38);
            this.login.TabIndex = 0;
            this.login.Text = "Se connecter";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin.Location = new System.Drawing.Point(0, 100);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(177, 47);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Administrateur";
            this.Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Admin.UseMnemonic = false;
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(196)))), ((int)(((byte)(148)))));
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 416);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Français - Anglais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue dans notre dictionnaire bilingue :\r\n\r\n";
            // 
            // vue_utilistateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 416);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(689, 455);
            this.Name = "vue_utilistateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vueutilistateur_Load);
            this.panel1.ResumeLayout(false);
            this.subMenuPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.subMenuPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel subMenuPanel2;
        private System.Windows.Forms.Button traduire;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button utilisateur;
        private System.Windows.Forms.Panel subMenuPanel1;
        private System.Windows.Forms.Button createaccount;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

