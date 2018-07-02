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
    public partial class FenAjoutClient : Form
    {
        public FenAjoutClient()
        {
            InitializeComponent();
        }

        public void loadgridClient()
        {
            TableauListeClient.Rows.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "select * from client";
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        TableauListeClient.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString());
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

        private void FenAjoutClient_Load(object sender, EventArgs e)
        {
            loadgridClient(); //Appel de la fonction Loadgrid
        }

        private void btValidAjoutClient_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "INSERT INTO client (Nom_Client,prenom_Client,Age_Client) VALUES (@NomClient, @PrenomClient, @AgeClient)";
                myCommand.Parameters.AddWithValue("@NomClient", tbNomClient.Text);
                myCommand.Parameters.AddWithValue("@PrenomClient", tbPrenomClient.Text);
                myCommand.Parameters.AddWithValue("@AgeClient", tbAgeClient.Text);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Client Ajouté", "OK");

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

        private void btSuppTableauListeClient_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM client WHERE ID_Client ='" + TableauListeClient.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Client supprimé, veuillez recharcher", "OK");

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

        private void btReloadTableauListeClient_Click(object sender, EventArgs e)
        {
            loadgridClient();
        }

        private void btModifTableauListeClient_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "UPDATE client SET Nom_client = @Nomclient, Prenom_client = @PrenomClient, Age_Client = @AgeClient WHERE ID_Client ='" + TableauListeClient.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.Parameters.AddWithValue("@NomClient", tbNomClient.Text);
                myCommand.Parameters.AddWithValue("@PrenomClient", tbPrenomClient.Text);
                myCommand.Parameters.AddWithValue("@AgeClient", tbAgeClient.Text);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Client modifié, veuillez recharger", "OK");

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

        private void TableauListeClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbNomClient.Text = TableauListeClient.SelectedRows[0].Cells[1].Value.ToString();
            tbPrenomClient.Text = TableauListeClient.SelectedRows[0].Cells[2].Value.ToString();
            tbAgeClient.Text = TableauListeClient.SelectedRows[0].Cells[3].Value.ToString();
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
