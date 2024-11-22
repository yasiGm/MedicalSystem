namespace med
{
    partial class DrugstoreSignInForm
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
            this.txtDrugstoreID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // txtDrugstoreID
            this.txtDrugstoreID.Location = new System.Drawing.Point(275, 185);
            this.txtDrugstoreID.Name = "txtDrugstoreID";
            this.txtDrugstoreID.Size = new System.Drawing.Size(231, 31);
            this.txtDrugstoreID.TabIndex = 0;
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID :";
            // btnSignIn
            this.btnSignIn.Location = new System.Drawing.Point(330, 231);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(132, 41);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // DrugstoreSignInForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrugstoreID);
            this.Name = "DrugstoreSignInForm";
            this.Text = "DrugstoreSignInForm";
            this.Load += new System.EventHandler(this.DrugstoreSignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrugstoreID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
    }
}
