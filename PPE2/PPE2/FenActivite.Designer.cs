namespace PPE2
{
    partial class FenActivite
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
            this.TitreFenActivite = new System.Windows.Forms.Label();
            this.cbListeActivite = new System.Windows.Forms.ComboBox();
            this.labelListeActivite = new System.Windows.Forms.Label();
            this.cbListeClient = new System.Windows.Forms.ComboBox();
            this.lbListeClient = new System.Windows.Forms.Label();
            this.bt_BackToForm1 = new System.Windows.Forms.Button();
            this.TableauListeReservation = new System.Windows.Forms.DataGridView();
            this.ID_Resa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btValidAjoutReservation = new System.Windows.Forms.Button();
            this.btReloadTableauListeActivite = new System.Windows.Forms.Button();
            this.btSuppTableauListeActivite = new System.Windows.Forms.Button();
            this.TableauRecapResa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Act_Recap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place_Act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbResa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableauListeReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableauRecapResa)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreFenActivite
            // 
            this.TitreFenActivite.AutoSize = true;
            this.TitreFenActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreFenActivite.Location = new System.Drawing.Point(266, 9);
            this.TitreFenActivite.Name = "TitreFenActivite";
            this.TitreFenActivite.Size = new System.Drawing.Size(244, 25);
            this.TitreFenActivite.TabIndex = 24;
            this.TitreFenActivite.Text = "Inscription à une activité";
            this.TitreFenActivite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbListeActivite
            // 
            this.cbListeActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListeActivite.FormattingEnabled = true;
            this.cbListeActivite.Location = new System.Drawing.Point(258, 163);
            this.cbListeActivite.Name = "cbListeActivite";
            this.cbListeActivite.Size = new System.Drawing.Size(252, 23);
            this.cbListeActivite.TabIndex = 25;
            this.cbListeActivite.Click += new System.EventHandler(this.cbListeActivite_Click);
            // 
            // labelListeActivite
            // 
            this.labelListeActivite.AutoSize = true;
            this.labelListeActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeActivite.Location = new System.Drawing.Point(20, 166);
            this.labelListeActivite.Name = "labelListeActivite";
            this.labelListeActivite.Size = new System.Drawing.Size(209, 20);
            this.labelListeActivite.TabIndex = 26;
            this.labelListeActivite.Text = "Liste des activités disponible";
            // 
            // cbListeClient
            // 
            this.cbListeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListeClient.FormattingEnabled = true;
            this.cbListeClient.Location = new System.Drawing.Point(258, 233);
            this.cbListeClient.Name = "cbListeClient";
            this.cbListeClient.Size = new System.Drawing.Size(252, 23);
            this.cbListeClient.TabIndex = 27;
            this.cbListeClient.Click += new System.EventHandler(this.cbListeClient_Click);
            // 
            // lbListeClient
            // 
            this.lbListeClient.AutoSize = true;
            this.lbListeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListeClient.Location = new System.Drawing.Point(12, 233);
            this.lbListeClient.Name = "lbListeClient";
            this.lbListeClient.Size = new System.Drawing.Size(217, 20);
            this.lbListeClient.TabIndex = 28;
            this.lbListeClient.Text = "Veuillez selectionner un client";
            // 
            // bt_BackToForm1
            // 
            this.bt_BackToForm1.Location = new System.Drawing.Point(995, 555);
            this.bt_BackToForm1.Name = "bt_BackToForm1";
            this.bt_BackToForm1.Size = new System.Drawing.Size(81, 27);
            this.bt_BackToForm1.TabIndex = 29;
            this.bt_BackToForm1.Text = "Retour";
            this.bt_BackToForm1.UseVisualStyleBackColor = true;
            this.bt_BackToForm1.Click += new System.EventHandler(this.bt_BackToForm1_Click);
            // 
            // TableauListeReservation
            // 
            this.TableauListeReservation.AllowUserToAddRows = false;
            this.TableauListeReservation.AllowUserToDeleteRows = false;
            this.TableauListeReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauListeReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Resa,
            this.ID_Act,
            this.Nom_Act,
            this.ID_Client,
            this.Nom_Client});
            this.TableauListeReservation.Location = new System.Drawing.Point(63, 336);
            this.TableauListeReservation.Name = "TableauListeReservation";
            this.TableauListeReservation.ReadOnly = true;
            this.TableauListeReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableauListeReservation.Size = new System.Drawing.Size(543, 211);
            this.TableauListeReservation.TabIndex = 30;
            this.TableauListeReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableauListeReservation_CellContentClick);
            // 
            // ID_Resa
            // 
            this.ID_Resa.HeaderText = "ID Reservation";
            this.ID_Resa.Name = "ID_Resa";
            this.ID_Resa.ReadOnly = true;
            // 
            // ID_Act
            // 
            this.ID_Act.HeaderText = "ID Activite";
            this.ID_Act.Name = "ID_Act";
            this.ID_Act.ReadOnly = true;
            // 
            // Nom_Act
            // 
            this.Nom_Act.HeaderText = "Nom Activite";
            this.Nom_Act.Name = "Nom_Act";
            this.Nom_Act.ReadOnly = true;
            // 
            // ID_Client
            // 
            this.ID_Client.HeaderText = "ID Client";
            this.ID_Client.Name = "ID_Client";
            this.ID_Client.ReadOnly = true;
            // 
            // Nom_Client
            // 
            this.Nom_Client.HeaderText = "Nom Client";
            this.Nom_Client.Name = "Nom_Client";
            this.Nom_Client.ReadOnly = true;
            // 
            // btValidAjoutReservation
            // 
            this.btValidAjoutReservation.Location = new System.Drawing.Point(336, 293);
            this.btValidAjoutReservation.Name = "btValidAjoutReservation";
            this.btValidAjoutReservation.Size = new System.Drawing.Size(75, 23);
            this.btValidAjoutReservation.TabIndex = 31;
            this.btValidAjoutReservation.Text = "Valider";
            this.btValidAjoutReservation.UseVisualStyleBackColor = true;
            this.btValidAjoutReservation.Click += new System.EventHandler(this.btValidAjoutReservation_Click);
            // 
            // btReloadTableauListeActivite
            // 
            this.btReloadTableauListeActivite.Location = new System.Drawing.Point(612, 367);
            this.btReloadTableauListeActivite.Name = "btReloadTableauListeActivite";
            this.btReloadTableauListeActivite.Size = new System.Drawing.Size(123, 32);
            this.btReloadTableauListeActivite.TabIndex = 33;
            this.btReloadTableauListeActivite.Text = "Recharger";
            this.btReloadTableauListeActivite.UseVisualStyleBackColor = true;
            this.btReloadTableauListeActivite.Click += new System.EventHandler(this.btReloadTableauListeActivite_Click);
            // 
            // btSuppTableauListeActivite
            // 
            this.btSuppTableauListeActivite.Location = new System.Drawing.Point(612, 452);
            this.btSuppTableauListeActivite.Name = "btSuppTableauListeActivite";
            this.btSuppTableauListeActivite.Size = new System.Drawing.Size(123, 32);
            this.btSuppTableauListeActivite.TabIndex = 34;
            this.btSuppTableauListeActivite.Text = "Supprimer";
            this.btSuppTableauListeActivite.UseVisualStyleBackColor = true;
            this.btSuppTableauListeActivite.Click += new System.EventHandler(this.btSuppTableauListeActivite_Click);
            // 
            // TableauRecapResa
            // 
            this.TableauRecapResa.AllowUserToAddRows = false;
            this.TableauRecapResa.AllowUserToDeleteRows = false;
            this.TableauRecapResa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauRecapResa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nom_Act_Recap,
            this.Place_Act,
            this.NbResa});
            this.TableauRecapResa.Location = new System.Drawing.Point(612, 117);
            this.TableauRecapResa.Name = "TableauRecapResa";
            this.TableauRecapResa.ReadOnly = true;
            this.TableauRecapResa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableauRecapResa.Size = new System.Drawing.Size(447, 199);
            this.TableauRecapResa.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Activité";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Nom_Act_Recap
            // 
            this.Nom_Act_Recap.HeaderText = "Nom activite";
            this.Nom_Act_Recap.Name = "Nom_Act_Recap";
            this.Nom_Act_Recap.ReadOnly = true;
            // 
            // Place_Act
            // 
            this.Place_Act.HeaderText = "Place Maximum";
            this.Place_Act.Name = "Place_Act";
            this.Place_Act.ReadOnly = true;
            // 
            // NbResa
            // 
            this.NbResa.HeaderText = "Nombre reservation";
            this.NbResa.Name = "NbResa";
            this.NbResa.ReadOnly = true;
            // 
            // FenActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 594);
            this.Controls.Add(this.TableauRecapResa);
            this.Controls.Add(this.btSuppTableauListeActivite);
            this.Controls.Add(this.btReloadTableauListeActivite);
            this.Controls.Add(this.btValidAjoutReservation);
            this.Controls.Add(this.TableauListeReservation);
            this.Controls.Add(this.bt_BackToForm1);
            this.Controls.Add(this.lbListeClient);
            this.Controls.Add(this.cbListeClient);
            this.Controls.Add(this.labelListeActivite);
            this.Controls.Add(this.cbListeActivite);
            this.Controls.Add(this.TitreFenActivite);
            this.Name = "FenActivite";
            this.Text = "FenActivite";
            this.Load += new System.EventHandler(this.FenActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableauListeReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableauRecapResa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreFenActivite;
        private System.Windows.Forms.ComboBox cbListeActivite;
        private System.Windows.Forms.Label labelListeActivite;
        private System.Windows.Forms.ComboBox cbListeClient;
        private System.Windows.Forms.Label lbListeClient;
        private System.Windows.Forms.Button bt_BackToForm1;
        private System.Windows.Forms.DataGridView TableauListeReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Resa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Act;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Act;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Client;
        private System.Windows.Forms.Button btValidAjoutReservation;
        private System.Windows.Forms.Button btReloadTableauListeActivite;
        private System.Windows.Forms.Button btSuppTableauListeActivite;
        private System.Windows.Forms.DataGridView TableauRecapResa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Act_Recap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place_Act;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbResa;
    }
}