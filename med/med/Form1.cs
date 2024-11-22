using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Med
{
    public partial class Form1 : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["med.Properties.Settings.MedicalSystemConnectionString"].ConnectionString;
        private int patientId;

        public Form1(int patientId)
        {
            InitializeComponent();

            this.patientId = patientId;

            // Load patient information
            LoadPatientInformation(patientId);
        LoadAppointments();
            LoadPrescriptions();
            LoadMedicalTests();
        }

    private void LoadPatientInformation(int patientId)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT P_name, P_surname FROM Patient WHERE P_id = @patientId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@patientId", patientId);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string patientName = reader.GetString(0);
                string patientSurname = reader.GetString(1);
                lblWelcome.Text = $"Welcome, {patientName} {patientSurname} (ID: {patientId})";
            }

            reader.Close();
        }
    }
    private void Form1_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }
        private void LoadMedicalTests()
        {
            LoadPendingMedicalTests();
            LoadCompletedMedicalTests();
        }

        private void LoadPendingMedicalTests()
        {
            string query = @"SELECT MT.T_id AS TestID, D.D_name AS DoctorName
FROM MedicalTest AS MT
INNER JOIN Doctor AS D ON MT.D_id = D.D_id

";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewPendingTests.DataSource = dataTable;
            }
        }

        private void LoadCompletedMedicalTests()
        {
            string query = @"SELECT MT.T_id AS TestID, 
               MT.T_date AS TestDate, 
               MC.Md_name AS MedicalCenterName, 
               CONCAT(D.D_name, ' ', D.D_surname) AS DoctorFullName
        FROM MedicalTest AS MT
        INNER JOIN MedicalCenter AS MC ON MT.Md_id = MC.Md_id
        INNER JOIN Doctor AS D ON MT.D_id = D.D_id
        INNER JOIN MedicalTestResult AS MTR ON MT.T_id = MTR.T_id
        WHERE MTR.Tr_date IS NOT NULL;
";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewCompletedTests.DataSource = dataTable;
            }
        }
        private void LoadPrescriptions()
        {
            LoadPendingPrescriptions();
            LoadBoughtPrescriptions();
        }
        private void LoadPendingPrescriptions()
        {
            string query = @"SELECT P.Pr_id AS PrescriptionID, D.D_name AS DoctorName
FROM Prescription AS P
INNER JOIN Doctor AS D ON P.D_id = D.D_id
WHERE P.P_id = @patientId AND P.Pr_id NOT IN (SELECT Pr_id FROM buyPrescription WHERE P_id = @patientId);
";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patientId", patientId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewPendingPrescriptions.DataSource = dataTable;
            }
        }

        private void LoadBoughtPrescriptions()
        {
            string query = @"SELECT P.Pr_id AS PrescriptionID, 
       BP.Bpr_date AS PurchaseTime, 
       DS.Dr_name AS DrugStoreName
FROM Prescription AS P
INNER JOIN buyPrescription AS BP ON P.Pr_id = BP.Pr_id
INNER JOIN Drugstore AS DS ON BP.Dr_id = DS.Dr_id
WHERE P.P_id = @patientId;
            ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patientId", patientId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewBoughtPrescriptions.DataSource = dataTable;
            }
        }

        // To reserve an appointment with a doctor
        private void btnReserveDoctor_Click(object sender, EventArgs e)
        {
            // Read values from text boxes
            int doctorId = int.Parse(txtDoctorId.Text);
            DateTime appointmentDate = DateTime.Parse(txtDoctorAppointmentDate.Text);
            TimeSpan appointmentTime = TimeSpan.Parse(txtDoctorAppointmentTime.Text);
            DateTime appointmentDateTime = appointmentDate.Date + appointmentTime;
            bool status = true; // Set status to true for "Reserved"

            // Generate appointment ID for doctor
            int appointmentId = GenerateDoctorAppointmentId();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AppointmentDoctor (Ad_id, Ad_date, Ad_time, Ad_status, D_id, P_id) VALUES (@appointmentId, @date, @time, @status, @doctorId, 1)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@appointmentId", appointmentId);
                command.Parameters.AddWithValue("@date", appointmentDate.Date);
                command.Parameters.AddWithValue("@time", appointmentTime);
                command.Parameters.AddWithValue("@status", status); // Use boolean value
                command.Parameters.AddWithValue("@doctorId", doctorId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            LoadAppointments();
        }

        // To reserve an appointment at a medical center
        private void btnReserveMedicalCenter_Click(object sender, EventArgs e)
        {
            // Read values from text boxes
            int medicalCenterId = int.Parse(txtMedicalCenterId.Text);
            DateTime appointmentDate = DateTime.Parse(txtMedicalCenterAppointmentDate.Text);
            TimeSpan appointmentTime = TimeSpan.Parse(txtMedicalCenterAppointmentTime.Text);
            DateTime appointmentDateTime = appointmentDate.Date + appointmentTime;
            bool status = true; // Set status to true for "Reserved"

            // Generate appointment ID for medical center
            int appointmentId = GenerateMedicalCenterAppointmentId();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AppointmentMedicalCenter (Amd_id, Amd_date, Amd_time, Amd_status, P_id, Md_id) VALUES (@appointmentId, @date, @time, @status, 1, @medicalCenterId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@appointmentId", appointmentId);
                command.Parameters.AddWithValue("@date", appointmentDate.Date);
                command.Parameters.AddWithValue("@time", appointmentTime);
                command.Parameters.AddWithValue("@status", status); // Use boolean value
                command.Parameters.AddWithValue("@medicalCenterId", medicalCenterId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            LoadAppointments();
        }


        private void LoadDoctorAppointments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 'Doctor' AS AppointmentType, 
                   Ad_id, 
                   Ad_date, 
                   Ad_time, 
                   Ad_status, 
                   D.D_name AS DoctorName, 
                   D.D_surname AS DoctorSurname, 
                   D.D_field AS DoctorField,
                   D.D_city AS DoctorCity,
                   D.D_tel AS DoctorTel,
                   D.D_id AS RelatedId
            FROM AppointmentDoctor AS AD
            INNER JOIN Doctor AS D ON AD.D_id = D.D_id
            WHERE AD.P_id = 1"; // Assume patient ID is 1 for example

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable appointments = new DataTable();
                adapter.Fill(appointments);
                dataGridViewDoctorAppointments.DataSource = appointments;
            }
        }

        private void LoadMedicalCenterAppointments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 'MedicalCenter' AS AppointmentType, 
                   Amd_id, 
                   Amd_date, 
                   Amd_time, 
                   Amd_status, 
                   MC.Md_name AS MedicalCenterName, 
                   MC.Md_field AS MedicalCenterField,
                   MC.Md_city AS MedicalCenterCity,
                   MC.Md_tel AS MedicalCenterTel,
                   MC.Md_id AS RelatedId
            FROM AppointmentMedicalCenter AS AMC
            INNER JOIN MedicalCenter AS MC ON AMC.Md_id = MC.Md_id
            WHERE AMC.P_id = 1"; // Assume patient ID is 1 for example

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable appointments = new DataTable();
                adapter.Fill(appointments);
                dataGridViewMedicalCenterAppointments.DataSource = appointments;
            }
        }

        private void LoadAppointments()
        {
            LoadDoctorAppointments();
            LoadMedicalCenterAppointments();
        }

        // Cancel appointment with a doctor
        private void btnCancelDoctorAppointment_Click(object sender, EventArgs e)
        {
            
        }

        // Cancel appointment at a medical center
        private void btnCancelMedicalCenterAppointment_Click(object sender, EventArgs e)
        {
            
        }


        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private int GenerateDoctorAppointmentId()
        {
            int appointmentId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Ad_id) FROM AppointmentDoctor";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    appointmentId = Convert.ToInt32(result);
                }
            }

            // Increment the appointment ID by 1
            appointmentId++;

            return appointmentId;
        }

        // Method to generate a unique appointment ID for medical centers
        private int GenerateMedicalCenterAppointmentId()
        {
            int appointmentId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Amd_id) FROM AppointmentMedicalCenter";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    appointmentId = Convert.ToInt32(result);
                }
            }

            // Increment the appointment ID by 1
            appointmentId++;

            return appointmentId;
        }

        private void btnCancelDoctorAppointment_Click_1(object sender, EventArgs e)
        {
            int doctorAppointmentId = int.Parse(txtDoctorAppointmentID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM AppointmentDoctor WHERE Ad_id = @doctorAppointmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doctorAppointmentId", doctorAppointmentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            LoadDoctorAppointments();
        }

        private void btnCancelMedicalCenterAppointment_Click_1(object sender, EventArgs e)
        {
            int medicalCenterAppointmentId = int.Parse(txtMedicalCenterAppointmentID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM AppointmentMedicalCenter WHERE Amd_id = @medicalCenterAppointmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@medicalCenterAppointmentId", medicalCenterAppointmentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            LoadMedicalCenterAppointments();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
