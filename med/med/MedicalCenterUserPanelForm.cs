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
    public partial class MedicalCenterUserPanelForm : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["med.Properties.Settings.MedicalSystemConnectionString"].ConnectionString;
        private int medicalCenterId;

        public MedicalCenterUserPanelForm(int medicalCenterId)
        {
            InitializeComponent();
            this.medicalCenterId = medicalCenterId;
            LoadMedicalCenterInfo();
        }
        private void LoadMedicalCenterInfo()
        {
            string query = "SELECT * FROM MedicalCenter WHERE Md_id = @medicalCenterId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@medicalCenterId", medicalCenterId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string centerName = reader["Md_name"].ToString();
                    string centerfield = reader["Md_field"].ToString();
                    string centertel = reader["Md_tel"].ToString();

                    lblWelcome.Text = $"Welcome {centerName}! field: {centerfield}! tel:{centertel}";
                }
            }
        }
        private void MedicalCenterUserPanelForm_Load(object sender, EventArgs e)
        {
            DisplayPendingTests();
            DisplayTodayAppointments();
        }

        private void DisplayTodayAppointments()
        {
            DateTime today = DateTime.Today;
            string query = "SELECT P.P_name, P.P_surname, A.Amd_date, A.Amd_time " +
                           "FROM AppointmentMedicalCenter A " +
                           "INNER JOIN Patient P ON A.P_id = P.P_id " +
                           "WHERE A.Amd_date = @today";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@today", today);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable appointments = new DataTable();
                adapter.Fill(appointments);
                dataGridViewAppointments.DataSource = appointments;
            }
        }

        private void ReserveAppointment(int patientId, DateTime date, TimeSpan time)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO AppointmentMedicalCenter (Amd_date, Amd_time, Amd_status, P_id, Md_id) " +
                                     "VALUES (@date, @time, 0, @patientId, @medicalCenterId)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@date", date);
                insertCommand.Parameters.AddWithValue("@time", time);
                insertCommand.Parameters.AddWithValue("@patientId", patientId);
                insertCommand.Parameters.AddWithValue("@medicalCenterId", medicalCenterId);

                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        private void CancelAppointment(int appointmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM AppointmentMedicalCenter WHERE Amd_id = @appointmentId";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@appointmentId", appointmentId);

                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
        }

        private void btnReserveAppointment_Click(object sender, EventArgs e)
        {
            // Get the patientId from the text box
            if (int.TryParse(txtPatientIdForReservation.Text, out int patientId))
            {
                // Get the date and time from the text boxes and convert them to DateTime and TimeSpan
                if (DateTime.TryParse(txtDateForReservation.Text, out DateTime date) && TimeSpan.TryParse(txtTimeForReservation.Text, out TimeSpan time))
                {
                    // Call the ReserveAppointment method with the provided parameters
                    ReserveAppointment(patientId, date, time);

                    // After reservation, you may want to refresh the appointments display
                    DisplayTodayAppointments();
                }
                else
                {
                    MessageBox.Show("Please enter valid Date and Time in the format specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            // Get the appointmentId from the text box
            if (int.TryParse(txtAppointmentIdForCancellation.Text, out int appointmentId))
            {
                // Call the CancelAppointment method with the provided appointmentId
                CancelAppointment(appointmentId);

                // After cancellation, you may want to refresh the appointments display
                DisplayTodayAppointments();
            }
            else
            {
                MessageBox.Show("Please enter a valid Appointment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSearchByPatientId_Click(object sender, EventArgs e)
            {
                int patientId = Convert.ToInt32(txtPatientId.Text);
                DisplayTestsByPatientId(patientId);
            }

            private void btnSearchByTestId_Click(object sender, EventArgs e)
            {
                int testId = Convert.ToInt32(txtTestId.Text);
                DisplayTestById(testId);
            }

            private void btnMarkTestAsDone_Click(object sender, EventArgs e)
            {
                if (dataGridViewTests.SelectedRows.Count > 0)
                {
                    int testId = Convert.ToInt32(dataGridViewTests.SelectedRows[0].Cells["T_id"].Value);
                    MarkTestAsDone(testId);
                    DisplayPendingTests();
                }
                else
                {
                    MessageBox.Show("Please select a test to mark as done.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnAddTestNote_Click(object sender, EventArgs e)
            {
                int testId = Convert.ToInt32(txtTestIdForNote.Text);
                string note = txtTestNote.Text;
                AddTestNoteAndResult(testId, note);
            }

            private void DisplayTestsByPatientId(int patientId)
            {
                string query = "SELECT T_id, T_date, P_name, P_surname, P_birth, P_tel, D_name, D_surname, D_field " +
                               "FROM MedicalTest " +

                               "INNER JOIN Patient ON MedicalTest.P_id = Patient.P_id " +
                               "INNER JOIN Doctor ON MedicalTest.D_id = Doctor.D_id " +
                               "WHERE Patient.P_id = @patientId AND T_status = 0";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@patientId", patientId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable tests = new DataTable();
                    adapter.Fill(tests);
                    dataGridViewTests.DataSource = tests;
                }
            }

            private void DisplayTestById(int testId)
            {
                string query = "SELECT T_id, T_date, P_name, P_surname, P_birth, P_tel, D_name, D_surname, D_field " +
                               "FROM MedicalTest " +

                               "INNER JOIN Patient ON MedicalTest.P_id = Patient.P_id " +
                               "INNER JOIN Doctor ON MedicalTest.D_id = Doctor.D_id " +
                               "WHERE T_id = @testId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@testId", testId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable tests = new DataTable();
                    adapter.Fill(tests);
                    dataGridViewTests.DataSource = tests;
                }
            }

            private void MarkTestAsDone(int testId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE MedicalTest SET T_status = 1 WHERE T_id = @testId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@testId", testId);

                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                }
            }

            private void AddTestNoteAndResult(int testId, string note)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get new Tr_id
                    string getMaxIdQuery = "SELECT ISNULL(MAX(Tr_id), 0) + 1 FROM MedicalTestResult";
                    SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection);
                    int newTestResultId = (int)getMaxIdCommand.ExecuteScalar();

                    string insertQuery = "INSERT INTO MedicalTestResult (Tr_id, T_id, Note, Date) VALUES (@Tr_id, @T_id, @Note, @Date)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Tr_id", newTestResultId);
                    insertCommand.Parameters.AddWithValue("@T_id", testId);
                    insertCommand.Parameters.AddWithValue("@Note", note);
                    insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);

                    insertCommand.ExecuteNonQuery();
                }
            }

        private void DisplayPendingTests()
        {
            string query = "SELECT T_id, T_date, P_name, P_surname, P_birth, P_tel, D_name, D_surname, D_field " +
                           "FROM MedicalTest " +
                           "INNER JOIN Patient ON MedicalTest.P_id = Patient.P_id " +
                           "INNER JOIN Doctor ON MedicalTest.D_id = Doctor.D_id " +
                           "WHERE T_status = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable tests = new DataTable();

                connection.Open();  // Make sure the connection is open before filling the DataTable
                adapter.Fill(tests);
                dataGridViewTests.DataSource = tests;
            }
        }



    }

}
