namespace med
{
    partial class DrugstoreUserPanelForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.btnSearchByPatientId = new System.Windows.Forms.Button();
            this.dataGridViewPendingPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridViewDeliveredPrescriptions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchByPrescriptionId = new System.Windows.Forms.Button();
            this.txtPrescriptionId = new System.Windows.Forms.TextBox();
            this.btnMarkAsDelivered = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveredPrescriptions)).BeginInit();
            this.SuspendLayout();
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient ID:";
            // txtPatientId
            this.txtPatientId.Location = new System.Drawing.Point(244, 72);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(150, 31);
            this.txtPatientId.TabIndex = 1;
            // btnSearchByPatientId
            this.btnSearchByPatientId.Location = new System.Drawing.Point(400, 72);
            this.btnSearchByPatientId.Name = "btnSearchByPatientId";
            this.btnSearchByPatientId.Size = new System.Drawing.Size(150, 31);
            this.btnSearchByPatientId.TabIndex = 2;
            this.btnSearchByPatientId.Text = "Search";
            this.btnSearchByPatientId.UseVisualStyleBackColor = true;
            this.btnSearchByPatientId.Click += new System.EventHandler(this.btnSearchByPatientId_Click);
            // dataGridViewPendingPrescriptions
            this.dataGridViewPendingPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingPrescriptions.Location = new System.Drawing.Point(37, 140);
            this.dataGridViewPendingPrescriptions.Name = "dataGridViewPendingPrescriptions";
            this.dataGridViewPendingPrescriptions.RowHeadersWidth = 82;
            this.dataGridViewPendingPrescriptions.RowTemplate.Height = 33;
            this.dataGridViewPendingPrescriptions.Size = new System.Drawing.Size(1040, 200);
            this.dataGridViewPendingPrescriptions.TabIndex = 3;
            // dataGridViewDeliveredPrescriptions
            this.dataGridViewDeliveredPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeliveredPrescriptions.Location = new System.Drawing.Point(37, 408);
            this.dataGridViewDeliveredPrescriptions.Name = "dataGridViewDeliveredPrescriptions";
            this.dataGridViewDeliveredPrescriptions.RowHeadersWidth = 82;
            this.dataGridViewDeliveredPrescriptions.RowTemplate.Height = 33;
            this.dataGridViewDeliveredPrescriptions.Size = new System.Drawing.Size(1040, 200);
            this.dataGridViewDeliveredPrescriptions.TabIndex = 4;
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pending Prescriptions:";
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivered Prescriptions:";
            // btnSearchByPrescriptionId
            this.btnSearchByPrescriptionId.Location = new System.Drawing.Point(400, 25);
            this.btnSearchByPrescriptionId.Name = "btnSearchByPrescriptionId";
            this.btnSearchByPrescriptionId.Size = new System.Drawing.Size(150, 31);
            this.btnSearchByPrescriptionId.TabIndex = 8;
            this.btnSearchByPrescriptionId.Text = "Search";
            this.btnSearchByPrescriptionId.UseVisualStyleBackColor = true;
            this.btnSearchByPrescriptionId.Click += new System.EventHandler(this.btnSearchByPrescriptionId_Click);
            // txtPrescriptionId
            this.txtPrescriptionId.Location = new System.Drawing.Point(244, 28);
            this.txtPrescriptionId.Name = "txtPrescriptionId";
            this.txtPrescriptionId.Size = new System.Drawing.Size(150, 31);
            this.txtPrescriptionId.TabIndex = 7;
            // btnMarkAsDelivered
            this.btnMarkAsDelivered.Location = new System.Drawing.Point(37, 355);
            this.btnMarkAsDelivered.Name = "btnMarkAsDelivered";
            this.btnMarkAsDelivered.Size = new System.Drawing.Size(1040, 31);
            this.btnMarkAsDelivered.TabIndex = 9;
            this.btnMarkAsDelivered.Text = "Mark as Delivered";
            this.btnMarkAsDelivered.UseVisualStyleBackColor = true;
            this.btnMarkAsDelivered.Click += new System.EventHandler(this.btnMarkAsDelivered_Click);
            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(32, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 10;
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Prescription ID:";
            // DrugstoreUserPanelForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 640);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnMarkAsDelivered);
            this.Controls.Add(this.btnSearchByPrescriptionId);
            this.Controls.Add(this.txtPrescriptionId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDeliveredPrescriptions);
            this.Controls.Add(this.dataGridViewPendingPrescriptions);
            this.Controls.Add(this.btnSearchByPatientId);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "DrugstoreUserPanelForm";
            this.Text = "DrugstoreUserPanelForm";
            this.Load += new System.EventHandler(this.DrugstoreUserPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveredPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnSearchByPatientId;
        private System.Windows.Forms.DataGridView dataGridViewPendingPrescriptions;
        private System.Windows.Forms.DataGridView dataGridViewDeliveredPrescriptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchByPrescriptionId;
        private System.Windows.Forms.TextBox txtPrescriptionId;
        private System.Windows.Forms.Button btnMarkAsDelivered;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label4;
    }
}