namespace MesseNGoat
{
    partial class MesseNGoat
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
            this.SaveLogin = new System.Windows.Forms.Panel();
            this.UserConnexion = new System.Windows.Forms.Panel();
            this.ChatBox = new System.Windows.Forms.Panel();
            this.richTextBoxConversation = new System.Windows.Forms.RichTextBox();
            this.labelretourServeur = new System.Windows.Forms.Label();
            this.messageAEnvoyer = new System.Windows.Forms.TextBox();
            this.buttonForSending = new System.Windows.Forms.Button();
            this.Connexion = new System.Windows.Forms.Panel();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IPServeur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SaveLogin.SuspendLayout();
            this.UserConnexion.SuspendLayout();
            this.ChatBox.SuspendLayout();
            this.Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveLogin
            // 
            this.SaveLogin.Controls.Add(this.radioButton1);
            this.SaveLogin.Controls.Add(this.button3);
            this.SaveLogin.Controls.Add(this.maskedTextBox1);
            this.SaveLogin.Controls.Add(this.textBox3);
            this.SaveLogin.Controls.Add(this.label6);
            this.SaveLogin.Controls.Add(this.label5);
            this.SaveLogin.Location = new System.Drawing.Point(755, 219);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(290, 371);
            this.SaveLogin.TabIndex = 0;
            // 
            // UserConnexion
            // 
            this.UserConnexion.Controls.Add(this.maskedTextBox2);
            this.UserConnexion.Controls.Add(this.label4);
            this.UserConnexion.Controls.Add(this.textBox1);
            this.UserConnexion.Controls.Add(this.label3);
            this.UserConnexion.Controls.Add(this.label1);
            this.UserConnexion.Controls.Add(this.button2);
            this.UserConnexion.Controls.Add(this.button1);
            this.UserConnexion.Location = new System.Drawing.Point(428, 12);
            this.UserConnexion.Name = "UserConnexion";
            this.UserConnexion.Size = new System.Drawing.Size(616, 192);
            this.UserConnexion.TabIndex = 1;
            // 
            // ChatBox
            // 
            this.ChatBox.Controls.Add(this.richTextBoxConversation);
            this.ChatBox.Controls.Add(this.labelretourServeur);
            this.ChatBox.Controls.Add(this.messageAEnvoyer);
            this.ChatBox.Controls.Add(this.buttonForSending);
            this.ChatBox.Location = new System.Drawing.Point(7, 219);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(728, 370);
            this.ChatBox.TabIndex = 2;
            // 
            // richTextBoxConversation
            // 
            this.richTextBoxConversation.Location = new System.Drawing.Point(81, 66);
            this.richTextBoxConversation.Name = "richTextBoxConversation";
            this.richTextBoxConversation.Size = new System.Drawing.Size(419, 96);
            this.richTextBoxConversation.TabIndex = 3;
            this.richTextBoxConversation.Text = "";
            // 
            // labelretourServeur
            // 
            this.labelretourServeur.AutoSize = true;
            this.labelretourServeur.Location = new System.Drawing.Point(78, 227);
            this.labelretourServeur.Name = "labelretourServeur";
            this.labelretourServeur.Size = new System.Drawing.Size(35, 13);
            this.labelretourServeur.TabIndex = 2;
            this.labelretourServeur.Text = "label1";
            // 
            // messageAEnvoyer
            // 
            this.messageAEnvoyer.Location = new System.Drawing.Point(81, 168);
            this.messageAEnvoyer.Name = "messageAEnvoyer";
            this.messageAEnvoyer.Size = new System.Drawing.Size(338, 20);
            this.messageAEnvoyer.TabIndex = 1;
            // 
            // buttonForSending
            // 
            this.buttonForSending.Location = new System.Drawing.Point(425, 165);
            this.buttonForSending.Name = "buttonForSending";
            this.buttonForSending.Size = new System.Drawing.Size(75, 23);
            this.buttonForSending.TabIndex = 0;
            this.buttonForSending.Text = "Envoyer";
            this.buttonForSending.UseVisualStyleBackColor = true;
            this.buttonForSending.Click += new System.EventHandler(this.buttonForSending_Click);
            // 
            // Connexion
            // 
            this.Connexion.BackgroundImage = global::MesseNGoat.Properties.Resources._110208;
            this.Connexion.Controls.Add(this.buttonConnexion);
            this.Connexion.Controls.Add(this.textBoxPort);
            this.Connexion.Controls.Add(this.textBoxIP);
            this.Connexion.Controls.Add(this.label2);
            this.Connexion.Controls.Add(this.IPServeur);
            this.Connexion.Location = new System.Drawing.Point(7, 12);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(401, 192);
            this.Connexion.TabIndex = 3;
            this.Connexion.Paint += new System.Windows.Forms.PaintEventHandler(this.Connexion_Paint);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(149, 119);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion.TabIndex = 4;
            this.buttonConnexion.Text = "connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(256, 75);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(28, 75);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // IPServeur
            // 
            this.IPServeur.AutoSize = true;
            this.IPServeur.Location = new System.Drawing.Point(43, 32);
            this.IPServeur.Name = "IPServeur";
            this.IPServeur.Size = new System.Drawing.Size(57, 13);
            this.IPServeur.TabIndex = 0;
            this.IPServeur.Text = "IP Serveur";
            this.IPServeur.Click += new System.EventHandler(this.IPServeur_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "new User ?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "connexion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "fail to connect !";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pseudo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mot de passe :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(158, 119);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(235, 102);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "s\'enregistrer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 184);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(231, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "J\'ai lu et accépté les conditions d\'utilisations";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MesseNGoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 602);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.UserConnexion);
            this.Controls.Add(this.SaveLogin);
            this.Name = "MesseNGoat";
            this.Text = "MesseNGoat";
            this.SaveLogin.ResumeLayout(false);
            this.SaveLogin.PerformLayout();
            this.UserConnexion.ResumeLayout(false);
            this.UserConnexion.PerformLayout();
            this.ChatBox.ResumeLayout(false);
            this.ChatBox.PerformLayout();
            this.Connexion.ResumeLayout(false);
            this.Connexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SaveLogin;
        private System.Windows.Forms.Panel UserConnexion;
        private System.Windows.Forms.Panel ChatBox;
        private System.Windows.Forms.Panel Connexion;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IPServeur;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.TextBox messageAEnvoyer;
        private System.Windows.Forms.Button buttonForSending;
        private System.Windows.Forms.Label labelretourServeur;
        private System.Windows.Forms.RichTextBox richTextBoxConversation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

