namespace DateTimeStructureDemo
{
    using System;
    using System.Windows.Forms;

    public partial class FormDateTime : Form
    {
        public FormDateTime()
        {
            InitializeComponent();
        }

        private void FormDateTime_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property now gets the current date and time", "Current Date and Time");
            DateTime currentDate = DateTime.Now;
            textBoxNow.Text = currentDate.ToString();
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property TODAY gets the current date", "Current Date");
            DateTime currentDate = DateTime.Today;
            textBoxToday.Text = currentDate.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void buttonDayOfWeek_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Gets the day of the week name represented by this DateTIme Value", "Day name of week");
            DateTime currentDateTime = DateTime.Now;
            textBoxDayOfWeek.Text = currentDateTime.DayOfWeek.ToString();
        }

        private void buttonDayOfYear_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Gets the number of days of the year represented by this DateTime Value", "Day of year");
            DateTime currentDateTime = DateTime.Now;
            textBoxDayOfYear.Text = currentDateTime.DayOfYear.ToString();
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {

            MessageBox.Show("The property DAY gets the day component of the date", "Day");
            DateTime currentDate = DateTime.Today;
            textBoxDay.Text = currentDate.Day.ToString();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property YEAR gets the year component of the date", "Year");
            DateTime currentDate = DateTime.Today;
            textBoxYear.Text = currentDate.Year.ToString();
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property MONTH gets the month component of the date", "Month");
            DateTime currentDate = DateTime.Today;
            textBoxMonth.Text = currentDate.Month.ToString();
        }

        private void buttonTimeOfDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gets the time of the day represented by this DateTime Value", "Time of day");
            DateTime currentDateTime = DateTime.Now;
            textBoxTimeOfDay.Text = currentDateTime.TimeOfDay.ToString();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {

            //create an object of FormOperation (in C# the forms as classes)
            FormOperation aForm = new FormOperation();
            
            
            //To display a form as a modal dialog box
            aForm.ShowDialog();

            //To display a form as a modeless dialog box
            //aForm.Show();


        }

        private void textBoxShortDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonLongDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Convert the DateTime Value to a String \n" +
                            "that includes the day of the weel name, \n " +
                            "the month name, the day of the month, and the year.", "Long Date");

            DateTime currentDate = DateTime.Today;

            textBoxLongDate.Text = currentDate.ToLongDateString();

        }

        private void buttonShortDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Convert the DateTime Value to a String \n" +
                            "that includes the numeric month, day and year.", "Short Date");

            DateTime currentDate = DateTime.Today;

            textBoxShortDate.Text = currentDate.ToShortDateString();
        }

        private void buttonLongTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Convert the DateTime Value to a String \n" +
                               "that includes hours minutes and seconds", "Long Time");

            DateTime currentDateTime = DateTime.Now;

            textBoxLongTime.Text = currentDateTime.ToLongTimeString();

        }

        private void buttonShortTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Convert the DateTime Value to a String \n" +
                               "that includes hours minutes and seconds", "Short Time");

            DateTime currentDateTime = DateTime.Now;

            textBoxShortTime.Text = currentDateTime.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDay.Clear();
            textBoxDayOfWeek.Clear();
            textBoxDayOfYear.Clear();
            textBoxLongDate.Clear();
            textBoxLongTime.Clear();
            textBoxMonth.Clear();
            textBoxNow.Clear();
            textBoxShortDate.Clear();
            textBoxShortTime.Clear();
            textBoxTimeOfDay.Clear();
            textBoxToday.Clear();
            textBoxYear.Clear();
            textBoxNow.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
