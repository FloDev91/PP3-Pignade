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
    public partial class FenActivite : Form
    {
        public FenActivite()
        {
            InitializeComponent();
        }

        public void loadCBActivite()
        {
            cbListeActivite.Items.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                if (cbListeClient.Text.ToString() == "")
                {
                    myCommand.CommandText = "SELECT Id_Act, Nom_Act FROM activite WHERE Place_Act > @NbResa ";
                    myCommand.Parameters.AddWithValue("@NbResa", TableauRecapResa.Rows[0].Cells[3].Value.ToString());
                }

                else
                {
                    myCommand.CommandText = "SELECT Id_Act, Nom_Act FROM activite A,client C WHERE ID_Client = @Id_Client AND C.Age_Client BETWEEN A.AgeMini_Act AND A.AgeMax_Act  ";
                    myCommand.Parameters.AddWithValue("@Id_Client", cbListeClient.Text.Split(';')[0]);
                    
                }
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        //cbListePersonnel.Items.Add(Reader[1].ToString());
                        cbListeActivite.Items.Add(Reader[0].ToString() + ";" + Reader[1].ToString());
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

        public void loadCBClient()
        {
            cbListeClient.Items.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                if (cbListeActivite.Text.ToString() == "")
                {
                myCommand.CommandText = "select ID_Client, Prenom_Client, Nom_Client FROM client ";
                }
                else
                {
                myCommand.CommandText = "select ID_Client, Prenom_Client, Nom_Client FROM activite A,client C WHERE ID_Act = @ID_Act AND C.Age_Client BETWEEN A.AgeMini_Act AND A.AgeMax_Act ";
                myCommand.Parameters.AddWithValue("@ID_Act", cbListeActivite.Text.Split(';')[0]);
                }
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        //cbListePersonnel.Items.Add(Reader[1].ToString());
                        cbListeClient.Items.Add(Reader[0].ToString() + ";" + Reader[1].ToString() + " " + Reader[2].ToString());
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

        public void loadgridReservation()
        {
            TableauListeReservation.Rows.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "select R.ID_Resa, R.ID_Act_Resa, A.Nom_Act, R.ID_Client_Resa, C.Nom_Client FROM Reservation R, activite A, Client C WHERE R.Id_Act_Resa = A.ID_Act AND R.ID_Act_Resa = A.ID_Act AND R.ID_Client_Resa = C.ID_Client";
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        TableauListeReservation.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString());
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

        public void loadgridRecapResa()
        {
            TableauRecapResa.Rows.Clear();
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader Reader;
            connection.Open();
            try
            {
                MySqlCommand myCommand = connection.CreateCommand();

                myCommand.CommandText = "SELECT reservation.ID_Act_Resa, activite.Nom_Act, Place_act, COUNT(reservation.ID_Act_Resa) as NbResa FROM reservation, activite WHERE reservation.Id_act_resa = activite.ID_Act GROUP BY id_act_resa";
                Reader = myCommand.ExecuteReader(); //C'est le buffer qui va contenir le resultat de la requete 
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        TableauRecapResa.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString());
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

        private void FenActivite_Load(object sender, EventArgs e)
        {
            loadgridReservation();
            loadgridRecapResa();
        }

        private void bt_BackToForm1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Tag = this;
            Form1.Show(this);
            Hide();
        }

        private void btValidAjoutReservation_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

                        try
                        {
                            MySqlCommand myCommand = connection.CreateCommand();

                            myCommand.CommandText = "INSERT INTO reservation(ID_Client_Resa, ID_Act_Resa) VALUES (@IDClientResa, @IDActResa)";
                            myCommand.Parameters.AddWithValue("@IDActResa", cbListeActivite.Text.Split(';')[0]);
                            myCommand.Parameters.AddWithValue("@IDClientResa", cbListeClient.Text.Split(';')[0]);
                            myCommand.ExecuteNonQuery();

                            MessageBox.Show("Reservation créée", "OK");

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
            loadgridReservation();
            loadgridRecapResa();
        }

        private void btSuppTableauListeActivite_Click(object sender, EventArgs e)
        {
            string ConnectionString = "SERVER=127.0.0.1; DATABASE=pignade; UID=root; PASSWORD=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            try
            {
                MySqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = "DELETE FROM Reservation WHERE ID_Resa ='" + TableauListeReservation.SelectedRows[0].Cells[0].Value.ToString() + "' ";
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Reservation supprimée, veuillez recharcher", "OK");

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

        private void cbListeClient_Click(object sender, EventArgs e)
        {
            loadCBClient();
        }

        private void cbListeActivite_Click(object sender, EventArgs e)
        {
            loadCBActivite();
        }

        private void TableauListeReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
