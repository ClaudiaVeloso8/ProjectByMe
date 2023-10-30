using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace ProjetoByMe
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Server=LAPTOP-4O4VOI8H\\SQLEXPRESS ; Initial Catalog=Hospital; Integrated Security=True; TrustServerCertificate=True";


        public Form1()
        {
            InitializeComponent();
        }




        private string GetPatientModule(string patientID)
        {
            string module = string.Empty;
            string query = "SELECT Module FROM tbl_Module WHERE PatientID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientID);

                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    module = result.ToString();
                }
            }

            return module;
        }


        private string GetPatientName(int patientID)
        {
            string name = string.Empty;
            string query = "SELECT Name FROM tbl_Patient WHERE ID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientID);

                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    name = result.ToString();
                }
            }

            return name;
        }

        private string GetEpisodeByPatientID(string patientID)
        {
            string episode = string.Empty;
            string query = "SELECT Episode FROM tbl_Module WHERE PatientID = @PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientID);

                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    episode = result.ToString();
                }
            }

            return episode;
        }



        private void cmd_createPatient_Click(object sender, EventArgs e)
        {
            CreatePacient createPacient = new CreatePacient();
            createPacient.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("PatientID", "Patient ID");
            dataGridView1.Columns.Add("PatientName", "Patient Name");
            dataGridView1.Columns.Add("Telephone", "Telephone");
            dataGridView1.Columns.Add("Mobile", "Mobile");
            dataGridView1.Columns.Add("Fax", "Fax");
            dataGridView1.Columns.Add("OtherTelephone", "Other Telephone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Sex", "Sex");
            dataGridView1.Columns.Add("BirthDate", "Birth Date");
            dataGridView1.Columns.Add("ProcessNumber", "Process Number");
            dataGridView1.Columns.Add("PostalCode", "Postal Code");
            dataGridView1.Columns.Add("PostalArea", "Postal Area");
            dataGridView1.Columns.Add("Locality", "Locality");
            dataGridView1.Columns.Add("PostalCodeID", "Postal Code ID");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Town", "Town");
            dataGridView1.Columns.Add("PostalCodeFull", "Postal Code Full");
            dataGridView1.Columns.Add("Nif", "Nif");
            dataGridView1.Columns.Add("Sns", "Sns");
        }


        private void cmd_createEpisode_Click(object sender, EventArgs e)
        {
            CreateEpisode createEpisode = new CreateEpisode();
            createEpisode.ShowDialog();

        }

        private void cmd_listEpisode_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            // Adicionar colunas relevantes do tbl_Module
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("PatientID", "PatientID");
            dataGridView1.Columns.Add("Episode", "Episode");
            dataGridView1.Columns.Add("Module", "Module");

            // Solicitar o ID do paciente
            string input = Microsoft.VisualBasic.Interaction.InputBox("Insert patient ID:", "Patient ID", "");

            if (!string.IsNullOrEmpty(input))
            {
                int patientID;
                if (int.TryParse(input, out patientID))
                {
                    string patientName = GetPatientName(patientID);
                    string episode = GetEpisodeByPatientID(patientID.ToString());
                    string module = GetPatientModule(patientID.ToString());

                    dataGridView1.Rows.Add(patientName, patientID, episode, module);
                }
                else
                {
                    MessageBox.Show("Pacient ID invalid. Insert numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private SqlDataReader GetPatientData(int patientID)
        {
            string query = "SELECT * FROM tbl_Patient WHERE ID = @PatientID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", patientID);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmd_listPatient_Click(object sender, EventArgs e)
        {
            {
                string input = Interaction.InputBox("Insert Patient ID:", "Patient ID", "");
                if (!string.IsNullOrEmpty(input))
                {
                    int patientID;
                    if (int.TryParse(input, out patientID))
                    {
                        // Limpar os dados existentes na DataGridView
                        dataGridView1.Rows.Clear();

                        using (SqlDataReader reader = GetPatientData(patientID))
                        {
                            if (reader.Read())
                            {
                                dataGridView1.Rows.Add(
                                    reader["ID"],
                                    reader["Name"],
                                    reader["Telephone"],
                                    reader["Mobile"],
                                    reader["Fax"],
                                    reader["OtherTelephone"],
                                    reader["Email"],
                                    reader["Sex"],
                                    reader["BirthDate"],
                                    reader["ProcessNumber"],
                                    reader["PostalCode"],
                                    reader["PostalArea"],
                                    reader["Locality"],
                                    reader["PostalCodeID"],
                                    reader["Address"],
                                    reader["Town"],
                                    reader["PostalCodeFull"],
                                    reader["Nif"],
                                    reader["Sns"]
                                );
                            }
                            else
                            {
                                MessageBox.Show("Pacient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pacient ID invalid. Insert numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void createPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePacient createPacient = new CreatePacient();
            createPacient.ShowDialog();
        }

        private void createEpisodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEpisode createEpisode = new CreateEpisode();
            createEpisode.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
