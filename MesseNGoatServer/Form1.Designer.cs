﻿namespace MesseNGoatServer
{
    partial class Form1
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
            this.ServConv = new System.Windows.Forms.Panel();
            this.labelServerPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIsConnected = new System.Windows.Forms.Label();
            this.richTextBoxCommunications = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.buttonToShutDown = new System.Windows.Forms.Button();
            this.buttonSetUpServer = new System.Windows.Forms.Button();
            this.ServConv.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServConv
            // 
            this.ServConv.Controls.Add(this.labelServerPort);
            this.ServConv.Controls.Add(this.label2);
            this.ServConv.Controls.Add(this.labelIsConnected);
            this.ServConv.Controls.Add(this.richTextBoxCommunications);
            this.ServConv.Controls.Add(this.label1);
            this.ServConv.Controls.Add(this.labelServerIP);
            this.ServConv.Controls.Add(this.buttonToShutDown);
            this.ServConv.Controls.Add(this.buttonSetUpServer);
            this.ServConv.Location = new System.Drawing.Point(65, 48);
            this.ServConv.Name = "ServConv";
            this.ServConv.Size = new System.Drawing.Size(437, 225);
            this.ServConv.TabIndex = 0;
            // 
            // labelServerPort
            // 
            this.labelServerPort.AutoSize = true;
            this.labelServerPort.Location = new System.Drawing.Point(142, 61);
            this.labelServerPort.Name = "labelServerPort";
            this.labelServerPort.Size = new System.Drawing.Size(37, 13);
            this.labelServerPort.TabIndex = 8;
            this.labelServerPort.Text = "32123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port Serveur :";
            // 
            // labelIsConnected
            // 
            this.labelIsConnected.AutoSize = true;
            this.labelIsConnected.ForeColor = System.Drawing.Color.Black;
            this.labelIsConnected.Location = new System.Drawing.Point(326, 52);
            this.labelIsConnected.Name = "labelIsConnected";
            this.labelIsConnected.Size = new System.Drawing.Size(76, 13);
            this.labelIsConnected.TabIndex = 6;
            this.labelIsConnected.Text = " Disconnected";
            // 
            // richTextBoxCommunications
            // 
            this.richTextBoxCommunications.Location = new System.Drawing.Point(32, 112);
            this.richTextBoxCommunications.Name = "richTextBoxCommunications";
            this.richTextBoxCommunications.ReadOnly = true;
            this.richTextBoxCommunications.Size = new System.Drawing.Size(370, 96);
            this.richTextBoxCommunications.TabIndex = 5;
            this.richTextBoxCommunications.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Serveur :";
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(142, 31);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(0, 13);
            this.labelServerIP.TabIndex = 2;
            // 
            // buttonToShutDown
            // 
            this.buttonToShutDown.Location = new System.Drawing.Point(286, 73);
            this.buttonToShutDown.Name = "buttonToShutDown";
            this.buttonToShutDown.Size = new System.Drawing.Size(75, 23);
            this.buttonToShutDown.TabIndex = 1;
            this.buttonToShutDown.Text = "Stop";
            this.buttonToShutDown.UseVisualStyleBackColor = true;
            this.buttonToShutDown.Click += new System.EventHandler(this.buttonToShutDown_Click);
            // 
            // buttonSetUpServer
            // 
            this.buttonSetUpServer.Location = new System.Drawing.Point(286, 26);
            this.buttonSetUpServer.Name = "buttonSetUpServer";
            this.buttonSetUpServer.Size = new System.Drawing.Size(75, 23);
            this.buttonSetUpServer.TabIndex = 0;
            this.buttonSetUpServer.Text = "Start";
            this.buttonSetUpServer.UseVisualStyleBackColor = true;
            this.buttonSetUpServer.Click += new System.EventHandler(this.buttonSetUpServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 357);
            this.Controls.Add(this.ServConv);
            this.Name = "Form1";
            this.Text = "Server MesseNGoat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ServConv.ResumeLayout(false);
            this.ServConv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ServConv;
        private System.Windows.Forms.RichTextBox richTextBoxCommunications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Button buttonToShutDown;
        private System.Windows.Forms.Button buttonSetUpServer;
        private System.Windows.Forms.Label labelIsConnected;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.Label label2;
    }
}

