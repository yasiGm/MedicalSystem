using Med;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med
{
    public partial class PatientSignInForm : Form
    {
        public PatientSignInForm()
        {
            InitializeComponent();
        }

        private void PatientSignInForm_Load(object sender, EventArgs e)
        {
            // This event handler is triggered when the form is loaded.
            // You can add any initialization code here if needed.
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Implement the sign-in process here
            // For example, you can validate the patient ID and authenticate the patient

            int patientId;
            if (!int.TryParse(txtPatientId.Text, out patientId))
            {
                MessageBox.Show("Please enter a valid patient ID.");
                return;
            }

            // After successful sign-in, you can open the patient user panel form
            // Replace "PatientUserPanelForm" with the actual form name for the patient user panel
            Form1 userPanelForm = new Form1(patientId);
            userPanelForm.Show();

            // Optionally, you can close the sign-in form after successful sign-in
            this.Hide();
        }

        private void btnPatientSignIn_Click(object sender, EventArgs e)
        {
            // Call the btnSignIn_Click method when the btnPatientSignIn button is clicked
            btnSignIn_Click(sender, e);
        }
    }
}
