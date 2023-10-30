using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoByMe
{

    public partial class CreateEpisode : Form

    {

        private SqlConnection connection;
        private string connectionString = "Server=LAPTOP-4O4VOI8H\\SQLEXPRESS ; Initial Catalog=Hospital; Integrated Security=True; TrustServerCertificate=True";

        public CreateEpisode()
        {
            InitializeComponent();
        }

        public string GetPatientID()
        {
            return textBox_patientID.Text;
        }

        public string GetPatientModule()
        {
            return textBox_module.Text;
        }
        private void CreateEpisode_Load(object sender, EventArgs e)
        {

        }

        private void ChangeData(string ID, string PatientID, string Episode, string Module)
        {
            try
            {
                string query = "UPDATE tbl_Module set Episode = @Episode, Module = @Module WHERE PatientID = @PatientID ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@Episode", Episode);
                    command.Parameters.AddWithValue("@Module", Module);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormatGV()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "PatientID";
            Grid.Columns[2].HeaderText = "Episode";
            Grid.Columns[3].HeaderText = "Module";

        }

        public void ListGV()
        {
            string query = "SELECT * FROM tbl_Module ORDER BY ID ASC";




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter db = new SqlDataAdapter();
                db.SelectCommand = command;



                DataTable dt = new DataTable();
                db.Fill(dt);
                Grid.DataSource = dt;

                FormatGV();

            }
        }

        private void ClearFields()
        {
            textBox_ID.Text = string.Empty;
            textBox_patientID.Text = string.Empty;
            textBox_episode.Text = string.Empty;
            textBox_module.Text = string.Empty;

        }

        private bool CheckIfPatientExists(int patientID)
        {
            string query = "SELECT COUNT(*) FROM tbl_Patient WHERE ID = @PatientID";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientID);

                connection.Open();
                count = (int)command.ExecuteScalar();
            }

            return count > 0;
        }

        private void InsertModule(int patientID, string episode, string module)
        {
            if (!CheckIfPatientExists(patientID))
            {
                MessageBox.Show("Patient ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO tbl_Module (PatientID, Episode, Module) VALUES (@PatientID, @Episode, @Module)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@Episode", episode);
                command.Parameters.AddWithValue("@Module", module);

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Module successfully inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error inserting module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cmd_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cmd_submit_Click(object sender, EventArgs e)
        {
            string ID = textBox_ID.Text;
            string patient_ID = textBox_patientID.Text;
            string episode = textBox_episode.Text;
            string module = textBox_module.Text;

            if (int.TryParse(patient_ID, out int patientID))
            {
                if (CheckIfPatientExists(patientID))
                {
                    InsertModule(patientID, episode, module);
                }
                else
                {
                    MessageBox.Show("Patient ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Patient ID should be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataIntoGridView()
        {
            string query = "SELECT p.ID AS ID, m.PatientID, m.Episode, m.Module FROM tbl_Patient p JOIN tbl_Module m ON p.ID = m.PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Associar os dados ao GridView
                Grid.DataSource = dataTable;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            textBox_patientID.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            textBox_episode.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            textBox_module.Text = Grid.CurrentRow.Cells[3].Value.ToString();



        }

        private void cmd_list_Click(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            string ID = textBox_ID.Text; // Obtém o valor do ID do campo de texto

            string query = "UPDATE tbl_Module SET Status = 'Hidden' WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data successfully hidden!", "Success");
                    ListGV(); // Lista novamente os dados após ocultar um registro
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }

        private void cmd_change_Click(object sender, EventArgs e)
        {
            string ID = textBox_ID.Text;
            string PatientID = textBox_patientID.Text;
            string Episode = textBox_episode.Text;
            string Module = textBox_module.Text;
            ChangeData(ID, PatientID, Episode, Module);
        }

        private void cmd_update_Click(object sender, EventArgs e)
        {

        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

