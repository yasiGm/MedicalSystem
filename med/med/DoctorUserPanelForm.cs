using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace med
{
    public partial class DoctorUserPanelForm : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["med.Properties.Settings.MedicalSystemConnectionString"].ConnectionString;

        public int DoctorId { get; set; }

        public DoctorUserPanelForm(int doctorId)
        {
            DoctorId = doctorId;
            InitializeComponent();
            DisplayAppointmentsForToday();
        }

        private void DoctorUserPanelForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, Doctor {DoctorId}";
        }

        private void DisplayAppointmentsForToday()
        {
            DateTime today = DateTime.Today;
            string query = "SELECT Ad_id, Ad_date, Ad_time, Ad_status, P_name, P_surname, " +
                           "DATEDIFF(year, P_birth, @today) AS P_age, P_tel " +
                           "FROM AppointmentDoctor " +
                           "INNER JOIN Patient ON AppointmentDoctor.P_id = Patient.P_id " +
                           "WHERE D_id = @doctorId AND CONVERT(date, Ad_date) = @today";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doctorId", DoctorId);
                command.Parameters.AddWithValue("@today", today);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable appointments = new DataTable();
                adapter.Fill(appointments);
                dataGridViewAppointments.DataSource = appointments;
            }
        }

            private void dataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["Ap_id"].Value);
                DisplayAppointmentDetails(appointmentId);
            }
        }

        private void DisplayAppointmentDetails(int appointmentId)
        {
            string query = "SELECT P_name, P_surname, P_age, P_tel FROM Appointments " +
                           "INNER JOIN Patient ON Appointments.P_id = Patient.P_id " +
                           "WHERE Ap_id = @appointmentId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@appointmentId", appointmentId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string patientName = reader.GetString(0);
                    string patientSurname = reader.GetString(1);
                    int patientAge = reader.GetInt32(2);
                    string patientTel = reader.GetString(3);

                    lblPatientFullName.Text = $"{patientName} {patientSurname}";
                    lblPatientAge.Text = patientAge.ToString();
                    lblPatientTel.Text = patientTel;
                }

                reader.Close();
            }
        }

        private void btnReserveAppointment_Click(object sender, EventArgs e)
        {
            DateTime appointmentDate = dateTimePickerAppointmentDate.Value.Date;
            TimeSpan appointmentTime = dateTimePickerAppointmentTime.Value.TimeOfDay;
            int patientId = Convert.ToInt32(txtPatientId.Text);

            ReserveAppointment(DoctorId, appointmentDate, appointmentTime, patientId);
            DisplayAppointmentsForToday();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["Ap_id"].Value);
                CancelAppointment(appointmentId);
                DisplayAppointmentsForToday();
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWritePrescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["Ap_id"].Value);
                string prescriptionNote = txtPrescriptionNote.Text;

                WritePrescription(appointmentId, prescriptionNote);
                DisplayAppointmentsForToday();
            }
            else
            {
                MessageBox.Show("Please select an appointment to write a prescription.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReserveAppointment(int doctorId, DateTime appointmentDate, TimeSpan appointmentTime, int patientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Appointments (Ap_date, Ap_time, Ap_status, D_id, P_id) VALUES (@appointmentDate, @appointmentTime, @status, @doctorId, @patientId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                command.Parameters.AddWithValue("@appointmentTime", appointmentTime);
                command.Parameters.AddWithValue("@status", "Reserved");
                command.Parameters.AddWithValue("@doctorId", doctorId);
                command.Parameters.AddWithValue("@patientId", patientId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void CancelAppointment(int appointmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Appointments WHERE Ap_id = @appointmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@appointmentId", appointmentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void WritePrescription(int appointmentId, string prescriptionNote)
        {
            int prescriptionId = GeneratePrescriptionId();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Prescription (Pr_id, Ap_id, Pr_note) VALUES (@prescriptionId, @appointmentId, @prescriptionNote)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@prescriptionId", prescriptionId);
                command.Parameters.AddWithValue("@appointmentId", appointmentId);
                command.Parameters.AddWithValue("@prescriptionNote", prescriptionNote);

                connection.Open();
                command.ExecuteNonQuery();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Appointments SET Ap_status = @status WHERE Ap_id = @appointmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", "Prescription Written");
                command.Parameters.AddWithValue("@appointmentId", appointmentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private int GeneratePrescriptionId()
        {
            int prescriptionId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(Pr_id), 0) + 1 FROM Prescription";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                prescriptionId = Convert.ToInt32(command.ExecuteScalar());
            }

            return prescriptionId;
        }
    }
}