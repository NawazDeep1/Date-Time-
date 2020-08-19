namespace DateTimeStructureDemo
{
    partial class FormOperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMethods = new System.Windows.Forms.GroupBox();
            this.buttonAddSeconds = new System.Windows.Forms.Button();
            this.buttonAddMinutes = new System.Windows.Forms.Button();
            this.buttonAddHours = new System.Windows.Forms.Button();
            this.buttonAddYears = new System.Windows.Forms.Button();
            this.buttonAddMonth = new System.Windows.Forms.Button();
            this.buttonAddDays = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxAddSeconds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddMinutes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCurrentDateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCurrentDateAndTime = new System.Windows.Forms.Button();
            this.textBoxAddMonths = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddYears = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Methods for performing operations on dates and times";
            // 
            // groupBoxMethods
            // 
            this.groupBoxMethods.Controls.Add(this.buttonAddSeconds);
            this.groupBoxMethods.Controls.Add(this.buttonAddMinutes);
            this.groupBoxMethods.Controls.Add(this.buttonAddHours);
            this.groupBoxMethods.Controls.Add(this.buttonAddYears);
            this.groupBoxMethods.Controls.Add(this.buttonAddMonth);
            this.groupBoxMethods.Controls.Add(this.buttonBack);
            this.groupBoxMethods.Controls.Add(this.buttonAddDays);
            this.groupBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMethods.ForeColor = System.Drawing.Color.Red;
            this.groupBoxMethods.Location = new System.Drawing.Point(562, 129);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Size = new System.Drawing.Size(390, 310);
            this.groupBoxMethods.TabIndex = 4;
            this.groupBoxMethods.TabStop = false;
            this.groupBoxMethods.Text = "Methods";
            // 
            // buttonAddSeconds
            // 
            this.buttonAddSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSeconds.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddSeconds.Location = new System.Drawing.Point(215, 151);
            this.buttonAddSeconds.Name = "buttonAddSeconds";
            this.buttonAddSeconds.Size = new System.Drawing.Size(127, 39);
            this.buttonAddSeconds.TabIndex = 15;
            this.buttonAddSeconds.Tag = "This button shows the current time";
            this.buttonAddSeconds.Text = "AddSeconds";
            this.buttonAddSeconds.UseVisualStyleBackColor = true;
            // 
            // buttonAddMinutes
            // 
            this.buttonAddMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMinutes.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddMinutes.Location = new System.Drawing.Point(215, 89);
            this.buttonAddMinutes.Name = "buttonAddMinutes";
            this.buttonAddMinutes.Size = new System.Drawing.Size(127, 39);
            this.buttonAddMinutes.TabIndex = 14;
            this.buttonAddMinutes.Tag = "This button shows the current time";
            this.buttonAddMinutes.Text = "AddMinutes";
            this.buttonAddMinutes.UseVisualStyleBackColor = true;
            // 
            // buttonAddHours
            // 
            this.buttonAddHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddHours.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddHours.Location = new System.Drawing.Point(215, 32);
            this.buttonAddHours.Name = "buttonAddHours";
            this.buttonAddHours.Size = new System.Drawing.Size(127, 39);
            this.buttonAddHours.TabIndex = 13;
            this.buttonAddHours.Tag = "This button shows the current time";
            this.buttonAddHours.Text = "AddHours";
            this.buttonAddHours.UseVisualStyleBackColor = true;
            // 
            // buttonAddYears
            // 
            this.buttonAddYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddYears.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddYears.Location = new System.Drawing.Point(55, 155);
            this.buttonAddYears.Name = "buttonAddYears";
            this.buttonAddYears.Size = new System.Drawing.Size(120, 39);
            this.buttonAddYears.TabIndex = 11;
            this.buttonAddYears.Tag = "This button shows the current time";
            this.buttonAddYears.Text = "AddYears";
            this.buttonAddYears.UseVisualStyleBackColor = true;
            // 
            // buttonAddMonth
            // 
            this.buttonAddMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMonth.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddMonth.Location = new System.Drawing.Point(55, 93);
            this.buttonAddMonth.Name = "buttonAddMonth";
            this.buttonAddMonth.Size = new System.Drawing.Size(120, 39);
            this.buttonAddMonth.TabIndex = 10;
            this.buttonAddMonth.Tag = "This button shows the current time";
            this.buttonAddMonth.Text = "AddMonth";
            this.buttonAddMonth.UseVisualStyleBackColor = true;
            this.buttonAddMonth.Click += new System.EventHandler(this.buttonAddMonth_Click);
            // 
            // buttonAddDays
            // 
            this.buttonAddDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDays.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddDays.Location = new System.Drawing.Point(55, 36);
            this.buttonAddDays.Name = "buttonAddDays";
            this.buttonAddDays.Size = new System.Drawing.Size(120, 39);
            this.buttonAddDays.TabIndex = 9;
            this.buttonAddDays.Tag = "This button shows the current time";
            this.buttonAddDays.Text = "AddDays";
            this.buttonAddDays.UseVisualStyleBackColor = true;
            this.buttonAddDays.Click += new System.EventHandler(this.buttonAddDays_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Blue;
            this.buttonBack.Location = new System.Drawing.Point(119, 231);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(155, 43);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Tag = "This button shows the current time";
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxAddSeconds
            // 
            this.textBoxAddSeconds.Location = new System.Drawing.Point(301, 373);
            this.textBoxAddSeconds.Name = "textBoxAddSeconds";
            this.textBoxAddSeconds.Size = new System.Drawing.Size(158, 20);
            this.textBoxAddSeconds.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "AddSeconds(120)";
            // 
            // textBoxAddMinutes
            // 
            this.textBoxAddMinutes.Location = new System.Drawing.Point(301, 295);
            this.textBoxAddMinutes.Name = "textBoxAddMinutes";
            this.textBoxAddMinutes.Size = new System.Drawing.Size(158, 20);
            this.textBoxAddMinutes.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "AddMinutes(60)";
            // 
            // textBoxAddHours
            // 
            this.textBoxAddHours.Location = new System.Drawing.Point(301, 225);
            this.textBoxAddHours.Name = "textBoxAddHours";
            this.textBoxAddHours.Size = new System.Drawing.Size(158, 20);
            this.textBoxAddHours.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "AddTwoHours(2)";
            // 
            // textBoxAddDays
            // 
            this.textBoxAddDays.Location = new System.Drawing.Point(70, 225);
            this.textBoxAddDays.Name = "textBoxAddDays";
            this.textBoxAddDays.Size = new System.Drawing.Size(158, 20);
            this.textBoxAddDays.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "AddDays(2)";
            // 
            // textBoxCurrentDateTime
            // 
            this.textBoxCurrentDateTime.Location = new System.Drawing.Point(70, 155);
            this.textBoxCurrentDateTime.Name = "textBoxCurrentDateTime";
            this.textBoxCurrentDateTime.Size = new System.Drawing.Size(158, 20);
            this.textBoxCurrentDateTime.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Current Date and Time";
            // 
            // buttonCurrentDateAndTime
            // 
            this.buttonCurrentDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrentDateAndTime.ForeColor = System.Drawing.Color.Blue;
            this.buttonCurrentDateAndTime.Location = new System.Drawing.Point(304, 97);
            this.buttonCurrentDateAndTime.Name = "buttonCurrentDateAndTime";
            this.buttonCurrentDateAndTime.Size = new System.Drawing.Size(155, 74);
            this.buttonCurrentDateAndTime.TabIndex = 41;
            this.buttonCurrentDateAndTime.Tag = "This button shows the current time";
            this.buttonCurrentDateAndTime.Text = "Current TIme";
            this.buttonCurrentDateAndTime.UseVisualStyleBackColor = true;
            this.buttonCurrentDateAndTime.Click += new System.EventHandler(this.buttonCurrentDateAndTime_Click);
            // 
            // textBoxAddMonths
            // 
            this.textBoxAddMonths.Location = new System.Drawing.Point(70, 295);
            this.textBoxAddMonths.Name = "textBoxAddMonths";
            this.textBoxAddMonths.Size = new System.Drawing.Size(158, 20);
            this.textBoxAddMonths.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "AddMonth(1)";
            // 
            // textBoxAddYears
            // 
            this.textBoxAddYears.Location = new System.Drawing.Point(70, 373);
            this.textBoxAddYears.Name = "textBoxAddYears";
            this.textBoxAddYears.Size = new System.Drawing.Size(158, 20);
            this.textBoxAddYears.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "AddYears(3)";
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 480);
            this.Controls.Add(this.textBoxAddYears);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAddMonths);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCurrentDateAndTime);
            this.Controls.Add(this.textBoxAddSeconds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAddMinutes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCurrentDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxMethods);
            this.Controls.Add(this.label1);
            this.Name = "FormOperation";
            this.Text = "FormOperation";
            this.Load += new System.EventHandler(this.FormOperation_Load);
            this.groupBoxMethods.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMethods;
        private System.Windows.Forms.Button buttonAddSeconds;
        private System.Windows.Forms.Button buttonAddMinutes;
        private System.Windows.Forms.Button buttonAddHours;
        private System.Windows.Forms.Button buttonAddYears;
        private System.Windows.Forms.Button buttonAddMonth;
        private System.Windows.Forms.Button buttonAddDays;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxAddSeconds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCurrentDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCurrentDateAndTime;
        private System.Windows.Forms.TextBox textBoxAddMonths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddYears;
        private System.Windows.Forms.Label label7;
    }
}