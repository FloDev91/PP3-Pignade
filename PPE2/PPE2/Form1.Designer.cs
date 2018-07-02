namespace PPE2
{
    partial class Form1
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
            this.bt_GoToFenAjoutClient = new System.Windows.Forms.Button();
            this.bt_GoToFenAjoutPersonnel = new System.Windows.Forms.Button();
            this.bt_GoToFenAjoutActivite = new System.Windows.Forms.Button();
            this.bt_GoToFenActivite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_GoToFenAjoutClient
            // 
            this.bt_GoToFenAjoutClient.Location = new System.Drawing.Point(62, 158);
            this.bt_GoToFenAjoutClient.Name = "bt_GoToFenAjoutClient";
            this.bt_GoToFenAjoutClient.Size = new System.Drawing.Size(100, 42);
            this.bt_GoToFenAjoutClient.TabIndex = 0;
            this.bt_GoToFenAjoutClient.Text = "Gestion Client";
            this.bt_GoToFenAjoutClient.UseVisualStyleBackColor = true;
            this.bt_GoToFenAjoutClient.Click += new System.EventHandler(this.bt_GoToFenAjoutClient_Click);
            // 
            // bt_GoToFenAjoutPersonnel
            // 
            this.bt_GoToFenAjoutPersonnel.Location = new System.Drawing.Point(214, 158);
            this.bt_GoToFenAjoutPersonnel.Name = "bt_GoToFenAjoutPersonnel";
            this.bt_GoToFenAjoutPersonnel.Size = new System.Drawing.Size(104, 42);
            this.bt_GoToFenAjoutPersonnel.TabIndex = 1;
            this.bt_GoToFenAjoutPersonnel.Text = "Gestion Personnel";
            this.bt_GoToFenAjoutPersonnel.UseVisualStyleBackColor = true;
            this.bt_GoToFenAjoutPersonnel.Click += new System.EventHandler(this.bt_GoToFenAjoutPersonnel_Click);
            // 
            // bt_GoToFenAjoutActivite
            // 
            this.bt_GoToFenAjoutActivite.Location = new System.Drawing.Point(131, 231);
            this.bt_GoToFenAjoutActivite.Name = "bt_GoToFenAjoutActivite";
            this.bt_GoToFenAjoutActivite.Size = new System.Drawing.Size(104, 42);
            this.bt_GoToFenAjoutActivite.TabIndex = 3;
            this.bt_GoToFenAjoutActivite.Text = "Gestion Activité";
            this.bt_GoToFenAjoutActivite.UseVisualStyleBackColor = true;
            this.bt_GoToFenAjoutActivite.Click += new System.EventHandler(this.bt_GoToFenAjoutActivite_Click);
            // 
            // bt_GoToFenActivite
            // 
            this.bt_GoToFenActivite.Location = new System.Drawing.Point(131, 42);
            this.bt_GoToFenActivite.Name = "bt_GoToFenActivite";
            this.bt_GoToFenActivite.Size = new System.Drawing.Size(141, 74);
            this.bt_GoToFenActivite.TabIndex = 4;
            this.bt_GoToFenActivite.Text = "Inscription à une activité";
            this.bt_GoToFenActivite.UseVisualStyleBackColor = true;
            this.bt_GoToFenActivite.Click += new System.EventHandler(this.bt_GoToFenActivite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 335);
            this.Controls.Add(this.bt_GoToFenActivite);
            this.Controls.Add(this.bt_GoToFenAjoutActivite);
            this.Controls.Add(this.bt_GoToFenAjoutPersonnel);
            this.Controls.Add(this.bt_GoToFenAjoutClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_GoToFenAjoutClient;
        private System.Windows.Forms.Button bt_GoToFenAjoutPersonnel;
        private System.Windows.Forms.Button bt_GoToFenAjoutActivite;
        private System.Windows.Forms.Button bt_GoToFenActivite;
    }
}

