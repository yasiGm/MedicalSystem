namespace med
{
    partial class MedicalCenterUserPanelForm
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
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByTestId = new System.Windows.Forms.Button();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.btnMarkTestAsDone = new System.Windows.Forms.Button();
            this.txtTestIdForNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestNote = new System.Windows.Forms.TextBox();
            this.btnAddTestNote = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btnReserveAppointment = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.txtPatientIdForReservation = new System.Windows.Forms.TextBox();
            this.txtTimeForReservation = new System.Windows.Forms.TextBox();
            this.txtAppointmentIdForCancellation = new System.Windows.Forms.TextBox();
            this.txtDateForReservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();            
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient ID:";
            // txtPatientId
            this.txtPatientId.Location = new System.Drawing.Point(212, 124);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(150, 31);
            this.txtPatientId.TabIndex = 1;
            // btnSearchByPatientId
            this.btnSearchByPatientId.Location = new System.Drawing.Point(368, 124);
            this.btnSearchByPatientId.Name = "btnSearchByPatientId";
            this.btnSearchByPatientId.Size = new System.Drawing.Size(150, 31);
            this.btnSearchByPatientId.TabIndex = 2;
            this.btnSearchByPatientId.Text = "Search";
            this.btnSearchByPatientId.UseVisualStyleBackColor = true;
            this.btnSearchByPatientId.Click += new System.EventHandler(this.btnSearchByPatientId_Click);
            // dataGridViewTests
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Location = new System.Drawing.Point(38, 180);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.RowHeadersWidth = 82;
            this.dataGridViewTests.RowTemplate.Height = 33;
            this.dataGridViewTests.Size = new System.Drawing.Size(1040, 200);
            this.dataGridViewTests.TabIndex = 3;
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pending Tests:";
            // btnSearchByTestId
            this.btnSearchByTestId.Location = new System.Drawing.Point(921, 118);
            this.btnSearchByTestId.Name = "btnSearchByTestId";
            this.btnSearchByTestId.Size = new System.Drawing.Size(150, 31);
            this.btnSearchByTestId.TabIndex = 8;
            this.btnSearchByTestId.Text = "Search";
            this.btnSearchByTestId.UseVisualStyleBackColor = true;
            this.btnSearchByTestId.Click += new System.EventHandler(this.btnSearchByTestId_Click);
            // txtTestId
            this.txtTestId.Location = new System.Drawing.Point(765, 118);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.Size = new System.Drawing.Size(150, 31);
            this.txtTestId.TabIndex = 7;
            // btnMarkTestAsDone
            this.btnMarkTestAsDone.Location = new System.Drawing.Point(29, 386);
            this.btnMarkTestAsDone.Name = "btnMarkTestAsDone";
            this.btnMarkTestAsDone.Size = new System.Drawing.Size(1040, 39);
            this.btnMarkTestAsDone.TabIndex = 9;
            this.btnMarkTestAsDone.Text = "Mark as Done";
            this.btnMarkTestAsDone.UseVisualStyleBackColor = true;
            this.btnMarkTestAsDone.Click += new System.EventHandler(this.btnMarkTestAsDone_Click);
            // txtTestIdForNote
            this.txtTestIdForNote.Location = new System.Drawing.Point(212, 431);
            this.txtTestIdForNote.Name = "txtTestIdForNote";
            this.txtTestIdForNote.Size = new System.Drawing.Size(150, 31);
            this.txtTestIdForNote.TabIndex = 10;
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Test ID:";
            // txtTestNote
            this.txtTestNote.Location = new System.Drawing.Point(38, 473);
            this.txtTestNote.Multiline = true;
            this.txtTestNote.Name = "txtTestNote";
            this.txtTestNote.Size = new System.Drawing.Size(1040, 100);
            this.txtTestNote.TabIndex = 12;
            // btnAddTestNote
            this.btnAddTestNote.Location = new System.Drawing.Point(38, 579);
            this.btnAddTestNote.Name = "btnAddTestNote";
            this.btnAddTestNote.Size = new System.Drawing.Size(1040, 39);
            this.btnAddTestNote.TabIndex = 13;
            this.btnAddTestNote.Text = "Add Note";
            this.btnAddTestNote.UseVisualStyleBackColor = true;
            this.btnAddTestNote.Click += new System.EventHandler(this.btnAddTestNote_Click);
            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(32, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 14;
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter Prescription ID:";
            // dataGridViewAppointments
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(37, 652);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 82;
            this.dataGridViewAppointments.RowTemplate.Height = 33;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1040, 150);
            this.dataGridViewAppointments.TabIndex = 16;
            // btnReserveAppointment
            this.btnReserveAppointment.Location = new System.Drawing.Point(471, 843);
            this.btnReserveAppointment.Name = "btnReserveAppointment";
            this.btnReserveAppointment.Size = new System.Drawing.Size(174, 38);
            this.btnReserveAppointment.TabIndex = 17;
            this.btnReserveAppointment.Text = "Reserve Appointment";
            this.btnReserveAppointment.UseVisualStyleBackColor = true;
            this.btnReserveAppointment.Click += new System.EventHandler(this.btnReserveAppointment_Click);            // btnCancelAppointment
            this.btnCancelAppointment.Location = new System.Drawing.Point(869, 842);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(200, 36);
            this.btnCancelAppointment.TabIndex = 18;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // txtPatientIdForReservation
            this.txtPatientIdForReservation.Location = new System.Drawing.Point(35, 847);
            this.txtPatientIdForReservation.Name = "txtPatientIdForReservation";
            this.txtPatientIdForReservation.Size = new System.Drawing.Size(150, 31);
            this.txtPatientIdForReservation.TabIndex = 19;
            // txtTimeForReservation 
            this.txtTimeForReservation.Location = new System.Drawing.Point(334, 847);
            this.txtTimeForReservation.Name = "txtTimeForReservation";
            this.txtTimeForReservation.Size = new System.Drawing.Size(131, 31);
            this.txtTimeForReservation.TabIndex = 21;
            // txtAppointmentIdForCancellation 
            this.txtAppointmentIdForCancellation.Location = new System.Drawing.Point(696, 847);
            this.txtAppointmentIdForCancellation.Name = "txtAppointmentIdForCancellation";
            this.txtAppointmentIdForCancellation.Size = new System.Drawing.Size(150, 31);
            this.txtAppointmentIdForCancellation.TabIndex = 22;
            // txtDateForReservation
            this.txtDateForReservation.Location = new System.Drawing.Point(196, 847);
            this.txtDateForReservation.Name = "txtDateForReservation";
            this.txtDateForReservation.Size = new System.Drawing.Size(132, 31);
            this.txtDateForReservation.TabIndex = 19;
            // label5 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 819);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Patient ID:";
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 819);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date:";
            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 819);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time:";
            // label8
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 819);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Appointment ID:";
            // MedicalCenterUserPanelForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 917);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAddTestNote);
            this.Controls.Add(this.txtTestNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTestIdForNote);
            this.Controls.Add(this.btnMarkTestAsDone);
            this.Controls.Add(this.btnSearchByTestId);
            this.Controls.Add(this.txtTestId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTests);
            this.Controls.Add(this.btnSearchByPatientId);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeForReservation);
            this.Controls.Add(this.txtAppointmentIdForCancellation);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.btnReserveAppointment);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.txtDateForReservation);
            this.Controls.Add(this.txtPatientIdForReservation);
            this.Name = "MedicalCenterUserPanelForm";
            this.Text = "MedicalCenterUserPanelForm";
            this.Load += new System.EventHandler(this.MedicalCenterUserPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPatientIdForReservation;
        private System.Windows.Forms.TextBox txtTimeForReservation;
        private System.Windows.Forms.TextBox txtAppointmentIdForCancellation;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnReserveAppointment;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnSearchByPatientId;
        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchByTestId;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.Button btnMarkTestAsDone;
        private System.Windows.Forms.TextBox txtTestIdForNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestNote;
        private System.Windows.Forms.Button btnAddTestNote;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateForReservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
