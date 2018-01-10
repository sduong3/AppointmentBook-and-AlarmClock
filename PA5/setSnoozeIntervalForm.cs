using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5
{
    public partial class setSnoozeIntervalForm : Form
    {
        /// <summary>
        /// Initializes all components in the form. Set the default value of snooze interval to 10 seconds 
        /// </summary>
        public setSnoozeIntervalForm()
        {
            InitializeComponent();
            snoozeInterval.Value = 10;              
        }

        /// <summary>
        /// Tells program that user clicked on "stop" in dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Abort;

        }

        /// <summary>
        /// Tells program that user clicked on "snooze" in dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSnooze_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// SnoozeSeconds property. Access the int data of snoozeInterval in the form
        /// </summary>
        public int SnoozeSeconds
        {
            get { return (int)snoozeInterval.Value; }
            set { snoozeInterval.Value = value; }
        }
    }
}
