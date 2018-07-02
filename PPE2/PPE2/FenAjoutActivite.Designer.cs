namespace PPE2
{
    partial class FenAjoutActivite
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
            this.bt_BackToForm1 = new System.Windows.Forms.Button();
            this.TitreFenAjoutClient = new System.Windows.Forms.Label();
            this.btModifTableauListeActivite = new System.Windows.Forms.Button();
            this.btSuppTableauListeActivite = new System.Windows.Forms.Button();
            this.btReloadTableauListeActivite = new System.Windows.Forms.Button();
            this.TableauListeActivite = new System.Windows.Forms.DataGridView();
            this.IDActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeMiniActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeMaxiActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPersoAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPerso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btValidAjoutActivite = new System.Windows.Forms.Button();
            this.tbPlaceActivite = new System.Windows.Forms.TextBox();
            this.tbDescActivite = new System.Windows.Forms.TextBox();
            this.tbNomActivite = new System.Windows.Forms.TextBox();
            this.labelPlaceActivite = new System.Windows.Forms.Label();
            this.labelDescActivite = new System.Windows.Forms.Label();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.labelAgeMiniActivite = new System.Windows.Forms.Label();
            this.tbAgeMiniActivite = new System.Windows.Forms.TextBox();
            this.labelAgeMaxActivite = new System.Windows.Forms.Label();
            this.tbAgeMaxActivite = new System.Windows.Forms.TextBox();
            this.LabelListePersonnel = new System.Windows.Forms.Label();
            this.cbListePersonnel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableauListeActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_BackToForm1
            // 
            this.bt_BackToForm1.Location = new System.Drawing.Point(1014, 537);
            this.bt_BackToForm1.Name = "bt_BackToForm1";
            this.bt_BackToForm1.Size = new System.Drawing.Size(81, 27);
            this.bt_BackToForm1.TabIndex = 36;
            this.bt_BackToForm1.Text = "Retour";
            this.bt_BackToForm1.UseVisualStyleBackColor = true;
            this.bt_BackToForm1.Click += new System.EventHandler(this.bt_BackToForm1_Click);
            // 
            // TitreFenAjoutClient
            // 
            this.TitreFenAjoutClient.AutoSize = true;
            this.TitreFenAjoutClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenAjoutClient.Location = new System.Drawing.Point(507, 9);
            this.TitreFenAjoutClient.Name = "TitreFenAjoutClient";
            this.TitreFenAjoutClient.Size = new System.Drawing.Size(137, 25);
            this.TitreFenAjoutClient.TabIndex = 35;
            this.TitreFenAjoutClient.Text = "Ajout Activite";
            this.TitreFenAjoutClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btModifTableauListeActivite
            // 
            this.btModifTableauListeActivite.Location = new System.Drawing.Point(864, 366);
            this.btModifTableauListeActivite.Name = "btModifTableauListeActivite";
            this.btModifTableauListeActivite.Size = new System.Drawing.Size(123, 32);
            this.btModifTableauListeActivite.TabIndex = 34;
            this.btModifTableauListeActivite.Text = "Modifier";
            this.btModifTableauListeActivite.UseVisualStyleBackColor = true;
            this.btModifTableauListeActivite.Click += new System.EventHandler(this.btModifTableauListeActivite_Click);
            // 
            // btSuppTableauListeActivite
            // 
            this.btSuppTableauListeActivite.Location = new System.Drawing.Point(864, 415);
            this.btSuppTableauListeActivite.Name = "btSuppTableauListeActivite";
            this.btSuppTableauListeActivite.Size = new System.Drawing.Size(123, 32);
            this.btSuppTableauListeActivite.TabIndex = 33;
            this.btSuppTableauListeActivite.Text = "Supprimer";
            this.btSuppTableauListeActivite.UseVisualStyleBackColor = true;
            this.btSuppTableauListeActivite.Click += new System.EventHandler(this.btSuppTableauListeActivite_Click);
            // 
            // btReloadTableauListeActivite
            // 
            this.btReloadTableauListeActivite.Location = new System.Drawing.Point(864, 316);
            this.btReloadTableauListeActivite.Name = "btReloadTableauListeActivite";
            this.btReloadTableauListeActivite.Size = new System.Drawing.Size(123, 32);
            this.btReloadTableauListeActivite.TabIndex = 32;
            this.btReloadTableauListeActivite.Text = "Recharger";
            this.btReloadTableauListeActivite.UseVisualStyleBackColor = true;
            this.btReloadTableauListeActivite.Click += new System.EventHandler(this.btReloadTableauListeActivite_Click);
            // 
            // TableauListeActivite
            // 
            this.TableauListeActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauListeActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDActivite,
            this.NomActivite,
            this.DescActivite,
            this.PlaceActivite,
            this.AgeMiniActivite,
            this.AgeMaxiActivite,
            this.IDPersoAct,
            this.NomPerso});
            this.TableauListeActivite.Location = new System.Drawing.Point(12, 274);
            this.TableauListeActivite.Name = "TableauListeActivite";
            this.TableauListeActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableauListeActivite.Size = new System.Drawing.Size(846, 250);
            this.TableauListeActivite.TabIndex = 31;
            this.TableauListeActivite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TableauListeActivite_MouseDoubleClick);
            // 
            // IDActivite
            // 
            this.IDActivite.HeaderText = "ID";
            this.IDActivite.Name = "IDActivite";
            this.IDActivite.ReadOnly = true;
            // 
            // NomActivite
            // 
            this.NomActivite.HeaderText = "Nom";
            this.NomActivite.Name = "NomActivite";
            this.NomActivite.ReadOnly = true;
            // 
            // DescActivite
            // 
            this.DescActivite.HeaderText = "Description";
            this.DescActivite.Name = "DescActivite";
            this.DescActivite.ReadOnly = true;
            // 
            // PlaceActivite
            // 
            this.PlaceActivite.HeaderText = "Place max";
            this.PlaceActivite.Name = "PlaceActivite";
            // 
            // AgeMiniActivite
            // 
            this.AgeMiniActivite.HeaderText = "Age Minimum";
            this.AgeMiniActivite.Name = "AgeMiniActivite";
            this.AgeMiniActivite.ReadOnly = true;
            // 
            // AgeMaxiActivite
            // 
            this.AgeMaxiActivite.HeaderText = "Age Maximum ";
            this.AgeMaxiActivite.Name = "AgeMaxiActivite";
            // 
            // IDPersoAct
            // 
            this.IDPersoAct.HeaderText = "ID Personnel";
            this.IDPersoAct.Name = "IDPersoAct";
            // 
            // NomPerso
            // 
            this.NomPerso.HeaderText = "Personnel sur l\'activité ";
            this.NomPerso.Name = "NomPerso";
            // 
            // btValidAjoutActivite
            // 
            this.btValidAjoutActivite.Location = new System.Drawing.Point(233, 245);
            this.btValidAjoutActivite.Name = "btValidAjoutActivite";
            this.btValidAjoutActivite.Size = new System.Drawing.Size(75, 23);
            this.btValidAjoutActivite.TabIndex = 30;
            this.btValidAjoutActivite.Text = "Valider";
            this.btValidAjoutActivite.UseVisualStyleBackColor = true;
            this.btValidAjoutActivite.Click += new System.EventHandler(this.btValidAjoutActivite_Click);
            // 
            // tbPlaceActivite
            // 
            this.tbPlaceActivite.Location = new System.Drawing.Point(233, 134);
            this.tbPlaceActivite.Name = "tbPlaceActivite";
            this.tbPlaceActivite.Size = new System.Drawing.Size(55, 20);
            this.tbPlaceActivite.TabIndex = 29;
            // 
            // tbDescActivite
            // 
            this.tbDescActivite.Location = new System.Drawing.Point(233, 108);
            this.tbDescActivite.Name = "tbDescActivite";
            this.tbDescActivite.Size = new System.Drawing.Size(411, 20);
            this.tbDescActivite.TabIndex = 28;
            // 
            // tbNomActivite
            // 
            this.tbNomActivite.Location = new System.Drawing.Point(233, 82);
            this.tbNomActivite.Name = "tbNomActivite";
            this.tbNomActivite.Size = new System.Drawing.Size(114, 20);
            this.tbNomActivite.TabIndex = 27;
            // 
            // labelPlaceActivite
            // 
            this.labelPlaceActivite.AutoSize = true;
            this.labelPlaceActivite.Location = new System.Drawing.Point(130, 137);
            this.labelPlaceActivite.Name = "labelPlaceActivite";
            this.labelPlaceActivite.Size = new System.Drawing.Size(92, 13);
            this.labelPlaceActivite.TabIndex = 26;
            this.labelPlaceActivite.Text = "Places Maximum :";
            // 
            // labelDescActivite
            // 
            this.labelDescActivite.AutoSize = true;
            this.labelDescActivite.Location = new System.Drawing.Point(97, 111);
            this.labelDescActivite.Name = "labelDescActivite";
            this.labelDescActivite.Size = new System.Drawing.Size(125, 13);
            this.labelDescActivite.TabIndex = 25;
            this.labelDescActivite.Text = "Description de l\'activité : ";
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Location = new System.Drawing.Point(128, 85);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(94, 13);
            this.labelNomActivite.TabIndex = 24;
            this.labelNomActivite.Text = "Nom de l\'activite : ";
            // 
            // labelAgeMiniActivite
            // 
            this.labelAgeMiniActivite.AutoSize = true;
            this.labelAgeMiniActivite.Location = new System.Drawing.Point(144, 166);
            this.labelAgeMiniActivite.Name = "labelAgeMiniActivite";
            this.labelAgeMiniActivite.Size = new System.Drawing.Size(78, 13);
            this.labelAgeMiniActivite.TabIndex = 37;
            this.labelAgeMiniActivite.Text = "Age minimum : ";
            // 
            // tbAgeMiniActivite
            // 
            this.tbAgeMiniActivite.Location = new System.Drawing.Point(233, 163);
            this.tbAgeMiniActivite.Name = "tbAgeMiniActivite";
            this.tbAgeMiniActivite.Size = new System.Drawing.Size(55, 20);
            this.tbAgeMiniActivite.TabIndex = 38;
            // 
            // labelAgeMaxActivite
            // 
            this.labelAgeMaxActivite.AutoSize = true;
            this.labelAgeMaxActivite.Location = new System.Drawing.Point(294, 166);
            this.labelAgeMaxActivite.Name = "labelAgeMaxActivite";
            this.labelAgeMaxActivite.Size = new System.Drawing.Size(78, 13);
            this.labelAgeMaxActivite.TabIndex = 39;
            this.labelAgeMaxActivite.Text = "Age maximum :";
            // 
            // tbAgeMaxActivite
            // 
            this.tbAgeMaxActivite.Location = new System.Drawing.Point(378, 163);
            this.tbAgeMaxActivite.Name = "tbAgeMaxActivite";
            this.tbAgeMaxActivite.Size = new System.Drawing.Size(55, 20);
            this.tbAgeMaxActivite.TabIndex = 40;
            // 
            // LabelListePersonnel
            // 
            this.LabelListePersonnel.AutoSize = true;
            this.LabelListePersonnel.Location = new System.Drawing.Point(25, 205);
            this.LabelListePersonnel.Name = "LabelListePersonnel";
            this.LabelListePersonnel.Size = new System.Drawing.Size(197, 13);
            this.LabelListePersonnel.TabIndex = 41;
            this.LabelListePersonnel.Text = "Selectionner le personnel pour l\'activité :";
            // 
            // cbListePersonnel
            // 
            this.cbListePersonnel.FormattingEnabled = true;
            this.cbListePersonnel.Location = new System.Drawing.Point(233, 205);
            this.cbListePersonnel.Name = "cbListePersonnel";
            this.cbListePersonnel.Size = new System.Drawing.Size(200, 21);
            this.cbListePersonnel.TabIndex = 42;
            // 
            // FenAjoutActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 576);
            this.Controls.Add(this.cbListePersonnel);
            this.Controls.Add(this.LabelListePersonnel);
            this.Controls.Add(this.tbAgeMaxActivite);
            this.Controls.Add(this.labelAgeMaxActivite);
            this.Controls.Add(this.tbAgeMiniActivite);
            this.Controls.Add(this.labelAgeMiniActivite);
            this.Controls.Add(this.bt_BackToForm1);
            this.Controls.Add(this.TitreFenAjoutClient);
            this.Controls.Add(this.btModifTableauListeActivite);
            this.Controls.Add(this.btSuppTableauListeActivite);
            this.Controls.Add(this.btReloadTableauListeActivite);
            this.Controls.Add(this.TableauListeActivite);
            this.Controls.Add(this.btValidAjoutActivite);
            this.Controls.Add(this.tbPlaceActivite);
            this.Controls.Add(this.tbDescActivite);
            this.Controls.Add(this.tbNomActivite);
            this.Controls.Add(this.labelPlaceActivite);
            this.Controls.Add(this.labelDescActivite);
            this.Controls.Add(this.labelNomActivite);
            this.Name = "FenAjoutActivite";
            this.Text = "FenAjoutActivite";
            this.Load += new System.EventHandler(this.FenAjoutActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableauListeActivite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_BackToForm1;
        private System.Windows.Forms.Label TitreFenAjoutClient;
        private System.Windows.Forms.Button btModifTableauListeActivite;
        private System.Windows.Forms.Button btSuppTableauListeActivite;
        private System.Windows.Forms.Button btReloadTableauListeActivite;
        private System.Windows.Forms.DataGridView TableauListeActivite;
        private System.Windows.Forms.Button btValidAjoutActivite;
        private System.Windows.Forms.TextBox tbPlaceActivite;
        private System.Windows.Forms.TextBox tbDescActivite;
        private System.Windows.Forms.TextBox tbNomActivite;
        private System.Windows.Forms.Label labelPlaceActivite;
        private System.Windows.Forms.Label labelDescActivite;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.Label labelAgeMiniActivite;
        private System.Windows.Forms.TextBox tbAgeMiniActivite;
        private System.Windows.Forms.Label labelAgeMaxActivite;
        private System.Windows.Forms.TextBox tbAgeMaxActivite;
        private System.Windows.Forms.Label LabelListePersonnel;
        private System.Windows.Forms.ComboBox cbListePersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeMiniActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeMaxiActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPersoAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPerso;
    }
}