using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeStructureDemo
{
    public partial class FormOperation : Form
    {
        public FormOperation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
          this.Close();
         
        }

        private void buttonCurrentDateAndTime_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            textBoxCurrentDateTime.Text = currentDateTime.ToString();

        }

        private void buttonAddDays_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddDays(2);
            textBoxAddDays.Text = currentDateTime.ToString();
        }

        private void FormOperation_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddMonth_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddMonths(1);
            textBoxAddMonths.Text = currentDateTime.ToString();



        }
    }
}
