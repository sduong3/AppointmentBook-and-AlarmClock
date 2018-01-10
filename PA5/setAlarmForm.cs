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
    public partial class setAlarmForm : Form
    {
        /// <summary>
        /// Intializes all the components in the form
        /// </summary>
        public setAlarmForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Tells the program user clicked on "Done" in dialog 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Tells the program user clicked on "Cancel" in dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// Hour property. Access the int data of selectHour in setAlarmForm
        /// </summary>
        public int Hour
        {
            get { return (int)selectHour.Value; }
            set { selectHour.Value = value; }
        }

        /// <summary>
        /// Minute property. Access the int data of selectMinute in setAlarmForm
        /// </summary>
        public int Minute
        {
            get { return (int)selectMinute.Value; }
            set { selectMinute.Value = value; }
        }

        /// <summary>
        /// Second property. Access the int data of selectSecond in setAlarmForm 
        /// </summary>
        public int Second
        {
            get { return (int)selectSecond.Value; }
            set { selectSecond.Value = value; }
        }
    }
}
