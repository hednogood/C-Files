using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Samuel McDonald 
//1400147869

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxstatus.SelectedIndex = 0;
            textBoxHoursWorked.Visible = false;
            labelHoursWorked.Visible = false;
            
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            comboBoxstatus.Text = "Full time";
            textBoxHoursWorked.Text = "0";
            radioFemale.Checked = false;
            radioMale.Checked = false;
            

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string title;
            double hours = Convert.ToDouble(textBoxHoursWorked.Text);
            EmployeeRawData EmpPay = new EmployeeRawData();
            if (textBoxFname.TextLength < 3)
            {
                MessageBox.Show(this, "Invalid Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxFname.Focus();
            }
            else if (textBoxLname.TextLength < 3)
            {
                MessageBox.Show(this, "Invalid Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxLname.Focus();
            }
            else if ((radioMale.Checked == false) && (radioFemale.Checked == false))
            {
                MessageBox.Show(this, "Invalid Gender", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (((hours  < 1) || (hours > 10)) && (comboBoxstatus.Visible == true))
            {
                MessageBox.Show(this, "Invalid Hours Worked ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (radioMale.Checked == true)
                {
                    title = "Mr";
                    EmpPay.setTitle(title);

                }
                else if (radioFemale.Checked == true)
                {
                    title = "Ms";
                    EmpPay.setTitle(title);
                }

                EmpPay.setFname(textBoxFname.Text);
                EmpPay.setLname(textBoxLname.Text);
                EmpPay.setStatus(comboBoxstatus.Text);
                EmpPay.setHoursworked(Convert.ToDouble(textBoxHoursWorked.Text));
                EmpPay.CalculateCost();
                Final_Document form = new Final_Document(EmpPay);
                form.ShowDialog();
            }
            
        }

        private void comboBoxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxstatus.Text == "Part time")
            {
                textBoxHoursWorked.Visible = true;
                labelHoursWorked.Visible = true;
            }
            if (comboBoxstatus.Text == "Full time")
            {
                textBoxHoursWorked.Visible = false;
                labelHoursWorked.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
