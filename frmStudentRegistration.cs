using Microsoft.VisualBasic.Devices;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Text;

namespace WindowsApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();

            //ADRIAN KEN F. MARATA
            //BSIT A402 - INTEGRATIVE PROGRAMMING
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //ADDING COMBO BOX DATA


            // DAYS
            for(int day = 1 ; day <= 31; day++)
            {
                comboBoxDay.Items.Add(day);
            }

            // MONTHS
            for(int months = 1 ; months <= 12; months++)
            {
                comboBoxMonth.Items.Add(months);
            }
            // YEARS FROM 1900 TO PRESENT
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                comboBoxYear.Items.Add(year);
            }

            //Initializing placeholder once form is loaded
            textBoxFname.Text = "Enter Your First Name";
            textBoxLname.Text = "Enter Your Last Name";
            textBoxMname.Text = "Enter Your Middle Name";
        }

        //TO MAKE SURE THAT ONLY 1 RADIO BUTTON IS CHECKED.
        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                radioButtonFemale.Checked = false;
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                radioButtonMale.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GETTING THE STUDENT DATAS
            string gender = "";
            string firstName = textBoxFname.Text;
            string lastName = textBoxLname.Text;
            string mName = textBoxMname.Text;
            string studentName = "Student Name: " + firstName + " " + mName + " " + lastName;

            //CONDITIONAL TO FINISH ALL THE INCOMPLETE DATA
            //IT WONT PUSH THROUGH IF THERE IS A MISSING DATA.
            if (comboBoxMonth.Text == "-Month-" || comboBoxDay.Text == "-Day-" || comboBoxYear.Text == "-Year-" || string.IsNullOrWhiteSpace(textBoxFname.Text) || string.IsNullOrWhiteSpace(textBoxLname.Text) || string.IsNullOrWhiteSpace(textBoxMname.Text) || (!radioButtonFemale.Checked && !radioButtonMale.Checked))
            {
                MessageBox.Show("There is a missing data!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //GETTING THE GENDER
                if (radioButtonMale.Checked)
                {
                    gender = "Male";
                }
                else if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }

                string selectedDay = comboBoxDay.SelectedItem.ToString();
                string selectedMonth = comboBoxMonth.SelectedItem.ToString();
                string selectedYear = comboBoxYear.SelectedItem.ToString();

                MessageBox.Show(studentName + "\n" + "Gender: " + gender + "\n" + "Date of Birth: " + selectedDay + "/" + selectedMonth + "/" + selectedYear);


                //CLEAR ALL THE INPUT DETAILS ONCE SUCCESS!

                textBoxFname.Text = "Enter Your First Name";
                textBoxLname.Text = "Enter Your Last Name";
                textBoxMname.Text = "Enter Your Middle Name";
                radioButtonFemale.Checked = false;
                radioButtonMale.Checked = false;
                comboBoxDay.Text = "-Day-";
                comboBoxMonth.Text = "-Month-";
                comboBoxYear.Text = "-Year-";
            }
        }
        //Placeholder for Fname
        private void textBoxFname_Enter(object sender, EventArgs e)
        {
            if (textBoxFname.Text == "Enter Your First Name")
            {
                textBoxFname.Text = string.Empty;
            }
        }
        private void textBoxFname_Leave(object sender, EventArgs e)
        {
            if (textBoxFname.Text == string.Empty)
            {
                textBoxFname.Text = "Enter Your First Name";
            }
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
            textBoxFname.Enter += textBoxFname_Enter;
            textBoxFname.Leave += textBoxFname_Leave;
        }
        //Placeholder for Lname
        private void textBoxLname_Enter(object sender, EventArgs e)
        {
            if (textBoxLname.Text == "Enter Your Last Name")
            {
                textBoxLname.Text = string.Empty;
            }
        }
        private void textBoxLname_Leave(object sender, EventArgs e)
        {
            if (textBoxLname.Text == string.Empty)
            {
                textBoxLname.Text = "Enter Your Last Name";
            }
        }
        private void textBoxLname_TextChanged(object sender, EventArgs e)
        {
            textBoxLname.Enter += textBoxLname_Enter;
            textBoxLname.Leave += textBoxLname_Leave;
        }
        //Placeholder for Mname
        private void textBoxMname_Enter(object sender, EventArgs e)
        {
            if (textBoxMname.Text == "Enter Your Middle Name")
            {
                textBoxMname.Text = string.Empty;
            }
        }
        private void textBoxMname_Leave(object sender, EventArgs e)
        {
            if (textBoxMname.Text == string.Empty)
            {
                textBoxMname.Text = "Enter Your Middle Name";
            }
        }
        private void textBoxMname_TextChanged(object sender, EventArgs e)
        {
            textBoxMname.Enter += textBoxMname_Enter;
            textBoxMname.Leave += textBoxMname_Leave;
        }
    }
}