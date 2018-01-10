//Alarm Clock and Appointment Book
//Steven Duong
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PA5
{
    public partial class Form1 : Form
    {
        DateTime newAlarmTime;
        DateTime snoozeInterval;

        int aptIndex = 0;                //index for which appointment's alert went off
        bool alarmEnable;               //alarm is false by default
        bool snoozeEnable;              //snooze is not active by default

        SoundPlayer alarmSound = new SoundPlayer(PA5.Properties.Resources.Loud_Alarm_Clock_Buzzer_Muk1984_493547174);
        SoundPlayer alertSound = new SoundPlayer(PA5.Properties.Resources.alertSound);

        /// <summary>
        /// Initalizes all the components in the home screen and set alarms to unactive
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.currentTimeLabel.Text = DateTime.Now.ToString();
            alarmEnable = false;
            snoozeEnable = false;
        }

        /// <summary>
        /// When the button "set alarm" is clicked, open a window where the user can set an alarm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            //Initialize new set alarm window form
            setAlarmForm setAlarmForm = new setAlarmForm();
            DialogResult dr = setAlarmForm.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)     //if user clicks on the "done" button
            {
                //store the alarm time into a DateTime object
                newAlarmTime = DateTime.Now.AddHours(setAlarmForm.Hour).AddMinutes(setAlarmForm.Minute).AddSeconds(setAlarmForm.Second);
               
                //display the added hours, minutes, and seconds from setAlarmForm 
                this.newAlarmTimeLabel.Text = newAlarmTime.ToString("hh:mm:ss:tt");

                //set alarm to true and set the alarm timer to active
                alarmEnable = true;          
                alarmTimer.Enabled = true;  
                this.newAlarmTimeLabel.ForeColor = Color.Red;
       //         this.newAlarmTimeLabel.Visible = true;
            }
            else                                                //if user clicked on cancel or the "x" button on the top right of window
            {
                newAlarmTime = DateTime.Now;                    //set to current time but hide it
                this.newAlarmTimeLabel.Text = newAlarmTime.ToString("hh:mm:ss:tt");
     //           this.newAlarmTimeLabel.Visible = false;
            }
        }

        /// <summary>
        /// Shows the current time continuously
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentTimer_Tick(object sender, EventArgs e)
        {
            this.currentTimeLabel.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// When the current time passes the set alarm time and the alarm is active, then keep playing the alarm
        /// sound and stop the alarmTimer. Pop up a window where the user can either snooze or stop the alarm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now >= newAlarmTime) && (alarmEnable == true))    //if alarm is active, play sound
            {
                alarmSound.Play();
                alarmTimer.Enabled = false;
                snoozePopUp();
            }
            else                                    //turn alarm label to red to represent the alarm is active
                this.newAlarmTimeLabel.ForeColor = Color.Red;
        }

        /// <summary>
        /// When the current time passes the set snooze time and snoozeEnavle is active, then play the alarm sound.
        /// Snooze screen pops up again and user can either stop or snooze the alarm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snoozeTimer_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now >= snoozeInterval) && (snoozeEnable == true))
            {
                alarmSound.Play();
                snoozeTimer.Enabled = false;
                snoozePopUp();
            }
        }

        /// <summary>
        /// Opens up a snooze window form. User can either stop the alarm or snooze it. 
        /// Snooze allows the user to set a new alarm reminder time.
        /// </summary>
        private void snoozePopUp()
        {
            //Initialize new snooze window form
            setSnoozeIntervalForm setSnoozeInterval = new setSnoozeIntervalForm();
            DialogResult dr = setSnoozeInterval.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.Abort)  //if user clicks on the "stop" button 
            {
                this.newAlarmTimeLabel.ForeColor = Color.Yellow;            //yellow represents alarm is not active
                alarmEnable = false;                    
                alarmSound.Stop();                                          //stop alarm sound
                snoozeTimer.Enabled = false;            
            }
            else if (dr == System.Windows.Forms.DialogResult.OK)    //if user clicks on "snooze" button
            {
                snoozeInterval = DateTime.Now.AddSeconds(setSnoozeInterval.SnoozeSeconds);      //user sets a new time to be reminded
                this.newAlarmTimeLabel.Text = snoozeInterval.ToString("hh:mm:ss:tt");
                alarmSound.Stop();              
                snoozeEnable = true;
                snoozeTimer.Enabled = true;
                this.newAlarmTimeLabel.ForeColor = Color.Red;                       //red represents alarm is active
            }
            else            //if user clicks on the X button on the top right of screen
            {
                alarmEnable = false;                    
                alarmSound.Stop();                          
                snoozeTimer.Enabled = false;            
                this.newAlarmTimeLabel.ForeColor = Color.Yellow;
            }
        }

        /// <summary>
        /// Opens up a new appointment form where the user enters in information for a new appointment.
        /// Appointment information includes name, description, appointment time, reminder time, and if reminder is active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateApt_Click(object sender, EventArgs e)
        {
            //Initialize new appointment window form
            createAppointmentForm createAppointmentForm = new createAppointmentForm();
            DialogResult dr = createAppointmentForm.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)     //if user clicks on the "add" button
            {
                //add user entered appointment data into a string array
                string[] row = { createAppointmentForm.AptName, createAppointmentForm.AptDescription, createAppointmentForm.AptTimeDate.ToString(), createAppointmentForm.Reminder.ToString(), createAppointmentForm.Active.ToString() };
                dgvAppointment.Rows.Add(row);           //add the array into the appointment table
                appointmentTimer.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)    //if user clicks on "remove" button
        {
            try
            {
                {
                    if (dgvAppointment.SelectedRows.Count > 0)
                    {
                        dgvAppointment.Rows.RemoveAt(dgvAppointment.CurrentRow.Index);  //remove the user selected row
                    }
                }
            }
            catch
            {
                MessageBox.Show("No more rows to delete!");           
            }
        }

        /// <summary>
        /// Timer for the appointment. Checks if the current time passses the appointment reminder time. If the
        /// reminder time is active and the time passes it, then a alert sound is played once and a gif appears.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appointmentTimer_Tick(object sender, EventArgs e)
        {
            DateTime item;                  //represents reminder date and time
            DateTime aptTimeInterval;       //used so the reminder alert time is played only once. Time is 1 second after the reminder date/time
            try
            {
                for (int i = 0; i < dgvAppointment.Rows.Count - 1; i++)     //goes through each row and checks only the reminder column
                {
                    string temp;
                    string isActive;

                    temp = dgvAppointment.Rows[i].Cells[3].Value.ToString();
                    item = Convert.ToDateTime(temp);        //access the reminder time for each appointment
                    isActive = dgvAppointment.Rows[i].Cells[4].Value.ToString();    //access whether the reminder is active or not

                    aptTimeInterval = item.AddSeconds(1);      //1 seconds after the reminder time

                    //play one alert sound for one second once appointment time is past and gif appears
                    if (((DateTime.Now >= item) && (DateTime.Now <= aptTimeInterval)) && (isActive == "True")) 
                    {
                        alertSound.Play();
                        appointmentGif.Visible = true;
                        isActive = "False";
                        this.aptIndex = i;
                    }       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            
        }

        /// <summary>
        /// If user clicks on the gif, a messagebox pops up and appointment information is displayed in the messagebox.
        /// Once the user clicks "ok" on the messagebox, the gif dissappears and the appointment reminder is set to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appointmentGif_Click(object sender, EventArgs e)
        {
            int i = this.aptIndex;

            MessageBox.Show("Appointment Name: " + dgvAppointment.Rows[i].Cells[0].Value.ToString() + "\n" +
                            "Appointment Description: " + dgvAppointment.Rows[i].Cells[1].Value.ToString() + "\n" +
                            "Appointment Time: " + dgvAppointment.Rows[i].Cells[2].Value.ToString() + "\n\n" +
                            "Reminding user of " + dgvAppointment.Rows[i].Cells[0].Value.ToString() + " at " +
                            dgvAppointment.Rows[i].Cells[3].Value.ToString() + "\n");
            appointmentGif.Visible = false;
            dgvAppointment.Rows[i].Cells[4].Value = "False";
        }

        /// <summary>
        /// Displays a message box with instructions on how to use the appointment book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment Book commands:\n" +
                            "Click on the '+' button to add a new appointment\n" +
                            "Click on the 'x' button to remove an appointment. You have to select a row first by clicking on a row on the leftmost column\n" +
                            "Double click a cell on the table to edit that particular cell\n" +
                            "Active needs to be true to enable the appointment's reminder alert notification");
        }

        /// <summary>
        /// When the user clicks on the "stop" button, the alarm is immediately set to unactive and will not 
        /// output the alarm noise when passed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.newAlarmTimeLabel.ForeColor = Color.Yellow;            //yellow represents alarm is not active
            alarmEnable = false;
            alarmSound.Stop();                                          //stop alarm sound
            snoozeTimer.Enabled = false;
        }
    }
}