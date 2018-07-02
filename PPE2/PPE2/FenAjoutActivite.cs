using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE2
{
    public partial class FenAjoutActivite : Form
    {
        public FenAjoutActivite()
        {
            InitializeComponent();
        }

        private void FenAjoutActivite_Load(object sender, EventArgs e)
        {
            loadgridActivite(); //Appel de la fonction Loadgrid
            loadCBPersonnel();
        }

        public void loadgridActivite()
        {
            TableauListeActivite.Rows.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "select A.ID_Act, A.Nom_Act, A.Desc_Act, A.Place_Act, A.AgeMini_Act, A.AgeMax_Act, p.matricule_Perso, P.Nom_Perso from activite A, Personnel P WHERE P.Matricule_Perso = A.ID_Perso";
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        TableauListeActivite.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString(), Reader[7].ToString());
                    }
                }
            }

            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

            finally
            {
                connection.Close();
            }

        }

        public void loadCBPersonnel()
        {
            cbListePersonnel.Items.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "select Matricule_Perso, Prenom_Perso, Nom_Perso from personnel";
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        //cbListePersonnel.Items.Add(Reader[1].ToString());
                        cbListePersonnel.Items.Add(Reader[0].ToString() + ";" + Reader[1].ToString() + " " + Reader[2].ToString());
                    }
                }
            }

            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void btValidAjoutActivite_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "INSERT INTO activite (Nom_Act,Desc_Act,Place_Act,AgeMini_Act,AgeMax_Act, ID_Perso) VALUES (@NomActivite, @DescActivite, @PlaceActivite, @AgeMiniActivite, @AgeMaxActivite, @IDPerso)";
                myCommand.Parameters.AddWithValue("@NomActivite", tbNomActivite.Text);
                myCommand.Parameters.AddWithValue("@DescActivite", tbDescActivite.Text);
                myCommand.Parameters.AddWithValue("@PlaceActivite", tbPlaceActivite.Text);
                myCommand.Parameters.AddWithValue("@AgeMiniActivite", tbAgeMiniActivite.Text);
                myCommand.Parameters.AddWithValue("@AgeMaxActivite", tbAgeMaxActivite.Text);
                //myCommand.Parameters.AddWithValue("@IDPerso", cbListePersonnel.Text);
                myCommand.Parameters.AddWithValue("@IDPerso", cbListePersonnel.Text.Split(';')[0]);
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Activité créée", "OK");

            }

            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void btSuppTableauListeActivite_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM activite WHERE ID_Act ='" + TableauListeActivite.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Activité supprimée, veuillez recharcher", "OK");

            }

            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void btReloadTableauListeActivite_Click(object sender, EventArgs e)
        {
            loadgridActivite();
        }

        private void btModifTableauListeActivite_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "UPDATE activite SET Nom_Act = @NomActivite, Desc_Act = @DescActivite, Place_Act = @PlaceActivite, AgeMini_Act = @AgeMiniActivite, AgeMax_Act = @AgeMaxActivite, ID_Perso = @IDPerso WHERE ID_Act ='" + TableauListeActivite.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.Parameters.AddWithValue("@NomActivite", tbNomActivite.Text);
                myCommand.Parameters.AddWithValue("@DescActivite", tbDescActivite.Text);
                myCommand.Parameters.AddWithValue("@PlaceActivite", tbPlaceActivite.Text);
                myCommand.Parameters.AddWithValue("@AgeMiniActivite", tbAgeMiniActivite.Text);
                myCommand.Parameters.AddWithValue("@AgeMaxActivite", tbAgeMaxActivite.Text);
                myCommand.Parameters.AddWithValue("@IDPerso", cbListePersonnel.Text.Split(';')[0]);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Activité modifiée, veuillez recharger", "OK");

            }

            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void TableauListeActivite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbNomActivite.Text = TableauListeActivite.SelectedRows[0].Cells[1].Value.ToString();
            tbDescActivite.Text = TableauListeActivite.SelectedRows[0].Cells[2].Value.ToString();
            tbPlaceActivite.Text = TableauListeActivite.SelectedRows[0].Cells[3].Value.ToString();
            tbAgeMiniActivite.Text = TableauListeActivite.SelectedRows[0].Cells[4].Value.ToString();
            tbAgeMaxActivite.Text = TableauListeActivite.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void bt_BackToForm1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Tag = this;
            Form1.Show(this);
            Hide();
        }


    }
}
