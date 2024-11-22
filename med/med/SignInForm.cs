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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPatientSignIn_Click(object sender, EventArgs e)
        {
            PatientSignInForm patientSignInForm = new PatientSignInForm();
            patientSignInForm.Show();
        }

        private void btnDoctorSignIn_Click(object sender, EventArgs e)
        {
            DoctorSignInForm doctorSignInForm = new DoctorSignInForm();
            doctorSignInForm.Show();
        }

        private void btnDrugstoreSignIn_Click(object sender, EventArgs e)
        {
            DrugstoreSignInForm drugstoreSignInForm = new DrugstoreSignInForm();
            drugstoreSignInForm.Show();
        }

        private void btnMedicalCenterSignIn_Click(object sender, EventArgs e)
        {
            MedicalCenterSignInForm medicalCenterSignInForm = new MedicalCenterSignInForm();
            medicalCenterSignInForm.Show();
        }
    }
}