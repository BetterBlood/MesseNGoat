﻿namespace MesseNGoat
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
            this.components = new System.ComponentModel.Container();
            this.SaveLogin = new System.Windows.Forms.Panel();
            this.mdpPower = new System.Windows.Forms.Label();
            this.returnToUserConnexion = new System.Windows.Forms.Button();
            this.conditionsUtilisation = new System.Windows.Forms.RadioButton();
            this.accountCreationButton = new System.Windows.Forms.Button();
            this.userNameCreationbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserConnexion = new System.Windows.Forms.Panel();
            this.disconnectFromServerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.userPseudoTestBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userConnexionButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.richTextBoxConversation = new System.Windows.Forms.RichTextBox();
            this.labelretourServeur = new System.Windows.Forms.Label();
            this.messageAEnvoyer = new System.Windows.Forms.TextBox();
            this.buttonForSending = new System.Windows.Forms.Button();
            this.Connexion = new System.Windows.Forms.Panel();
            this.connexionToServeurButton = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IPServeur = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userMdpTextBox = new System.Windows.Forms.TextBox();
            this.userMdpCreationBox = new System.Windows.Forms.TextBox();
            this.SaveLogin.SuspendLayout();
            this.UserConnexion.SuspendLayout();
            this.ChatBox.SuspendLayout();
            this.Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveLogin
            // 
            this.SaveLogin.Controls.Add(this.userMdpCreationBox);
            this.SaveLogin.Controls.Add(this.mdpPower);
            this.SaveLogin.Controls.Add(this.returnToUserConnexion);
            this.SaveLogin.Controls.Add(this.conditionsUtilisation);
            this.SaveLogin.Controls.Add(this.accountCreationButton);
            this.SaveLogin.Controls.Add(this.userNameCreationbox);
            this.SaveLogin.Controls.Add(this.label6);
            this.SaveLogin.Controls.Add(this.label5);
            this.SaveLogin.Location = new System.Drawing.Point(755, 219);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(290, 335);
            this.SaveLogin.TabIndex = 0;
            // 
            // mdpPower
            // 
            this.mdpPower.AutoSize = true;
            this.mdpPower.Location = new System.Drawing.Point(210, 175);
            this.mdpPower.Name = "mdpPower";
            this.mdpPower.Size = new System.Drawing.Size(32, 13);
            this.mdpPower.TabIndex = 8;
            this.mdpPower.Text = "faible";
            // 
            // returnToUserConnexion
            // 
            this.returnToUserConnexion.Location = new System.Drawing.Point(83, 19);
            this.returnToUserConnexion.Name = "returnToUserConnexion";
            this.returnToUserConnexion.Size = new System.Drawing.Size(114, 23);
            this.returnToUserConnexion.TabIndex = 7;
            this.returnToUserConnexion.Text = "page de connexion";
            this.returnToUserConnexion.UseVisualStyleBackColor = true;
            this.returnToUserConnexion.Click += new System.EventHandler(this.returnToUserConnexion_Click);
            // 
            // conditionsUtilisation
            // 
            this.conditionsUtilisation.AutoSize = true;
            this.conditionsUtilisation.Location = new System.Drawing.Point(40, 223);
            this.conditionsUtilisation.Name = "conditionsUtilisation";
            this.conditionsUtilisation.Size = new System.Drawing.Size(231, 17);
            this.conditionsUtilisation.TabIndex = 6;
            this.conditionsUtilisation.TabStop = true;
            this.conditionsUtilisation.Text = "J\'ai lu et accepté les conditions d\'utilisations";
            this.conditionsUtilisation.UseVisualStyleBackColor = true;
            // 
            // accountCreationButton
            // 
            this.accountCreationButton.Location = new System.Drawing.Point(103, 279);
            this.accountCreationButton.Name = "accountCreationButton";
            this.accountCreationButton.Size = new System.Drawing.Size(75, 23);
            this.accountCreationButton.TabIndex = 5;
            this.accountCreationButton.Text = "s\'enregistrer";
            this.accountCreationButton.UseVisualStyleBackColor = true;
            // 
            // userNameCreationbox
            // 
            this.userNameCreationbox.Location = new System.Drawing.Point(158, 85);
            this.userNameCreationbox.Name = "userNameCreationbox";
            this.userNameCreationbox.Size = new System.Drawing.Size(100, 20);
            this.userNameCreationbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pseudo :";
            // 
            // UserConnexion
            // 
            this.UserConnexion.Controls.Add(this.userMdpTextBox);
            this.UserConnexion.Controls.Add(this.disconnectFromServerButton);
            this.UserConnexion.Controls.Add(this.label4);
            this.UserConnexion.Controls.Add(this.userPseudoTestBox);
            this.UserConnexion.Controls.Add(this.label3);
            this.UserConnexion.Controls.Add(this.label1);
            this.UserConnexion.Controls.Add(this.userConnexionButton);
            this.UserConnexion.Controls.Add(this.newUserButton);
            this.UserConnexion.Location = new System.Drawing.Point(428, 12);
            this.UserConnexion.Name = "UserConnexion";
            this.UserConnexion.Size = new System.Drawing.Size(616, 192);
            this.UserConnexion.TabIndex = 1;
            // 
            // disconnectFromServerButton
            // 
            this.disconnectFromServerButton.Location = new System.Drawing.Point(458, 13);
            this.disconnectFromServerButton.Name = "disconnectFromServerButton";
            this.disconnectFromServerButton.Size = new System.Drawing.Size(140, 23);
            this.disconnectFromServerButton.TabIndex = 8;
            this.disconnectFromServerButton.Text = "Quitter le serveur";
            this.disconnectFromServerButton.UseVisualStyleBackColor = true;
            this.disconnectFromServerButton.Click += new System.EventHandler(this.disconnectFromServerButton_Click);
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
            // userPseudoTestBox
            // 
            this.userPseudoTestBox.Location = new System.Drawing.Point(235, 61);
            this.userPseudoTestBox.Name = "userPseudoTestBox";
            this.userPseudoTestBox.Size = new System.Drawing.Size(100, 20);
            this.userPseudoTestBox.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo :";
            // 
            // userConnexionButton
            // 
            this.userConnexionButton.Location = new System.Drawing.Point(410, 61);
            this.userConnexionButton.Name = "userConnexionButton";
            this.userConnexionButton.Size = new System.Drawing.Size(95, 61);
            this.userConnexionButton.TabIndex = 1;
            this.userConnexionButton.Text = "connexion";
            this.userConnexionButton.UseVisualStyleBackColor = true;
            this.userConnexionButton.Click += new System.EventHandler(this.userConnexionButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(250, 138);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(75, 23);
            this.newUserButton.TabIndex = 0;
            this.newUserButton.Text = "new User ?";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.Controls.Add(this.logOutButton);
            this.ChatBox.Controls.Add(this.richTextBoxConversation);
            this.ChatBox.Controls.Add(this.labelretourServeur);
            this.ChatBox.Controls.Add(this.messageAEnvoyer);
            this.ChatBox.Controls.Add(this.buttonForSending);
            this.ChatBox.Location = new System.Drawing.Point(7, 219);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(727, 274);
            this.ChatBox.TabIndex = 2;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(590, 19);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(119, 23);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Se déconnecter";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
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
            this.Connexion.Controls.Add(this.connexionToServeurButton);
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
            // connexionToServeurButton
            // 
            this.connexionToServeurButton.Location = new System.Drawing.Point(149, 119);
            this.connexionToServeurButton.Name = "connexionToServeurButton";
            this.connexionToServeurButton.Size = new System.Drawing.Size(75, 23);
            this.connexionToServeurButton.TabIndex = 4;
            this.connexionToServeurButton.Text = "connexion";
            this.connexionToServeurButton.UseVisualStyleBackColor = true;
            this.connexionToServeurButton.Click += new System.EventHandler(this.connexionToServeurButton_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userMdpTextBox
            // 
            this.userMdpTextBox.Location = new System.Drawing.Point(235, 99);
            this.userMdpTextBox.Name = "userMdpTextBox";
            this.userMdpTextBox.Size = new System.Drawing.Size(100, 20);
            this.userMdpTextBox.TabIndex = 9;
            // 
            // userMdpCreationBox
            // 
            this.userMdpCreationBox.Location = new System.Drawing.Point(158, 146);
            this.userMdpCreationBox.Name = "userMdpCreationBox";
            this.userMdpCreationBox.Size = new System.Drawing.Size(100, 20);
            this.userMdpCreationBox.TabIndex = 9;
            // 
            // MesseNGoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 564);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.UserConnexion);
            this.Controls.Add(this.SaveLogin);
            this.Name = "MesseNGoat";
            this.Text = "MesseNGoat";
            this.Load += new System.EventHandler(this.MesseNGoat_Load);
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
        private System.Windows.Forms.Button connexionToServeurButton;
        private System.Windows.Forms.TextBox messageAEnvoyer;
        private System.Windows.Forms.Button buttonForSending;
        private System.Windows.Forms.Label labelretourServeur;
        private System.Windows.Forms.RichTextBox richTextBoxConversation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userPseudoTestBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userConnexionButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.TextBox userNameCreationbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton conditionsUtilisation;
        private System.Windows.Forms.Button accountCreationButton;
        private System.Windows.Forms.Button disconnectFromServerButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button returnToUserConnexion;
        private System.Windows.Forms.Label mdpPower;
        private System.Windows.Forms.TextBox userMdpCreationBox;
        private System.Windows.Forms.TextBox userMdpTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

