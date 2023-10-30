using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoByMe
{
    public partial class CreatePacient : Form
    {
        private SqlConnection connection;
        private string connectionString = "Server=LAPTOP-4O4VOI8H\\SQLEXPRESS ; Initial Catalog=Hospital; Integrated Security=True; TrustServerCertificate=True";
        private object maskTextBox_mobile;
        private object textBox_email;

        public CreatePacient()
        {
            InitializeComponent();
        }
        public string GetID()
        {
            return text_ID.Text;
        }



        public string GetPatientName()
        {
            return text_name.Text;
        }

        public string GetTelephone()
        {
            return maskedTextBox_telephone.Text;
        }

        public string GetMobile()
        {
            return maskedTextBox_mobile.Text;
        }

        public string GetFax()
        {
            return text_fax.Text;
        }

        public string GetOtherTelephone()
        {
            return maskedTextBox_otherTelephone.Text;
        }

        public string GetEmail()
        {
            return text_email.Text;
        }

        public string GetSex()
        {
            return text_sex.Text;
        }

        public string GetBirthDate()
        {
            return maskedTextBox_birthDate.Text;
        }

        public string GetProcessNumber()
        {
            return text_ProcessNumber.Text;
        }

        public string GetPostalCode()
        {
            return maskedTextBox_postalCode.Text;
        }

        public string GetPostalArea()
        {
            return maskedTextBox_postalArea.Text;
        }

        public string GetLocality()
        {
            return text_Locality.Text;
        }

        public string GetPostalCodeID()
        {
            return text_PostalCodeId.Text;
        }

        public string GetAddress()
        {
            return text_address.Text;
        }

        public string GetTown()
        {
            return text_town.Text;
        }

        public string GetPostalCodeFull()
        {
            return text_postalCodeFull.Text;
        }

        public string GetNif()
        {
            return maskedTextBox_nif.Text;
        }

        public string GetSns()
        {
            return maskedTextBox_sns.Text;
        }
        private void InsertPatient(string otherID, string name, string telephone, string mobile, string fax, string otherTelephone, string email, string sex, string birthDate, string processNumber, string postalCode, string postalArea, string locality, string postalCodeID, string address, string town, string postalCodeFull, string nif, string sns)
        {

            string query = "INSERT INTO tbl_Patient (OtherID, Name, Telephone, Mobile, Fax, OtherTelephone, Email, Sex, BirthDate, ProcessNumber, PostalCode, PostalArea, Locality, PostalCodeID, Address, Town, PostalCodeFull, NIF, SNS) VALUES (@OtherID, @Name, @Telephone, @Mobile, @Fax, @OtherTelephone, @Email, @Sex, @BirthDate, @ProcessNumber, @PostalCode, @PostalArea, @Locality, @PostalCodeID, @Address, @Town, @PostalCodeFull, @NIF, @SNS)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OtherID", otherID);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Telephone", telephone);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Fax", fax);
                command.Parameters.AddWithValue("@OtherTelephone", otherTelephone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@ProcessNumber", processNumber);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@PostalArea", postalArea);
                command.Parameters.AddWithValue("@Locality", locality);
                command.Parameters.AddWithValue("@PostalCodeID", postalCodeID);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Town", town);
                command.Parameters.AddWithValue("@PostalCodeFull", postalCodeFull);
                command.Parameters.AddWithValue("@NIF", nif);
                command.Parameters.AddWithValue("@SNS", sns);


                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Pacient successfully incerted!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpa os campos do formulário após a inserção bem-sucedida
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void ClearFields()
        {
            text_OtherID.Text = string.Empty;
            text_name.Text = string.Empty;
            maskedTextBox_telephone.Text = string.Empty;
            maskedTextBox_mobile.Text = string.Empty;
            text_fax.Text = string.Empty;
            maskedTextBox_otherTelephone.Text = string.Empty;
            text_email.Text = string.Empty;
            text_sex.Text = string.Empty;
            maskedTextBox_birthDate.Text = string.Empty;
            text_ProcessNumber.Text = string.Empty;
            maskedTextBox_postalCode.Text = string.Empty;
            maskedTextBox_postalArea.Text = string.Empty;
            text_Locality.Text = string.Empty;
            text_PostalCodeId.Text = string.Empty;
            text_address.Text = string.Empty;
            text_town.Text = string.Empty;
            text_postalCodeFull.Text = string.Empty;
            maskedTextBox_nif.Text = string.Empty;
            maskedTextBox_sns.Text = string.Empty;

        }


        private void FormatGV()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Other ID";
            Grid.Columns[2].HeaderText = "Name";
            Grid.Columns[3].HeaderText = "Telephone";
            Grid.Columns[4].HeaderText = "Mobile";
            Grid.Columns[5].HeaderText = "Fax";
            Grid.Columns[6].HeaderText = "Other Telephone";
            Grid.Columns[7].HeaderText = "Email";
            Grid.Columns[8].HeaderText = "Sex";
            Grid.Columns[9].HeaderText = "Birth Date";
            Grid.Columns[10].HeaderText = "Process Number";
            Grid.Columns[11].HeaderText = "Postal Code";
            Grid.Columns[12].HeaderText = "Postal Area";
            Grid.Columns[13].HeaderText = "Locality";
            Grid.Columns[14].HeaderText = "Postal Code ID";
            Grid.Columns[15].HeaderText = "Address";
            Grid.Columns[16].HeaderText = "Town";
            Grid.Columns[17].HeaderText = "Postal Code Full";
            Grid.Columns[18].HeaderText = "Nif";
            Grid.Columns[19].HeaderText = "Sns";
        }

        private void ListGV()
        {
            string query = "SELECT * FROM tbl_Patient ORDER BY ID ASC";




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

        private void ChangeData(string ID, string name, string telephone, string mobile, string fax, string otherTelephone, string email, string sex, string birthDate, string processNumber, string postalCode, string postalArea, string locality, string postalCodeID, string address, string town, string postalCodeFull, string nif, string sns)
        {
            string query = "UPDATE tbl_Patient SET  Name = @Name, Telephone = @Telephone, Mobile = @Mobile, Fax = @Fax, OtherTelephone = @OtherTelephone, Email = @Email, Sex = @Sex, BirthDate = @BirthDate, ProcessNumber = @ProcessNumber, PostalCode = @PostalCode, PostalArea = @PostalArea, Locality = @Locality, PostalCodeID = @PostalCodeID, Address = @Address, Town = @Town, PostalCodeFull = @PostalCodeFull, NIF = @NIF, SNS = @SNS WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Telephone", telephone);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Fax", fax);
                command.Parameters.AddWithValue("@OtherTelephone", otherTelephone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@ProcessNumber", processNumber);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@PostalArea", postalArea);
                command.Parameters.AddWithValue("@Locality", locality);
                command.Parameters.AddWithValue("@PostalCodeID", postalCodeID);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Town", town);
                command.Parameters.AddWithValue("@PostalCodeFull", postalCodeFull);
                command.Parameters.AddWithValue("@NIF", nif);
                command.Parameters.AddWithValue("@SNS", sns);

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Patient data successfully updated!", "Success");
                    // Execute outras ações necessárias após a atualização bem-sucedida
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }


        private void CreatePacient_Load(object sender, EventArgs e)
        {

        }

        private void cmd_changeData_Click(object sender, EventArgs e)
        {
            string ID = text_ID.Text;

            string name = text_name.Text;
            string telephone = maskedTextBox_telephone.Text;
            string mobile = maskedTextBox_mobile.Text;
            string fax = text_fax.Text;
            string otherTelephone = maskedTextBox_otherTelephone.Text;
            string email = text_email.Text;
            string sex = text_sex.Text;
            string birthDate = maskedTextBox_birthDate.Text;
            string processNumber = text_ProcessNumber.Text;
            string postalCode = maskedTextBox_postalCode.Text;
            string postalArea = maskedTextBox_postalArea.Text;
            string locality = text_Locality.Text;
            string postalCodeID = text_PostalCodeId.Text;
            string address = text_address.Text;
            string town = text_town.Text;
            string postalCodeFull = text_postalCodeFull.Text;
            string nif = maskedTextBox_nif.Text;
            string sns = maskedTextBox_sns.Text;

            ChangeData(ID, name, telephone, mobile, fax, otherTelephone, email, sex, birthDate, processNumber, postalCode, postalArea, locality, postalCodeID, address, town, postalCodeFull, nif, sns);
        }



        private void UpdateData(string ID, string name, string telephone, string mobile, string fax, string otherTelephone, string email, string sex, string birthDate, string processNumber, string postalCode, string postalArea, string locality, string postalCodeID, string address, string town, string postalCodeFull, string nif, string sns)
        {
            string query = "UPDATE tbl_Patient SET Name = @Name, Telephone = @Telephone, Mobile = @Mobile, Fax = @Fax, OtherTelephone = @OtherTelephone, Email = @Email, Sex = @Sex, BirthDate = @BirthDate, ProcessNumber = @ProcessNumber, PostalCode = @PostalCode, PostalArea = @PostalArea, Locality = @Locality, PostalCodeID = @PostalCodeID, Address = @Address, Town = @Town, PostalCodeFull = @PostalCodeFull, NIF = @NIF, SNS = @SNS,  Status = @Status WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Telephone", telephone);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Fax", fax);
                command.Parameters.AddWithValue("@OtherTelephone", otherTelephone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@ProcessNumber", processNumber);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@PostalArea", postalArea);
                command.Parameters.AddWithValue("@Locality", locality);
                command.Parameters.AddWithValue("@PostalCodeID", postalCodeID);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Town", town);
                command.Parameters.AddWithValue("@PostalCodeFull", postalCodeFull);
                command.Parameters.AddWithValue("@NIF", nif);
                command.Parameters.AddWithValue("@SNS", sns);
                command.Parameters.AddWithValue("@Status", "Active");

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data successfully updated!", "Success");
                    // Execute outras ações necessárias após a atualização bem-sucedida
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }



        private void cmd_submit_Click(object sender, EventArgs e)
        {
            if (text_name.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please insert name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_name.Text = string.Empty;
                text_name.Focus();
                return;
            }

            if (maskedTextBox_nif.Text == "" || maskedTextBox_nif.Text.Length < 9)
            {
                MessageBox.Show("Please insert nif", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                maskedTextBox_nif.Focus();
                return;
            }

            if (maskedTextBox_sns.Text == "" || maskedTextBox_sns.Text.Length < 12)
            {
                MessageBox.Show("Please insert sns", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                maskedTextBox_sns.Focus();
                return;
            }

            if (text_sex.Text == "")
            {
                MessageBox.Show("Please insert sex", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_sex.Text = string.Empty;
                text_sex.Focus();
                return;
            }

            if (maskedTextBox_birthDate.Text == "  /  /" || maskedTextBox_birthDate.Text.Length < 8)
            {
                MessageBox.Show("Please insert birth date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                maskedTextBox_birthDate.Focus();
                return;
            }



            if (maskedTextBox_mobile.Text == "   -   -" || maskedTextBox_mobile.Text.Length < 9)
            {
                MessageBox.Show("Please insert mobile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox_mobile.Focus();
                return;
            }

            if (maskedTextBox_telephone.Text == "   -   -" || maskedTextBox_telephone.Text.Length < 9)
            {
                MessageBox.Show("Please insert telephone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox_telephone.Focus();
                return;
            }


            if (text_email.Text == "")
            {
                MessageBox.Show("Please insert email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_email.Text = string.Empty;
                text_email.Focus();
                return;
            }



            if (text_address.Text == "")
            {
                MessageBox.Show("Please insert address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_address.Text = string.Empty;
                text_address.Focus();
                return;
            }


            if (text_town.Text == "")
            {
                MessageBox.Show("Please insert town", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_town.Text = string.Empty;
                text_town.Focus();
                return;
            }
            string otherID = text_OtherID.Text;
            string name = text_name.Text;
            string telephone = maskedTextBox_telephone.Text;
            string mobile = maskedTextBox_mobile.Text;
            string fax = text_fax.Text;
            string otherTelephone = maskedTextBox_otherTelephone.Text;
            string email = text_email.Text;
            string sex = text_sex.Text;
            string birthDate = maskedTextBox_birthDate.Text;
            string processNumber = text_ProcessNumber.Text;
            string postalCode = maskedTextBox_postalCode.Text;
            string postalArea = maskedTextBox_postalArea.Text;
            string locality = text_Locality.Text;
            string postalCodeID = text_PostalCodeId.Text;
            string address = text_address.Text;
            string town = text_town.Text;
            string postalCodeFull = text_postalCodeFull.Text;
            string nif = maskedTextBox_nif.Text;
            string sns = maskedTextBox_sns.Text;


            InsertPatient(otherID, name, telephone, mobile, fax, otherTelephone, email, sex, birthDate, processNumber, postalCode, postalArea, locality, postalCodeID, address, town, postalCodeFull, nif, sns);
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cmd_list_Click(object sender, EventArgs e)
        {
            ListGV();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            text_ID.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            text_OtherID.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            text_name.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_telephone.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_mobile.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            text_fax.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_otherTelephone.Text = Grid.CurrentRow.Cells[6].Value.ToString();
            text_email.Text = Grid.CurrentRow.Cells[7].Value.ToString();
            text_sex.Text = Grid.CurrentRow.Cells[8].Value.ToString();
            maskedTextBox_birthDate.Text = Grid.CurrentRow.Cells[9].Value.ToString();
            text_ProcessNumber.Text = Grid.CurrentRow.Cells[10].Value.ToString();
            maskedTextBox_postalCode.Text = Grid.CurrentRow.Cells[11].Value.ToString();
            maskedTextBox_postalArea.Text = Grid.CurrentRow.Cells[12].Value.ToString();
            text_Locality.Text = Grid.CurrentRow.Cells[13].Value.ToString();
            text_PostalCodeId.Text = Grid.CurrentRow.Cells[14].Value.ToString();
            text_address.Text = Grid.CurrentRow.Cells[15].Value.ToString();
            text_town.Text = Grid.CurrentRow.Cells[16].Value.ToString();
            text_postalCodeFull.Text = Grid.CurrentRow.Cells[17].Value.ToString();
            maskedTextBox_nif.Text = Grid.CurrentRow.Cells[18].Value.ToString();
            maskedTextBox_sns.Text = Grid.CurrentRow.Cells[19].Value.ToString();

        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            string ID = text_ID.Text; // Obtém o valor do ID do campo de texto

            string query = "UPDATE tbl_Patient SET Status = 'Hidden' WHERE ID = @ID";

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

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = text_ID.Text;
            string name = text_name.Text;
            string telephone = maskedTextBox_telephone.Text;
            string mobile = maskedTextBox_mobile.Text;
            string fax = text_fax.Text;
            string otherTelephone = maskedTextBox_otherTelephone.Text;
            string email = text_email.Text;
            string sex = text_sex.Text;
            string birthDate = maskedTextBox_birthDate.Text;
            string processNumber = text_ProcessNumber.Text;
            string postalCode = maskedTextBox_postalCode.Text;
            string postalArea = maskedTextBox_postalArea.Text;
            string locality = text_Locality.Text;
            string postalCodeID = text_PostalCodeId.Text;
            string address = text_address.Text;
            string town = text_town.Text;
            string postalCodeFull = text_postalCodeFull.Text;
            string nif = maskedTextBox_nif.Text;
            string sns = maskedTextBox_sns.Text;

            UpdateData(ID, name, telephone, mobile, fax, otherTelephone, email, sex, birthDate, processNumber, postalCode, postalArea, locality, postalCodeID, address, town, postalCodeFull, nif, sns);
        }
    }
}
