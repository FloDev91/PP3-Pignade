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
    public partial class FenAjoutPersonnel : Form
    {
        public FenAjoutPersonnel()
        {
            InitializeComponent();
        }

        public void loadgridPerso()
        {
            TableauListePersonnel.Rows.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "select * from personnel";
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        TableauListePersonnel.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString());
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

        private void FenAjoutPersonnel_Load(object sender, EventArgs e)
        {
            loadgridPerso(); //Appel de la fonction Loadgrid
        }

        private void btValidAjoutPerso_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "INSERT INTO personnel (Nom_Perso,prenom_Perso,age_Perso) VALUES (@NomPerso, @PrenomPerso, @AgePerso)";
                myCommand.Parameters.AddWithValue("@NomPerso", tbNomPerso.Text);
                myCommand.Parameters.AddWithValue("@PrenomPerso", tbPrenomPerso.Text);
                myCommand.Parameters.AddWithValue("@AgePerso", tbAgePerso.Text);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("personne Ajouté", "OK");

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

        private void btSuppTableauListePersonnel_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM personnel WHERE Matricule_Perso ='" + TableauListePersonnel.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Personne supprimer, veuillez recharcher", "OK");

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

        private void btReloadTableauListePersonnel_Click(object sender, EventArgs e)
        {
            loadgridPerso();
        }

        private void btModifTableauListePersonnel_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "UPDATE personnel SET Nom_Perso = @NomPerso, prenom_Perso = @PrenomPerso, age_Perso = @AgePerso WHERE Matricule_Perso ='" + TableauListePersonnel.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.Parameters.AddWithValue("@NomPerso", tbNomPerso.Text);
                myCommand.Parameters.AddWithValue("@PrenomPerso", tbPrenomPerso.Text);
                myCommand.Parameters.AddWithValue("@AgePerso", tbAgePerso.Text);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("personne modifié, veuillez recharger", "OK");

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

        private void TableauListePersonnel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbNomPerso.Text = TableauListePersonnel.SelectedRows[0].Cells[1].Value.ToString();
            tbPrenomPerso.Text = TableauListePersonnel.SelectedRows[0].Cells[2].Value.ToString();
            tbAgePerso.Text = TableauListePersonnel.SelectedRows[0].Cells[3].Value.ToString();
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
