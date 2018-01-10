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
    public partial class createAppointmentForm : Form
    {
        /// <summary>
        /// Initializes all compenents in the form
        /// </summary>
        public createAppointmentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tells the program that user clicked on "add" in dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        
        /// <summary>
        /// Tells the program that user clicked on "cancel" in dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
        /// <summary>
        /// AptName property. Access the string data of tbName in the form
        /// </summary>
        public string AptName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        /// <summary>
        /// AptDescription property. Access the string data of tbDescription in the form
        /// </summary>
        public string AptDescription
        {
            get { return tbDescription.Text; }
            set { tbDescription.Text = value; }
        }

        /// <summary>
        /// AptTimeDate property. Access the datetime data of dtpDateTime in the form
        /// </summary>
        public DateTime AptTimeDate
        {
            get { return dtpDateTime.Value; }
            set { dtpDateTime.Value = value; }
        }

        /// <summary>
        /// Reminder property. Access the datetime data of dtpReminder in the form
        /// </summary>
        public DateTime Reminder
        {
            get { return dtpReminder.Value; }
            set { dtpReminder.Value = value; }
        }

        /// <summary>
        /// Active property. Access the string data of cbActive in the form
        /// </summary>
        public string Active
        {
            get { return cbActive.Text; }
            set { cbActive.Text = value; }
        }
    }
}
