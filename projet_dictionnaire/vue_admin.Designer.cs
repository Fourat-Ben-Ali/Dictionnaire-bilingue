namespace projet_dictionnaire
{
    partial class vue_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createaccount = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.utilisateur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.createaccount);
            this.panel2.Controls.Add(this.Admin);
            this.panel2.Controls.Add(this.utilisateur);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 416);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modifier";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createaccount
            // 
            this.createaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.createaccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createaccount.FlatAppearance.BorderSize = 0;
            this.createaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(164)))), ((int)(((byte)(35)))));
            this.createaccount.Image = global::projet_dictionnaire.Properties.Resources.log_out;
            this.createaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createaccount.Location = new System.Drawing.Point(0, 375);
            this.createaccount.Name = "createaccount";
            this.createaccount.Size = new System.Drawing.Size(177, 41);
            this.createaccount.TabIndex = 1;
            this.createaccount.Text = "Se déconnecter";
            this.createaccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createaccount.UseVisualStyleBackColor = false;
            this.createaccount.Click += new System.EventHandler(this.createaccount_Click);
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
            this.Admin.Location = new System.Drawing.Point(0, 145);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(177, 47);
            this.Admin.TabIndex = 7;
            this.Admin.Text = "Ajouter";
            this.Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Admin.UseMnemonic = false;
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // utilisateur
            // 
            this.utilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.utilisateur.FlatAppearance.BorderSize = 0;
            this.utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilisateur.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.utilisateur.Location = new System.Drawing.Point(0, 98);
            this.utilisateur.Name = "utilisateur";
            this.utilisateur.Size = new System.Drawing.Size(177, 47);
            this.utilisateur.TabIndex = 4;
            this.utilisateur.Text = "Traduire";
            this.utilisateur.UseVisualStyleBackColor = true;
            this.utilisateur.Click += new System.EventHandler(this.utilisateur_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::projet_dictionnaire.Properties.Resources.admin__3_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 98);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 98);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(164)))), ((int)(((byte)(35)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue dans l\'espace adminstateur\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::projet_dictionnaire.Properties.Resources.books__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(177, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 318);
            this.panel4.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "Extraire données";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vue_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::projet_dictionnaire.Properties.Resources.books;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 416);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(689, 455);
            this.MinimumSize = new System.Drawing.Size(689, 455);
            this.Name = "vue_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vue_admin";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button utilisateur;
        private System.Windows.Forms.Button createaccount;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
    }
}