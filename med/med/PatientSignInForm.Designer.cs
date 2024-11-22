namespace med
{
    partial class PatientSignInForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnPatientSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // btnPatientSignIn
            this.btnPatientSignIn.Location = new System.Drawing.Point(340, 242);
            this.btnPatientSignIn.Name = "btnPatientSignIn";
            this.btnPatientSignIn.Size = new System.Drawing.Size(132, 41);
            this.btnPatientSignIn.TabIndex = 6;
            this.btnPatientSignIn.Text = "Sign In";
            this.btnPatientSignIn.UseVisualStyleBackColor = true;
            this.btnPatientSignIn.Click += new System.EventHandler(this.btnPatientSignIn_Click); // Add this line to link the button click event to the btnPatientSignIn_Click method
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "User ID :";
            // txtPatientId
            this.txtPatientId.Location = new System.Drawing.Point(285, 196);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(231, 31);
            this.txtPatientId.TabIndex = 4;
            // PatientSignInForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPatientSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientId);
            this.Name = "PatientSignInForm";
            this.Text = "PatientSignInForm";
            this.Load += new System.EventHandler(this.PatientSignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientId;
    }
}
