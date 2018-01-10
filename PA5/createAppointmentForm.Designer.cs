namespace PA5
{
    partial class createAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.gbAppointMent = new System.Windows.Forms.GroupBox();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.ComboBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAppointMent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(82, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 20);
            this.tbName.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 62);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(82, 62);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(189, 20);
            this.tbDescription.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 96);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date: ";
            // 
            // gbAppointMent
            // 
            this.gbAppointMent.Controls.Add(this.dtpReminder);
            this.gbAppointMent.Controls.Add(this.reminderLabel);
            this.gbAppointMent.Controls.Add(this.cbActive);
            this.gbAppointMent.Controls.Add(this.activeLabel);
            this.gbAppointMent.Controls.Add(this.dtpDateTime);
            this.gbAppointMent.Controls.Add(this.nameLabel);
            this.gbAppointMent.Controls.Add(this.tbName);
            this.gbAppointMent.Controls.Add(this.dateLabel);
            this.gbAppointMent.Controls.Add(this.descriptionLabel);
            this.gbAppointMent.Controls.Add(this.tbDescription);
            this.gbAppointMent.Location = new System.Drawing.Point(42, 12);
            this.gbAppointMent.Name = "gbAppointMent";
            this.gbAppointMent.Size = new System.Drawing.Size(349, 205);
            this.gbAppointMent.TabIndex = 8;
            this.gbAppointMent.TabStop = false;
            this.gbAppointMent.Text = "Make an Appointment";
            // 
            // dtpReminder
            // 
            this.dtpReminder.CustomFormat = "MM/dd/yy       hh:mm:ss:tt";
            this.dtpReminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReminder.Location = new System.Drawing.Point(82, 134);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(189, 20);
            this.dtpReminder.TabIndex = 12;
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Location = new System.Drawing.Point(13, 134);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(58, 13);
            this.reminderLabel.TabIndex = 11;
            this.reminderLabel.Text = "Remind at:";
            // 
            // cbActive
            // 
            this.cbActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbActive.Location = new System.Drawing.Point(82, 169);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(121, 21);
            this.cbActive.TabIndex = 10;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(13, 169);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(40, 13);
            this.activeLabel.TabIndex = 9;
            this.activeLabel.Text = "Active:";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "MM/dd/yy       hh:mm:ss:tt";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(82, 96);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(189, 20);
            this.dtpDateTime.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(42, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // createAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbAppointMent);
            this.Controls.Add(this.btnAdd);
            this.Name = "createAppointmentForm";
            this.Text = "Create Appointment";
            this.gbAppointMent.ResumeLayout(false);
            this.gbAppointMent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox gbAppointMent;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbActive;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label reminderLabel;
        private System.Windows.Forms.DateTimePicker dtpReminder;
    }
}