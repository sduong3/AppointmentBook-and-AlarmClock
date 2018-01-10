namespace PA5
{
    partial class setAlarmForm
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
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectHour = new System.Windows.Forms.NumericUpDown();
            this.selectMinute = new System.Windows.Forms.NumericUpDown();
            this.selectSecond = new System.Windows.Forms.NumericUpDown();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(13, 52);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(30, 13);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "Hour";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(13, 113);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(39, 13);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "Minute";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(13, 177);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(44, 13);
            this.labelSecond.TabIndex = 2;
            this.labelSecond.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add more time";
            // 
            // selectHour
            // 
            this.selectHour.Location = new System.Drawing.Point(16, 69);
            this.selectHour.Name = "selectHour";
            this.selectHour.Size = new System.Drawing.Size(120, 20);
            this.selectHour.TabIndex = 4;
            // 
            // selectMinute
            // 
            this.selectMinute.Location = new System.Drawing.Point(16, 129);
            this.selectMinute.Name = "selectMinute";
            this.selectMinute.Size = new System.Drawing.Size(120, 20);
            this.selectMinute.TabIndex = 5;
            // 
            // selectSecond
            // 
            this.selectSecond.Location = new System.Drawing.Point(16, 193);
            this.selectSecond.Name = "selectSecond";
            this.selectSecond.Size = new System.Drawing.Size(120, 20);
            this.selectSecond.TabIndex = 6;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(106, 249);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // setAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.selectSecond);
            this.Controls.Add(this.selectMinute);
            this.Controls.Add(this.selectHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Name = "setAlarmForm";
            this.Text = "Set the Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.selectHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown selectHour;
        private System.Windows.Forms.NumericUpDown selectMinute;
        private System.Windows.Forms.NumericUpDown selectSecond;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
    }
}