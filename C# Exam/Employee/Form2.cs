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
    public partial class Final_Document : Form
    {
        public Final_Document(EmployeeRawData emp)
        {
            InitializeComponent();
            textBoxEmploy.Text = emp.getTitle() + " " + emp.getFname() + " " + emp.getLname();
            textBoxSalary.Text = Convert.ToString(emp.getGrossSalary());
            textBoxNIS.Text = emp.nis.ToString();
            textBoxNHT.Text = emp.nht.ToString();
            textBoxED.Text = emp.edtax.ToString();
            textBoxPAYE.Text = emp.paye.ToString();
            textBoxTotal.Text = emp.totalDeduction.ToString();
            textBoxNet.Text = emp.getNetSalary().ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
