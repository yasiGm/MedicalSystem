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

namespace med
{
    public partial class DrugstoreUserPanelForm : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["med.Properties.Settings.MedicalSystemConnectionString"].ConnectionString;
        private int drugstoreId;

        public DrugstoreUserPanelForm(int drugstoreId)
        {
            InitializeComponent();
            this.drugstoreId = drugstoreId;
            LoadDrugstoreAndDoctorInfo(drugstoreId);
        }

        private void LoadDrugstoreAndDoctorInfo(int drugstoreId)
        {
            string query = "SELECT Dr_name, Dr_Dname, Dr_Dsurname, Dr_tel " +
                "FROM Drugstore " +
                "WHERE Dr_id = @drugstoreId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@drugstoreId", drugstoreId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string drugstoreName = reader["Dr_name"].ToString();
                    string doctorName = reader["Dr_Dname"].ToString();
                    string doctorSurname = reader["Dr_Dsurname"].ToString();
                    string drugstoretel = reader["Dr_tel"].ToString();

                    lblWelcome.Text = $"Welcome {drugstoreName}! Doctor: {doctorName} {doctorSurname}, Tel: {drugstoretel}";
                }
            }
        }

        private void btnSearchByPatientId_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(txtPatientId.Text);
            DisplayPrescriptionsByPatientId(patientId);
        }

        private void btnSearchByPrescriptionId_Click(object sender, EventArgs e)
        {
            int prescriptionId = Convert.ToInt32(txtPrescriptionId.Text);
            DisplayPrescriptionById(prescriptionId);
        }

        private void btnMarkAsDelivered_Click(object sender, EventArgs e)
        {
            if (dataGridViewPendingPrescriptions.SelectedRows.Count > 0)
            {
                int prescriptionId = Convert.ToInt32(dataGridViewPendingPrescriptions.SelectedRows[0].Cells["Pr_id"].Value);
                MarkPrescriptionAsDelivered(prescriptionId);
                DisplayPendingPrescriptions();
                DisplayDeliveredPrescriptions();
            }
            else
            {
                MessageBox.Show("Please select a prescription to mark as delivered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPrescriptionsByPatientId(int patientId)
        {
            string query = "SELECT Pr_id, Pr_note, Pr_date, P_name, P_surname, P_birth, P_tel, D_name, D_surname, D_field " +
                           "FROM Prescription " +

                           "INNER JOIN Patient ON Prescription.P_id = Patient.P_id " +
                           "INNER JOIN Doctor ON Prescription.D_id = Doctor.D_id " +
                           "WHERE Patient.P_id = @patientId AND Pr_status = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patientId", patientId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable prescriptions = new DataTable();
                adapter.Fill(prescriptions);
                dataGridViewPendingPrescriptions.DataSource = prescriptions;
            }
        }

        private void DisplayPrescriptionById(int prescriptionId)
        {
            string query = "SELECT Pr_id, Pr_note, Pr_date, P_name, P_surname, P_birth, P_tel, D_name, D_surname, D_field " +
                           "FROM Prescription " +
                           "INNER JOIN Patient ON Prescription.P_id = Patient.P_id " +
                           "INNER JOIN Doctor ON Prescription.D_id = Doctor.D_id " +
                           "WHERE Pr_id = @prescriptionId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@prescriptionId", prescriptionId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable prescriptions = new DataTable();
                adapter.Fill(prescriptions);
                dataGridViewPendingPrescriptions.DataSource = prescriptions;
            }
        }

        private void MarkPrescriptionAsDelivered(int prescriptionId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Prescription SET Pr_status = 1 WHERE Pr_id = @prescriptionId";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@prescriptionId", prescriptionId);

                string insertQuery = "INSERT INTO BuyPrescription (Pr_id) VALUES (@prescriptionId)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@prescriptionId", prescriptionId);

                connection.Open();
                updateCommand.ExecuteNonQuery();
                insertCommand.ExecuteNonQuery();
            }
        }

        private void DisplayPendingPrescriptions()
        {
            string query = "SELECT Prescription.Pr_id, Prescription.note AS Pr_note, Prescription.Pr_date, " +
                           "Patient.P_name, Patient.P_surname, Patient.P_birth, Patient.P_tel, " +
                           "Doctor.D_name, Doctor.D_surname, Doctor.D_field " +
                           "FROM Prescription " +
                           "INNER JOIN Patient ON Prescription.P_id = Patient.P_id " +
                           "INNER JOIN Doctor ON Prescription.D_id = Doctor.D_id " +
                           "WHERE Prescription.Pr_status = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable prescriptions = new DataTable();
                adapter.Fill(prescriptions);
                dataGridViewPendingPrescriptions.DataSource = prescriptions;
            }
        }

        private void DisplayDeliveredPrescriptions()
        {
            string query = "SELECT Pr_id, Note, Pr_date, P_name, P_surname, P_birth, P_tel, D_name, D_surname, D_field " +
                           "FROM Prescription " +
                           "INNER JOIN Patient ON Prescription.P_id = Patient.P_id " +
                           "INNER JOIN Doctor ON Prescription.D_id = Doctor.D_id " +
                           "WHERE Pr_status = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); // Associate the command with the connection

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable prescriptions = new DataTable();

                connection.Open(); // Open the connection before filling the data

                adapter.Fill(prescriptions);
                dataGridViewDeliveredPrescriptions.DataSource = prescriptions;
            }
        }

        private void DrugstoreUserPanelForm_Load(object sender, EventArgs e)
        {
            DisplayPendingPrescriptions();
            DisplayDeliveredPrescriptions();
        }
    }
}
