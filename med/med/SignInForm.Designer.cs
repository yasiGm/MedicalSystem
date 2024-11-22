namespace med
{
    partial class SignInForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnPatientSignIn = new System.Windows.Forms.Button();
            this.btnDoctorSignIn = new System.Windows.Forms.Button();
            this.btnDrugstoreSignIn = new System.Windows.Forms.Button();
            this.btnMedicalCenterSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // btnPatientSignIn
            this.btnPatientSignIn.Location = new System.Drawing.Point(100, 50);
            this.btnPatientSignIn.Name = "btnPatientSignIn";
            this.btnPatientSignIn.Size = new System.Drawing.Size(200, 50);
            this.btnPatientSignIn.TabIndex = 0;
            this.btnPatientSignIn.Text = "Patient Sign In";
            this.btnPatientSignIn.UseVisualStyleBackColor = true;
            this.btnPatientSignIn.Click += new System.EventHandler(this.btnPatientSignIn_Click);
            // btnDoctorSignIn
            this.btnDoctorSignIn.Location = new System.Drawing.Point(100, 110);
            this.btnDoctorSignIn.Name = "btnDoctorSignIn";
            this.btnDoctorSignIn.Size = new System.Drawing.Size(200, 50);
            this.btnDoctorSignIn.TabIndex = 1;
            this.btnDoctorSignIn.Text = "Doctor Sign In";
            this.btnDoctorSignIn.UseVisualStyleBackColor = true;
            this.btnDoctorSignIn.Click += new System.EventHandler(this.btnDoctorSignIn_Click);
            // btnDrugstoreSignIn
            this.btnDrugstoreSignIn.Location = new System.Drawing.Point(100, 170);
            this.btnDrugstoreSignIn.Name = "btnDrugstoreSignIn";
            this.btnDrugstoreSignIn.Size = new System.Drawing.Size(200, 50);
            this.btnDrugstoreSignIn.TabIndex = 2;
            this.btnDrugstoreSignIn.Text = "Drugstore Sign In";
            this.btnDrugstoreSignIn.UseVisualStyleBackColor = true;
            this.btnDrugstoreSignIn.Click += new System.EventHandler(this.btnDrugstoreSignIn_Click);
            // btnMedicalCenterSignIn
            this.btnMedicalCenterSignIn.Location = new System.Drawing.Point(100, 230);
            this.btnMedicalCenterSignIn.Name = "btnMedicalCenterSignIn";
            this.btnMedicalCenterSignIn.Size = new System.Drawing.Size(200, 50);
            this.btnMedicalCenterSignIn.TabIndex = 3;
            this.btnMedicalCenterSignIn.Text = "Medical Center Sign In";
            this.btnMedicalCenterSignIn.UseVisualStyleBackColor = true;
            this.btnMedicalCenterSignIn.Click += new System.EventHandler(this.btnMedicalCenterSignIn_Click);
            // SignInForm 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnMedicalCenterSignIn);
            this.Controls.Add(this.btnDrugstoreSignIn);
            this.Controls.Add(this.btnDoctorSignIn);
            this.Controls.Add(this.btnPatientSignIn);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnPatientSignIn;
        private System.Windows.Forms.Button btnDoctorSignIn;
        private System.Windows.Forms.Button btnDrugstoreSignIn;
        private System.Windows.Forms.Button btnMedicalCenterSignIn;
    }
}
