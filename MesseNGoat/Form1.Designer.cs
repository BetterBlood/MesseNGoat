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
            this.LoginResult = new System.Windows.Forms.Panel();
            this.ChatBox = new System.Windows.Forms.Panel();
            this.labelretourServeur = new System.Windows.Forms.Label();
            this.messageAEnvoyer = new System.Windows.Forms.TextBox();
            this.buttonForSending = new System.Windows.Forms.Button();
            this.Connexion = new System.Windows.Forms.Panel();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IPServeur = new System.Windows.Forms.Label();
            this.richTextBoxConversation = new System.Windows.Forms.RichTextBox();
            this.ChatBox.SuspendLayout();
            this.Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveLogin
            // 
            this.SaveLogin.Location = new System.Drawing.Point(755, 219);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(290, 371);
            this.SaveLogin.TabIndex = 0;
            // 
            // LoginResult
            // 
            this.LoginResult.Location = new System.Drawing.Point(428, 12);
            this.LoginResult.Name = "LoginResult";
            this.LoginResult.Size = new System.Drawing.Size(616, 192);
            this.LoginResult.TabIndex = 1;
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
            // richTextBoxConversation
            // 
            this.richTextBoxConversation.Location = new System.Drawing.Point(81, 66);
            this.richTextBoxConversation.Name = "richTextBoxConversation";
            this.richTextBoxConversation.Size = new System.Drawing.Size(419, 96);
            this.richTextBoxConversation.TabIndex = 3;
            this.richTextBoxConversation.Text = "";
            // 
            // MesseNGoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 602);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.LoginResult);
            this.Controls.Add(this.SaveLogin);
            this.Name = "MesseNGoat";
            this.Text = "MesseNGoat";
            this.ChatBox.ResumeLayout(false);
            this.ChatBox.PerformLayout();
            this.Connexion.ResumeLayout(false);
            this.Connexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SaveLogin;
        private System.Windows.Forms.Panel LoginResult;
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
    }
}

