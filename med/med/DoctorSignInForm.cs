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
    public partial class DoctorSignInForm : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["med.Properties.Settings.MedicalSystemConnectionString"].ConnectionString;
        public DoctorSignInForm()
        {
            InitializeComponent();
        }

        private void DoctorSignInForm_Load(object sender, EventArgs e)
        {
            // This method is called when the form is loaded
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Retrieve the entered doctor ID
            int doctorId;
            if (!int.TryParse(textBox1.Text, out doctorId))
            {
                MessageBox.Show("Please enter a valid doctor ID.", "Invalid Doctor ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the doctor ID against the database
            if (ValidateDoctorId(doctorId))
            {
                // Open Doctor User Panel form
                DoctorUserPanelForm userPanelForm = new DoctorUserPanelForm(doctorId);
                userPanelForm.Show();
                this.Hide(); // Hide the sign-in form
            }
            else
            {
                MessageBox.Show("Invalid doctor ID. Please try again.", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDoctorId(int doctorId)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Doctor WHERE D_id = @doctorId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doctorId", doctorId);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
