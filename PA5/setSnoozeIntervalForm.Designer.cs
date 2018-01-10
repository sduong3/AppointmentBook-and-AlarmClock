namespace PA5
{
    partial class setSnoozeIntervalForm
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
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.addSecondsLabel = new System.Windows.Forms.Label();
            this.snoozeInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.snoozeInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Location = new System.Drawing.Point(53, 21);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(161, 34);
            this.btnStopAlarm.TabIndex = 0;
            this.btnStopAlarm.Text = "Stop Alarm";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnSnooze
            // 
            this.btnSnooze.Location = new System.Drawing.Point(53, 161);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(161, 36);
            this.btnSnooze.TabIndex = 1;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // addSecondsLabel
            // 
            this.addSecondsLabel.AutoSize = true;
            this.addSecondsLabel.Location = new System.Drawing.Point(53, 98);
            this.addSecondsLabel.Name = "addSecondsLabel";
            this.addSecondsLabel.Size = new System.Drawing.Size(74, 13);
            this.addSecondsLabel.TabIndex = 2;
            this.addSecondsLabel.Text = "Add Seconds:";
            // 
            // snoozeInterval
            // 
            this.snoozeInterval.Location = new System.Drawing.Point(133, 96);
            this.snoozeInterval.Name = "snoozeInterval";
            this.snoozeInterval.Size = new System.Drawing.Size(81, 20);
            this.snoozeInterval.TabIndex = 3;
            // 
            // setSnoozeIntervalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 237);
            this.Controls.Add(this.snoozeInterval);
            this.Controls.Add(this.addSecondsLabel);
            this.Controls.Add(this.btnSnooze);
            this.Controls.Add(this.btnStopAlarm);
            this.Name = "setSnoozeIntervalForm";
            this.Text = "Set Snooze Interval";
            ((System.ComponentModel.ISupportInitialize)(this.snoozeInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Label addSecondsLabel;
        private System.Windows.Forms.NumericUpDown snoozeInterval;
    }
}