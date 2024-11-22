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
    public partial class DrugstoreSignInForm : Form
    {
        public DrugstoreSignInForm()
        {
            InitializeComponent();
        }

        private void DrugstoreSignInForm_Load(object sender, EventArgs e)
        {
            // Code to handle the form load event
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDrugstoreID.Text, out int drugstoreId))
            {
                // Assuming you have a method to validate the drugstore ID in the database
                if (ValidateDrugstore(drugstoreId))
                {
                    // If the drugstore ID is valid, open the drugstore user panel form
                    DrugstoreUserPanelForm userPanelForm = new DrugstoreUserPanelForm(drugstoreId);
                    userPanelForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid drugstore ID. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid drugstore ID.");
            }
        }

        // Method to validate the drugstore ID (You should implement this according to your database logic)
        private bool ValidateDrugstore(int drugstoreId)
        {
            // Your validation logic here (e.g., querying the database)
            // Return true if the drugstore ID is valid; otherwise, return false
            return true;
        }
    }
}
