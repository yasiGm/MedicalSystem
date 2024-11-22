namespace Med
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnReserveDoctor;
        private System.Windows.Forms.Button btnReserveMedicalCenter;
        private System.Windows.Forms.DataGridView dataGridViewMedicalCenterAppointments;
        private System.Windows.Forms.TextBox txtDoctorAppointmentID;
        private System.Windows.Forms.Button btnCancelMedicalCenterAppointment;

        private void InitializeComponent()
        {
            this.btnReserveDoctor = new System.Windows.Forms.Button();
            this.btnReserveMedicalCenter = new System.Windows.Forms.Button();
            this.dataGridViewMedicalCenterAppointments = new System.Windows.Forms.DataGridView();
            this.txtDoctorAppointmentID = new System.Windows.Forms.TextBox();
            this.btnCancelMedicalCenterAppointment = new System.Windows.Forms.Button();
            this.dataGridViewDoctorAppointments = new System.Windows.Forms.DataGridView();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.txtDoctorAppointmentDate = new System.Windows.Forms.TextBox();
            this.txtMedicalCenterAppointmentDate = new System.Windows.Forms.TextBox();
            this.txtMedicalCenterId = new System.Windows.Forms.TextBox();
            this.txtDoctorAppointmentTime = new System.Windows.Forms.TextBox();
            this.txtMedicalCenterAppointmentTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicalCenterAppointmentID = new System.Windows.Forms.TextBox();
            this.btnCancelDoctorAppointment = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dataGridViewPendingPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridViewBoughtPrescriptions = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewPendingTests = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewCompletedTests = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicalCenterAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedTests)).BeginInit();
            this.SuspendLayout();
            // btnReserveDoctor
            this.btnReserveDoctor.Location = new System.Drawing.Point(126, 389);
            this.btnReserveDoctor.Name = "btnReserveDoctor";
            this.btnReserveDoctor.Size = new System.Drawing.Size(200, 36);
            this.btnReserveDoctor.TabIndex = 0;
            this.btnReserveDoctor.Text = "Reserve Appointment with Doctor";
            this.btnReserveDoctor.UseVisualStyleBackColor = true;
            this.btnReserveDoctor.Click += new System.EventHandler(this.btnReserveDoctor_Click);
            // btnReserveMedicalCenter
            this.btnReserveMedicalCenter.Location = new System.Drawing.Point(584, 389);
            this.btnReserveMedicalCenter.Name = "btnReserveMedicalCenter";
            this.btnReserveMedicalCenter.Size = new System.Drawing.Size(200, 34);
            this.btnReserveMedicalCenter.TabIndex = 1;
            this.btnReserveMedicalCenter.Text = "Reserve Appointment at Medical Center";
            this.btnReserveMedicalCenter.UseVisualStyleBackColor = true;
            this.btnReserveMedicalCenter.Click += new System.EventHandler(this.btnReserveMedicalCenter_Click);
            // dataGridViewMedicalCenterAppointments
            this.dataGridViewMedicalCenterAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicalCenterAppointments.Location = new System.Drawing.Point(484, 47);
            this.dataGridViewMedicalCenterAppointments.Name = "dataGridViewMedicalCenterAppointments";
            this.dataGridViewMedicalCenterAppointments.RowHeadersWidth = 82;
            this.dataGridViewMedicalCenterAppointments.Size = new System.Drawing.Size(427, 266);
            this.dataGridViewMedicalCenterAppointments.TabIndex = 2;
            this.dataGridViewMedicalCenterAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            // txtDoctorAppointmentID
            this.txtDoctorAppointmentID.Location = new System.Drawing.Point(31, 440);
            this.txtDoctorAppointmentID.Name = "txtDoctorAppointmentID";
            this.txtDoctorAppointmentID.Size = new System.Drawing.Size(157, 31);
            this.txtDoctorAppointmentID.TabIndex = 3; 
            // btnCancelMedicalCenterAppointment 
            this.btnCancelMedicalCenterAppointment.Location = new System.Drawing.Point(635, 440);
            this.btnCancelMedicalCenterAppointment.Name = "btnCancelMedicalCenterAppointment";
            this.btnCancelMedicalCenterAppointment.Size = new System.Drawing.Size(190, 31);
            this.btnCancelMedicalCenterAppointment.TabIndex = 4;
            this.btnCancelMedicalCenterAppointment.Text = "Cancel Appointment";
            this.btnCancelMedicalCenterAppointment.UseVisualStyleBackColor = true;
            this.btnCancelMedicalCenterAppointment.Click += new System.EventHandler(this.btnCancelMedicalCenterAppointment_Click_1);
            // dataGridViewDoctorAppointments
            this.dataGridViewDoctorAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorAppointments.Location = new System.Drawing.Point(31, 47);
            this.dataGridViewDoctorAppointments.Name = "dataGridViewDoctorAppointments";
            this.dataGridViewDoctorAppointments.RowHeadersWidth = 82;
            this.dataGridViewDoctorAppointments.Size = new System.Drawing.Size(427, 266);
            this.dataGridViewDoctorAppointments.TabIndex = 2;
            this.dataGridViewDoctorAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            // txtDoctorId 
            this.txtDoctorId.Location = new System.Drawing.Point(51, 352);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(100, 31);
            this.txtDoctorId.TabIndex = 5;
            // txtDoctorAppointmentDate
            this.txtDoctorAppointmentDate.Location = new System.Drawing.Point(174, 352);
            this.txtDoctorAppointmentDate.Name = "txtDoctorAppointmentDate";
            this.txtDoctorAppointmentDate.Size = new System.Drawing.Size(100, 31);
            this.txtDoctorAppointmentDate.TabIndex = 5;
            // txtMedicalCenterAppointmentDate 
            this.txtMedicalCenterAppointmentDate.Location = new System.Drawing.Point(635, 352);
            this.txtMedicalCenterAppointmentDate.Name = "txtMedicalCenterAppointmentDate";
            this.txtMedicalCenterAppointmentDate.Size = new System.Drawing.Size(100, 31);
            this.txtMedicalCenterAppointmentDate.TabIndex = 5;
            this.txtMedicalCenterAppointmentDate.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // txtMedicalCenterId
            this.txtMedicalCenterId.Location = new System.Drawing.Point(519, 352);
            this.txtMedicalCenterId.Name = "txtMedicalCenterId";
            this.txtMedicalCenterId.Size = new System.Drawing.Size(100, 31);
            this.txtMedicalCenterId.TabIndex = 5;
            this.txtMedicalCenterId.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // txtDoctorAppointmentTime
            this.txtDoctorAppointmentTime.Location = new System.Drawing.Point(289, 352);
            this.txtDoctorAppointmentTime.Name = "txtDoctorAppointmentTime";
            this.txtDoctorAppointmentTime.Size = new System.Drawing.Size(100, 31);
            this.txtDoctorAppointmentTime.TabIndex = 5;
            // txtMedicalCenterAppointmentTime
            this.txtMedicalCenterAppointmentTime.Location = new System.Drawing.Point(752, 352);
            this.txtMedicalCenterAppointmentTime.Name = "txtMedicalCenterAppointmentTime";
            this.txtMedicalCenterAppointmentTime.Size = new System.Drawing.Size(100, 31);
            this.txtMedicalCenterAppointmentTime.TabIndex = 5;
            this.txtMedicalCenterAppointmentTime.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doctor ID:";
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medical Center ID:";
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date:";
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date:";
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time:"; 
            // label6 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time:";
            // txtMedicalCenterAppointmentID
            this.txtMedicalCenterAppointmentID.Location = new System.Drawing.Point(462, 440);
            this.txtMedicalCenterAppointmentID.Name = "txtMedicalCenterAppointmentID";
            this.txtMedicalCenterAppointmentID.Size = new System.Drawing.Size(157, 31);
            this.txtMedicalCenterAppointmentID.TabIndex = 3;
            // btnCancelDoctorAppointment
            this.btnCancelDoctorAppointment.Location = new System.Drawing.Point(194, 440);
            this.btnCancelDoctorAppointment.Name = "btnCancelDoctorAppointment";
            this.btnCancelDoctorAppointment.Size = new System.Drawing.Size(190, 31);
            this.btnCancelDoctorAppointment.TabIndex = 4;
            this.btnCancelDoctorAppointment.Text = "Cancel Appointment";
            this.btnCancelDoctorAppointment.UseVisualStyleBackColor = true;
            this.btnCancelDoctorAppointment.Click += new System.EventHandler(this.btnCancelDoctorAppointment_Click_1);
            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(48, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 25);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "TEST";
            // dataGridViewPendingPrescriptions
            this.dataGridViewPendingPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingPrescriptions.Location = new System.Drawing.Point(31, 557);
            this.dataGridViewPendingPrescriptions.Name = "dataGridViewPendingPrescriptions";
            this.dataGridViewPendingPrescriptions.RowHeadersWidth = 82;
            this.dataGridViewPendingPrescriptions.RowTemplate.Height = 33;
            this.dataGridViewPendingPrescriptions.Size = new System.Drawing.Size(427, 266);
            this.dataGridViewPendingPrescriptions.TabIndex = 9;
            // dataGridViewBoughtPrescriptions 
            this.dataGridViewBoughtPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoughtPrescriptions.Location = new System.Drawing.Point(484, 557);
            this.dataGridViewBoughtPrescriptions.Name = "dataGridViewBoughtPrescriptions";
            this.dataGridViewBoughtPrescriptions.RowHeadersWidth = 82;
            this.dataGridViewBoughtPrescriptions.RowTemplate.Height = 33;
            this.dataGridViewBoughtPrescriptions.Size = new System.Drawing.Size(427, 266);
            this.dataGridViewBoughtPrescriptions.TabIndex = 10;
            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pending Prescriptions";
            this.label7.Click += new System.EventHandler(this.label7_Click); 
            // label8 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bought Prescriptions";
            this.label8.Click += new System.EventHandler(this.label7_Click);            
            // dataGridViewPendingTests
            this.dataGridViewPendingTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingTests.Location = new System.Drawing.Point(31, 891);
            this.dataGridViewPendingTests.Name = "dataGridViewPendingTests";
            this.dataGridViewPendingTests.RowHeadersWidth = 82;
            this.dataGridViewPendingTests.RowTemplate.Height = 33;
            this.dataGridViewPendingTests.Size = new System.Drawing.Size(427, 266);
            this.dataGridViewPendingTests.TabIndex = 9;
            // label9
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 863);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pending Test";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // dataGridViewCompletedTests
            this.dataGridViewCompletedTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompletedTests.Location = new System.Drawing.Point(484, 891);
            this.dataGridViewCompletedTests.Name = "dataGridViewCompletedTests";
            this.dataGridViewCompletedTests.RowHeadersWidth = 82;
            this.dataGridViewCompletedTests.RowTemplate.Height = 33;
            this.dataGridViewCompletedTests.Size = new System.Drawing.Size(427, 266);
            this.dataGridViewCompletedTests.TabIndex = 10;
            // label10
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 863);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Completed Tests";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // Form1
            this.ClientSize = new System.Drawing.Size(986, 1234);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewCompletedTests);
            this.Controls.Add(this.dataGridViewBoughtPrescriptions);
            this.Controls.Add(this.dataGridViewPendingTests);
            this.Controls.Add(this.dataGridViewPendingPrescriptions);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedicalCenterId);
            this.Controls.Add(this.txtMedicalCenterAppointmentTime);
            this.Controls.Add(this.txtMedicalCenterAppointmentDate);
            this.Controls.Add(this.txtDoctorAppointmentTime);
            this.Controls.Add(this.txtDoctorAppointmentDate);
            this.Controls.Add(this.txtDoctorId);
            this.Controls.Add(this.btnCancelDoctorAppointment);
            this.Controls.Add(this.btnCancelMedicalCenterAppointment);
            this.Controls.Add(this.txtMedicalCenterAppointmentID);
            this.Controls.Add(this.txtDoctorAppointmentID);
            this.Controls.Add(this.dataGridViewDoctorAppointments);
            this.Controls.Add(this.dataGridViewMedicalCenterAppointments);
            this.Controls.Add(this.btnReserveMedicalCenter);
            this.Controls.Add(this.btnReserveDoctor);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicalCenterAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewDoctorAppointments;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtDoctorAppointmentDate;
        private System.Windows.Forms.TextBox txtMedicalCenterAppointmentDate;
        private System.Windows.Forms.TextBox txtMedicalCenterId;
        private System.Windows.Forms.TextBox txtDoctorAppointmentTime;
        private System.Windows.Forms.TextBox txtMedicalCenterAppointmentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicalCenterAppointmentID;
        private System.Windows.Forms.Button btnCancelDoctorAppointment;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridViewPendingPrescriptions;
        private System.Windows.Forms.DataGridView dataGridViewBoughtPrescriptions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewPendingTests;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewCompletedTests;
        private System.Windows.Forms.Label label10;
    }
}
