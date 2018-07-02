namespace PPE2
{
    partial class FenAjoutPersonnel
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
            this.labelNomPerso = new System.Windows.Forms.Label();
            this.labelPrenomPerso = new System.Windows.Forms.Label();
            this.labelAgePerso = new System.Windows.Forms.Label();
            this.tbNomPerso = new System.Windows.Forms.TextBox();
            this.tbPrenomPerso = new System.Windows.Forms.TextBox();
            this.tbAgePerso = new System.Windows.Forms.TextBox();
            this.btValidAjoutPerso = new System.Windows.Forms.Button();
            this.TableauListePersonnel = new System.Windows.Forms.DataGridView();
            this.IDPerso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPerso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomPerso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgePerso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReloadTableauListePersonnel = new System.Windows.Forms.Button();
            this.btSuppTableauListePersonnel = new System.Windows.Forms.Button();
            this.btModifTableauListePersonnel = new System.Windows.Forms.Button();
            this.TitreFenAjoutPerso = new System.Windows.Forms.Label();
            this.bt_BackToForm1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableauListePersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomPerso
            // 
            this.labelNomPerso.AutoSize = true;
            this.labelNomPerso.Location = new System.Drawing.Point(137, 108);
            this.labelNomPerso.Name = "labelNomPerso";
            this.labelNomPerso.Size = new System.Drawing.Size(88, 13);
            this.labelNomPerso.TabIndex = 0;
            this.labelNomPerso.Text = "Nom Personnel : ";
            // 
            // labelPrenomPerso
            // 
            this.labelPrenomPerso.AutoSize = true;
            this.labelPrenomPerso.Location = new System.Drawing.Point(123, 134);
            this.labelPrenomPerso.Name = "labelPrenomPerso";
            this.labelPrenomPerso.Size = new System.Drawing.Size(102, 13);
            this.labelPrenomPerso.TabIndex = 1;
            this.labelPrenomPerso.Text = "Prenom Personnel : ";
            // 
            // labelAgePerso
            // 
            this.labelAgePerso.AutoSize = true;
            this.labelAgePerso.Location = new System.Drawing.Point(140, 160);
            this.labelAgePerso.Name = "labelAgePerso";
            this.labelAgePerso.Size = new System.Drawing.Size(85, 13);
            this.labelAgePerso.TabIndex = 2;
            this.labelAgePerso.Text = "Age Personnel : ";
            // 
            // tbNomPerso
            // 
            this.tbNomPerso.Location = new System.Drawing.Point(236, 108);
            this.tbNomPerso.Name = "tbNomPerso";
            this.tbNomPerso.Size = new System.Drawing.Size(114, 20);
            this.tbNomPerso.TabIndex = 3;
            // 
            // tbPrenomPerso
            // 
            this.tbPrenomPerso.Location = new System.Drawing.Point(236, 134);
            this.tbPrenomPerso.Name = "tbPrenomPerso";
            this.tbPrenomPerso.Size = new System.Drawing.Size(111, 20);
            this.tbPrenomPerso.TabIndex = 4;
            // 
            // tbAgePerso
            // 
            this.tbAgePerso.Location = new System.Drawing.Point(236, 160);
            this.tbAgePerso.Name = "tbAgePerso";
            this.tbAgePerso.Size = new System.Drawing.Size(55, 20);
            this.tbAgePerso.TabIndex = 5;
            // 
            // btValidAjoutPerso
            // 
            this.btValidAjoutPerso.Location = new System.Drawing.Point(236, 221);
            this.btValidAjoutPerso.Name = "btValidAjoutPerso";
            this.btValidAjoutPerso.Size = new System.Drawing.Size(75, 23);
            this.btValidAjoutPerso.TabIndex = 6;
            this.btValidAjoutPerso.Text = "Valider";
            this.btValidAjoutPerso.UseVisualStyleBackColor = true;
            this.btValidAjoutPerso.Click += new System.EventHandler(this.btValidAjoutPerso_Click);
            // 
            // TableauListePersonnel
            // 
            this.TableauListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauListePersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPerso,
            this.NomPerso,
            this.PrenomPerso,
            this.AgePerso});
            this.TableauListePersonnel.Location = new System.Drawing.Point(126, 263);
            this.TableauListePersonnel.Name = "TableauListePersonnel";
            this.TableauListePersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableauListePersonnel.Size = new System.Drawing.Size(454, 250);
            this.TableauListePersonnel.TabIndex = 7;
            this.TableauListePersonnel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TableauListePersonnel_MouseDoubleClick);
            // 
            // IDPerso
            // 
            this.IDPerso.HeaderText = "ID";
            this.IDPerso.Name = "IDPerso";
            this.IDPerso.ReadOnly = true;
            // 
            // NomPerso
            // 
            this.NomPerso.HeaderText = "Nom";
            this.NomPerso.Name = "NomPerso";
            this.NomPerso.ReadOnly = true;
            // 
            // PrenomPerso
            // 
            this.PrenomPerso.HeaderText = "Prenom";
            this.PrenomPerso.Name = "PrenomPerso";
            this.PrenomPerso.ReadOnly = true;
            // 
            // AgePerso
            // 
            this.AgePerso.HeaderText = "Age";
            this.AgePerso.Name = "AgePerso";
            this.AgePerso.ReadOnly = true;
            // 
            // btReloadTableauListePersonnel
            // 
            this.btReloadTableauListePersonnel.Location = new System.Drawing.Point(586, 300);
            this.btReloadTableauListePersonnel.Name = "btReloadTableauListePersonnel";
            this.btReloadTableauListePersonnel.Size = new System.Drawing.Size(123, 32);
            this.btReloadTableauListePersonnel.TabIndex = 8;
            this.btReloadTableauListePersonnel.Text = "Recharger";
            this.btReloadTableauListePersonnel.UseVisualStyleBackColor = true;
            this.btReloadTableauListePersonnel.Click += new System.EventHandler(this.btReloadTableauListePersonnel_Click);
            // 
            // btSuppTableauListePersonnel
            // 
            this.btSuppTableauListePersonnel.Location = new System.Drawing.Point(586, 407);
            this.btSuppTableauListePersonnel.Name = "btSuppTableauListePersonnel";
            this.btSuppTableauListePersonnel.Size = new System.Drawing.Size(123, 32);
            this.btSuppTableauListePersonnel.TabIndex = 9;
            this.btSuppTableauListePersonnel.Text = "Supprimer";
            this.btSuppTableauListePersonnel.UseVisualStyleBackColor = true;
            this.btSuppTableauListePersonnel.Click += new System.EventHandler(this.btSuppTableauListePersonnel_Click);
            // 
            // btModifTableauListePersonnel
            // 
            this.btModifTableauListePersonnel.Location = new System.Drawing.Point(586, 355);
            this.btModifTableauListePersonnel.Name = "btModifTableauListePersonnel";
            this.btModifTableauListePersonnel.Size = new System.Drawing.Size(123, 32);
            this.btModifTableauListePersonnel.TabIndex = 10;
            this.btModifTableauListePersonnel.Text = "Modifier";
            this.btModifTableauListePersonnel.UseVisualStyleBackColor = true;
            this.btModifTableauListePersonnel.Click += new System.EventHandler(this.btModifTableauListePersonnel_Click);
            // 
            // TitreFenAjoutPerso
            // 
            this.TitreFenAjoutPerso.AutoSize = true;
            this.TitreFenAjoutPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenAjoutPerso.Location = new System.Drawing.Point(313, 9);
            this.TitreFenAjoutPerso.Name = "TitreFenAjoutPerso";
            this.TitreFenAjoutPerso.Size = new System.Drawing.Size(164, 25);
            this.TitreFenAjoutPerso.TabIndex = 23;
            this.TitreFenAjoutPerso.Text = "Ajout Personnel";
            this.TitreFenAjoutPerso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_BackToForm1
            // 
            this.bt_BackToForm1.Location = new System.Drawing.Point(704, 537);
            this.bt_BackToForm1.Name = "bt_BackToForm1";
            this.bt_BackToForm1.Size = new System.Drawing.Size(81, 27);
            this.bt_BackToForm1.TabIndex = 24;
            this.bt_BackToForm1.Text = "Retour";
            this.bt_BackToForm1.UseVisualStyleBackColor = true;
            this.bt_BackToForm1.Click += new System.EventHandler(this.bt_BackToForm1_Click);
            // 
            // FenAjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.Controls.Add(this.bt_BackToForm1);
            this.Controls.Add(this.TitreFenAjoutPerso);
            this.Controls.Add(this.btModifTableauListePersonnel);
            this.Controls.Add(this.btSuppTableauListePersonnel);
            this.Controls.Add(this.btReloadTableauListePersonnel);
            this.Controls.Add(this.TableauListePersonnel);
            this.Controls.Add(this.btValidAjoutPerso);
            this.Controls.Add(this.tbAgePerso);
            this.Controls.Add(this.tbPrenomPerso);
            this.Controls.Add(this.tbNomPerso);
            this.Controls.Add(this.labelAgePerso);
            this.Controls.Add(this.labelPrenomPerso);
            this.Controls.Add(this.labelNomPerso);
            this.Name = "FenAjoutPersonnel";
            this.Text = "FenAjoutPersonnel";
            this.Load += new System.EventHandler(this.FenAjoutPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableauListePersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomPerso;
        private System.Windows.Forms.Label labelPrenomPerso;
        private System.Windows.Forms.Label labelAgePerso;
        private System.Windows.Forms.TextBox tbNomPerso;
        private System.Windows.Forms.TextBox tbPrenomPerso;
        private System.Windows.Forms.TextBox tbAgePerso;
        private System.Windows.Forms.Button btValidAjoutPerso;
        private System.Windows.Forms.DataGridView TableauListePersonnel;
        private System.Windows.Forms.Button btReloadTableauListePersonnel;
        private System.Windows.Forms.Button btSuppTableauListePersonnel;
        private System.Windows.Forms.Button btModifTableauListePersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPerso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPerso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomPerso;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgePerso;
        private System.Windows.Forms.Label TitreFenAjoutPerso;
        private System.Windows.Forms.Button bt_BackToForm1;
    }
}