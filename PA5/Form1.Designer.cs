namespace PA5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.newAlarmTimeLabel = new System.Windows.Forms.Label();
            this.snoozeTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmClockLabel = new System.Windows.Forms.Label();
            this.appointmentBookLabel = new System.Windows.Forms.Label();
            this.btnCreateApt = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.appointmentTimer = new System.Windows.Forms.Timer(this.components);
            this.appointmentGif = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGif)).BeginInit();
            this.SuspendLayout();
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLabel.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.Yellow;
            this.currentTimeLabel.Location = new System.Drawing.Point(62, 30);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.currentTimeLabel.MinimumSize = new System.Drawing.Size(182, 55);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Padding = new System.Windows.Forms.Padding(10);
            this.currentTimeLabel.Size = new System.Drawing.Size(182, 55);
            this.currentTimeLabel.TabIndex = 1;
            this.currentTimeLabel.Text = "currentTime";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimer
            // 
            this.currentTimer.Enabled = true;
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.Location = new System.Drawing.Point(68, 151);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(115, 31);
            this.btnSetAlarm.TabIndex = 2;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // newAlarmTimeLabel
            // 
            this.newAlarmTimeLabel.AutoSize = true;
            this.newAlarmTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.newAlarmTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newAlarmTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAlarmTimeLabel.ForeColor = System.Drawing.Color.Yellow;
            this.newAlarmTimeLabel.Location = new System.Drawing.Point(226, 155);
            this.newAlarmTimeLabel.Name = "newAlarmTimeLabel";
            this.newAlarmTimeLabel.Size = new System.Drawing.Size(117, 26);
            this.newAlarmTimeLabel.TabIndex = 3;
            this.newAlarmTimeLabel.Text = "No Time Set";
            // 
            // snoozeTimer
            // 
            this.snoozeTimer.Interval = 1000;
            this.snoozeTimer.Tick += new System.EventHandler(this.snoozeTimer_Tick);
            // 
            // alarmTimer
            // 
            this.alarmTimer.Enabled = true;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // alarmClockLabel
            // 
            this.alarmClockLabel.AutoSize = true;
            this.alarmClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.alarmClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmClockLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.alarmClockLabel.Location = new System.Drawing.Point(216, 103);
            this.alarmClockLabel.Name = "alarmClockLabel";
            this.alarmClockLabel.Size = new System.Drawing.Size(127, 25);
            this.alarmClockLabel.TabIndex = 4;
            this.alarmClockLabel.Text = "Alarm Clock";
            // 
            // appointmentBookLabel
            // 
            this.appointmentBookLabel.AutoSize = true;
            this.appointmentBookLabel.BackColor = System.Drawing.Color.Transparent;
            this.appointmentBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBookLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.appointmentBookLabel.Location = new System.Drawing.Point(199, 238);
            this.appointmentBookLabel.Name = "appointmentBookLabel";
            this.appointmentBookLabel.Size = new System.Drawing.Size(187, 25);
            this.appointmentBookLabel.TabIndex = 5;
            this.appointmentBookLabel.Text = "Appointment Book";
            // 
            // btnCreateApt
            // 
            this.btnCreateApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateApt.Location = new System.Drawing.Point(509, 235);
            this.btnCreateApt.Name = "btnCreateApt";
            this.btnCreateApt.Size = new System.Drawing.Size(60, 31);
            this.btnCreateApt.TabIndex = 7;
            this.btnCreateApt.Text = "+";
            this.btnCreateApt.UseVisualStyleBackColor = true;
            this.btnCreateApt.Click += new System.EventHandler(this.btnCreateApt_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnDescription,
            this.columnDateTime,
            this.columnReminder,
            this.columnActive});
            this.dgvAppointment.Location = new System.Drawing.Point(20, 275);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(549, 179);
            this.dgvAppointment.TabIndex = 10;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.Name = "columnDescription";
            // 
            // columnDateTime
            // 
            this.columnDateTime.HeaderText = "Date and Time";
            this.columnDateTime.Name = "columnDateTime";
            // 
            // columnReminder
            // 
            this.columnReminder.HeaderText = "Reminder";
            this.columnReminder.Name = "columnReminder";
            // 
            // columnActive
            // 
            this.columnActive.HeaderText = "Active";
            this.columnActive.Name = "columnActive";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(428, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 31);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // appointmentTimer
            // 
            this.appointmentTimer.Interval = 1000;
            this.appointmentTimer.Tick += new System.EventHandler(this.appointmentTimer_Tick);
            // 
            // appointmentGif
            // 
            this.appointmentGif.Image = global::PA5.Properties.Resources.pcPrincipal;
            this.appointmentGif.Location = new System.Drawing.Point(413, 20);
            this.appointmentGif.Name = "appointmentGif";
            this.appointmentGif.Size = new System.Drawing.Size(156, 129);
            this.appointmentGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appointmentGif.TabIndex = 18;
            this.appointmentGif.TabStop = false;
            this.appointmentGif.Visible = false;
            this.appointmentGif.Click += new System.EventHandler(this.appointmentGif_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(20, 238);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 31);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(385, 155);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 31);
            this.btnStop.TabIndex = 20;
            this.btnStop.Text = "Stop Alarm";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PA5.Properties.Resources.aurora;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 481);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.appointmentGif);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.btnCreateApt);
            this.Controls.Add(this.appointmentBookLabel);
            this.Controls.Add(this.alarmClockLabel);
            this.Controls.Add(this.newAlarmTimeLabel);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.currentTimeLabel);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Alarm Clock and Appointment Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Label newAlarmTimeLabel;
        private System.Windows.Forms.Timer snoozeTimer;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Label alarmClockLabel;
        private System.Windows.Forms.Label appointmentBookLabel;
        private System.Windows.Forms.Button btnCreateApt;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Timer appointmentTimer;
        private System.Windows.Forms.PictureBox appointmentGif;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReminder;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActive;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStop;
    }
}

