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
        public partial class MedicalCenterSignInForm : Form
        {
            public MedicalCenterSignInForm()
            {
                InitializeComponent();
            btnSignIn.Click += btnSignIn_Click;
        }

            private void MedicalCenterSignInForm_Load(object sender, EventArgs e)
            {
                // You can add any initialization code here if needed
            }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Retrieve medical center ID from the text box
            int medicalCenterId;
            if (!int.TryParse(txtMedicalCenterId.Text, out medicalCenterId))
            {
                MessageBox.Show("Please enter a valid medical center ID.");
                return;
            }

            // If the ID is valid, proceed to open the MedicalCenterUserPanelForm
            MedicalCenterUserPanelForm userPanelForm = new MedicalCenterUserPanelForm(medicalCenterId);
            userPanelForm.Show();
        }
    }
    }