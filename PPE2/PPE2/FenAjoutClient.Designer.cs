namespace PPE2
{
    partial class FenAjoutClient
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
            this.btModifTableauListeClient = new System.Windows.Forms.Button();
            this.btSuppTableauListeClient = new System.Windows.Forms.Button();
            this.btReloadTableauListeClient = new System.Windows.Forms.Button();
            this.TableauListeClient = new System.Windows.Forms.DataGridView();
            this.btValidAjoutClient = new System.Windows.Forms.Button();
            this.tbAgeClient = new System.Windows.Forms.TextBox();
            this.tbPrenomClient = new System.Windows.Forms.TextBox();
            this.tbNomClient = new System.Windows.Forms.TextBox();
            this.labelAgeClient = new System.Windows.Forms.Label();
            this.labelPrenomClient = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.TitreFenAjoutClient = new System.Windows.Forms.Label();
            this.bt_BackToForm1 = new System.Windows.Forms.Button();
            this.IDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableauListeClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btModifTableauListeClient
            // 
            this.btModifTableauListeClient.Location = new System.Drawing.Point(583, 329);
            this.btModifTableauListeClient.Name = "btModifTableauListeClient";
            this.btModifTableauListeClient.Size = new System.Drawing.Size(123, 32);
            this.btModifTableauListeClient.TabIndex = 21;
            this.btModifTableauListeClient.Text = "Modifier";
            this.btModifTableauListeClient.UseVisualStyleBackColor = true;
            this.btModifTableauListeClient.Click += new System.EventHandler(this.btModifTableauListeClient_Click);
            // 
            // btSuppTableauListeClient
            // 
            this.btSuppTableauListeClient.Location = new System.Drawing.Point(583, 381);
            this.btSuppTableauListeClient.Name = "btSuppTableauListeClient";
            this.btSuppTableauListeClient.Size = new System.Drawing.Size(123, 32);
            this.btSuppTableauListeClient.TabIndex = 20;
            this.btSuppTableauListeClient.Text = "Supprimer";
            this.btSuppTableauListeClient.UseVisualStyleBackColor = true;
            this.btSuppTableauListeClient.Click += new System.EventHandler(this.btSuppTableauListeClient_Click);
            // 
            // btReloadTableauListeClient
            // 
            this.btReloadTableauListeClient.Location = new System.Drawing.Point(583, 274);
            this.btReloadTableauListeClient.Name = "btReloadTableauListeClient";
            this.btReloadTableauListeClient.Size = new System.Drawing.Size(123, 32);
            this.btReloadTableauListeClient.TabIndex = 19;
            this.btReloadTableauListeClient.Text = "Recharger";
            this.btReloadTableauListeClient.UseVisualStyleBackColor = true;
            this.btReloadTableauListeClient.Click += new System.EventHandler(this.btReloadTableauListeClient_Click);
            // 
            // TableauListeClient
            // 
            this.TableauListeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauListeClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDClient,
            this.NomClient,
            this.PrenomClient,
            this.AgeClient});
            this.TableauListeClient.Location = new System.Drawing.Point(123, 237);
            this.TableauListeClient.Name = "TableauListeClient";
            this.TableauListeClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableauListeClient.Size = new System.Drawing.Size(454, 250);
            this.TableauListeClient.TabIndex = 18;
            this.TableauListeClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TableauListeClient_MouseDoubleClick);
            // 
            // btValidAjoutClient
            // 
            this.btValidAjoutClient.Location = new System.Drawing.Point(233, 195);
            this.btValidAjoutClient.Name = "btValidAjoutClient";
            this.btValidAjoutClient.Size = new System.Drawing.Size(75, 23);
            this.btValidAjoutClient.TabIndex = 17;
            this.btValidAjoutClient.Text = "Valider";
            this.btValidAjoutClient.UseVisualStyleBackColor = true;
            this.btValidAjoutClient.Click += new System.EventHandler(this.btValidAjoutClient_Click);
            // 
            // tbAgeClient
            // 
            this.tbAgeClient.Location = new System.Drawing.Point(233, 134);
            this.tbAgeClient.Name = "tbAgeClient";
            this.tbAgeClient.Size = new System.Drawing.Size(55, 20);
            this.tbAgeClient.TabIndex = 16;
            // 
            // tbPrenomClient
            // 
            this.tbPrenomClient.Location = new System.Drawing.Point(233, 108);
            this.tbPrenomClient.Name = "tbPrenomClient";
            this.tbPrenomClient.Size = new System.Drawing.Size(111, 20);
            this.tbPrenomClient.TabIndex = 15;
            // 
            // tbNomClient
            // 
            this.tbNomClient.Location = new System.Drawing.Point(233, 82);
            this.tbNomClient.Name = "tbNomClient";
            this.tbNomClient.Size = new System.Drawing.Size(114, 20);
            this.tbNomClient.TabIndex = 14;
            // 
            // labelAgeClient
            // 
            this.labelAgeClient.AutoSize = true;
            this.labelAgeClient.Location = new System.Drawing.Point(137, 134);
            this.labelAgeClient.Name = "labelAgeClient";
            this.labelAgeClient.Size = new System.Drawing.Size(63, 13);
            this.labelAgeClient.TabIndex = 13;
            this.labelAgeClient.Text = "Age client : ";
            // 
            // labelPrenomClient
            // 
            this.labelPrenomClient.AutoSize = true;
            this.labelPrenomClient.Location = new System.Drawing.Point(120, 108);
            this.labelPrenomClient.Name = "labelPrenomClient";
            this.labelPrenomClient.Size = new System.Drawing.Size(80, 13);
            this.labelPrenomClient.TabIndex = 12;
            this.labelPrenomClient.Text = "Prenom client : ";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(134, 82);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(66, 13);
            this.labelNomClient.TabIndex = 11;
            this.labelNomClient.Text = "Nom client : ";
            // 
            // TitreFenAjoutClient
            // 
            this.TitreFenAjoutClient.AutoSize = true;
            this.TitreFenAjoutClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenAjoutClient.Location = new System.Drawing.Point(316, 9);
            this.TitreFenAjoutClient.Name = "TitreFenAjoutClient";
            this.TitreFenAjoutClient.Size = new System.Drawing.Size(118, 25);
            this.TitreFenAjoutClient.TabIndex = 22;
            this.TitreFenAjoutClient.Text = "Ajout client";
            this.TitreFenAjoutClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_BackToForm1
            // 
            this.bt_BackToForm1.Location = new System.Drawing.Point(704, 537);
            this.bt_BackToForm1.Name = "bt_BackToForm1";
            this.bt_BackToForm1.Size = new System.Drawing.Size(81, 27);
            this.bt_BackToForm1.TabIndex = 23;
            this.bt_BackToForm1.Text = "Retour";
            this.bt_BackToForm1.UseVisualStyleBackColor = true;
            this.bt_BackToForm1.Click += new System.EventHandler(this.bt_BackToForm1_Click);
            // 
            // IDClient
            // 
            this.IDClient.HeaderText = "ID";
            this.IDClient.Name = "IDClient";
            this.IDClient.ReadOnly = true;
            // 
            // NomClient
            // 
            this.NomClient.HeaderText = "Nom";
            this.NomClient.Name = "NomClient";
            this.NomClient.ReadOnly = true;
            // 
            // PrenomClient
            // 
            this.PrenomClient.HeaderText = "Prenom";
            this.PrenomClient.Name = "PrenomClient";
            this.PrenomClient.ReadOnly = true;
            // 
            // AgeClient
            // 
            this.AgeClient.HeaderText = "Age";
            this.AgeClient.Name = "AgeClient";
            this.AgeClient.ReadOnly = true;
            // 
            // FenAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.Controls.Add(this.bt_BackToForm1);
            this.Controls.Add(this.TitreFenAjoutClient);
            this.Controls.Add(this.btModifTableauListeClient);
            this.Controls.Add(this.btSuppTableauListeClient);
            this.Controls.Add(this.btReloadTableauListeClient);
            this.Controls.Add(this.TableauListeClient);
            this.Controls.Add(this.btValidAjoutClient);
            this.Controls.Add(this.tbAgeClient);
            this.Controls.Add(this.tbPrenomClient);
            this.Controls.Add(this.tbNomClient);
            this.Controls.Add(this.labelAgeClient);
            this.Controls.Add(this.labelPrenomClient);
            this.Controls.Add(this.labelNomClient);
            this.Name = "FenAjoutClient";
            this.Text = "FenAjoutClient";
            this.Load += new System.EventHandler(this.FenAjoutClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableauListeClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btModifTableauListeClient;
        private System.Windows.Forms.Button btSuppTableauListeClient;
        private System.Windows.Forms.Button btReloadTableauListeClient;
        private System.Windows.Forms.DataGridView TableauListeClient;
        private System.Windows.Forms.Button btValidAjoutClient;
        private System.Windows.Forms.TextBox tbAgeClient;
        private System.Windows.Forms.TextBox tbPrenomClient;
        private System.Windows.Forms.TextBox tbNomClient;
        private System.Windows.Forms.Label labelAgeClient;
        private System.Windows.Forms.Label labelPrenomClient;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.Label TitreFenAjoutClient;
        private System.Windows.Forms.Button bt_BackToForm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeClient;

    }
}