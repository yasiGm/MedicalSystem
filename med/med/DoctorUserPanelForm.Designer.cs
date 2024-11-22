namespace med
{
    partial class DoctorUserPanelForm
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
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientTel = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.btnReserveAppointment = new System.Windows.Forms.Button();
            this.txtPrescriptionNote = new System.Windows.Forms.RichTextBox();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnWritePrescription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Doctor";
            // dataGridViewAppointments
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(37, 129);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 82;
            this.dataGridViewAppointments.RowTemplate.Height = 33;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1040, 200);
            this.dataGridViewAppointments.TabIndex = 1;
            this.dataGridViewAppointments.SelectionChanged += new System.EventHandler(this.dataGridViewAppointments_SelectionChanged);
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointments";
            // lblPatientFullName
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Location = new System.Drawing.Point(37, 370);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.Size = new System.Drawing.Size(167, 25);
            this.lblPatientFullName.TabIndex = 3;
            this.lblPatientFullName.Text = "Patient Full Name";
            // lblPatientAge
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Location = new System.Drawing.Point(37, 400);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(116, 25);
            this.lblPatientAge.TabIndex = 4;
            this.lblPatientAge.Text = "Patient Age";
            // lblPatientTel
            this.lblPatientTel.AutoSize = true;
            this.lblPatientTel.Location = new System.Drawing.Point(37, 430);
            this.lblPatientTel.Name = "lblPatientTel";
            this.lblPatientTel.Size = new System.Drawing.Size(105, 25);
            this.lblPatientTel.TabIndex = 6;
            this.lblPatientTel.Text = "Patient Tel";
            // dateTimePickerAppointmentDate
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(37, 502);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerAppointmentDate.TabIndex = 7;
            // dateTimePickerAppointmentTime
            this.dateTimePickerAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAppointmentTime.Location = new System.Drawing.Point(37, 539);
            this.dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            this.dateTimePickerAppointmentTime.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerAppointmentTime.TabIndex = 7;
            // txtPatientId
            this.txtPatientId.Location = new System.Drawing.Point(37, 576);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(300, 31);
            this.txtPatientId.TabIndex = 7;
            // btnReserveAppointment
            this.btnReserveAppointment.Location = new System.Drawing.Point(37, 613);
            this.btnReserveAppointment.Name = "btnReserveAppointment";
            this.btnReserveAppointment.Size = new System.Drawing.Size(300, 39);
            this.btnReserveAppointment.TabIndex = 8;
            this.btnReserveAppointment.Text = "Reserve Appointment";
            this.btnReserveAppointment.UseVisualStyleBackColor = true;
            this.btnReserveAppointment.Click += new System.EventHandler(this.btnReserveAppointment_Click);
            // txtPrescriptionNote
            this.txtPrescriptionNote.Location = new System.Drawing.Point(524, 413);
            this.txtPrescriptionNote.Name = "txtPrescriptionNote";
            this.txtPrescriptionNote.Size = new System.Drawing.Size(460, 226);
            this.txtPrescriptionNote.TabIndex = 9;
            this.txtPrescriptionNote.Text = "";
            // btnCancelAppointment
            this.btnCancelAppointment.Location = new System.Drawing.Point(37, 663);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(300, 39);
            this.btnCancelAppointment.TabIndex = 8;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // btnWritePrescription
            this.btnWritePrescription.Location = new System.Drawing.Point(524, 663);
            this.btnWritePrescription.Name = "btnWritePrescription";
            this.btnWritePrescription.Size = new System.Drawing.Size(460, 39);
            this.btnWritePrescription.TabIndex = 8;
            this.btnWritePrescription.Text = "Write Prescription";
            this.btnWritePrescription.UseVisualStyleBackColor = true;
            this.btnWritePrescription.Click += new System.EventHandler(this.btnWritePrescription_Click);
            // DoctorUserPanelForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 733);
            this.Controls.Add(this.txtPrescriptionNote);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnWritePrescription);
            this.Controls.Add(this.btnReserveAppointment);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.dateTimePickerAppointmentTime);
            this.Controls.Add(this.dateTimePickerAppointmentDate);
            this.Controls.Add(this.lblPatientTel);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.label1);
            this.Name = "DoctorUserPanelForm";
            this.Text = "DoctorUserPanelForm";
            this.Load += new System.EventHandler(this.DoctorUserPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientTel;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentTime;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnReserveAppointment;
        private System.Windows.Forms.RichTextBox txtPrescriptionNote;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnWritePrescription;
    }
}