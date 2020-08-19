namespace DateTimeStructureDemo
{
    partial class FormDateTime
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNow = new System.Windows.Forms.TextBox();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.buttonTimeOfDay = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonDay = new System.Windows.Forms.Button();
            this.buttonDayOfYear = new System.Windows.Forms.Button();
            this.buttonDayOfWeek = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonNow = new System.Windows.Forms.Button();
            this.textBoxToday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDayOfWeek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTimeOfDay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDayOfYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLongDate = new System.Windows.Forms.TextBox();
            this.textBoxLongTime = new System.Windows.Forms.TextBox();
            this.labelLongTime = new System.Windows.Forms.Label();
            this.textBoxShortTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxShortDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxMethods = new System.Windows.Forms.GroupBox();
            this.buttonLongDate = new System.Windows.Forms.Button();
            this.buttonShortDate = new System.Windows.Forms.Button();
            this.buttonShortTime = new System.Windows.Forms.Button();
            this.buttonLongTime = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxProperties.SuspendLayout();
            this.groupBoxMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(265, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilization of Date and Time Structure in C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Now";
            // 
            // textBoxNow
            // 
            this.textBoxNow.Location = new System.Drawing.Point(57, 113);
            this.textBoxNow.Name = "textBoxNow";
            this.textBoxNow.Size = new System.Drawing.Size(158, 20);
            this.textBoxNow.TabIndex = 1;
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.buttonTimeOfDay);
            this.groupBoxProperties.Controls.Add(this.buttonClear);
            this.groupBoxProperties.Controls.Add(this.buttonMonth);
            this.groupBoxProperties.Controls.Add(this.buttonYear);
            this.groupBoxProperties.Controls.Add(this.buttonDay);
            this.groupBoxProperties.Controls.Add(this.buttonDayOfYear);
            this.groupBoxProperties.Controls.Add(this.buttonDayOfWeek);
            this.groupBoxProperties.Controls.Add(this.buttonToday);
            this.groupBoxProperties.Controls.Add(this.buttonNow);
            this.groupBoxProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProperties.ForeColor = System.Drawing.Color.Red;
            this.groupBoxProperties.Location = new System.Drawing.Point(616, 66);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(390, 310);
            this.groupBoxProperties.TabIndex = 3;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties";
            this.groupBoxProperties.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonTimeOfDay
            // 
            this.buttonTimeOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeOfDay.ForeColor = System.Drawing.Color.Blue;
            this.buttonTimeOfDay.Location = new System.Drawing.Point(215, 208);
            this.buttonTimeOfDay.Name = "buttonTimeOfDay";
            this.buttonTimeOfDay.Size = new System.Drawing.Size(127, 39);
            this.buttonTimeOfDay.TabIndex = 16;
            this.buttonTimeOfDay.Tag = "This button shows the current time";
            this.buttonTimeOfDay.Text = "TimeOfDay";
            this.buttonTimeOfDay.UseVisualStyleBackColor = true;
            this.buttonTimeOfDay.Click += new System.EventHandler(this.buttonTimeOfDay_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonth.ForeColor = System.Drawing.Color.Blue;
            this.buttonMonth.Location = new System.Drawing.Point(215, 151);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(127, 39);
            this.buttonMonth.TabIndex = 15;
            this.buttonMonth.Tag = "This button shows the current time";
            this.buttonMonth.Text = "Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYear.ForeColor = System.Drawing.Color.Blue;
            this.buttonYear.Location = new System.Drawing.Point(215, 89);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(127, 39);
            this.buttonYear.TabIndex = 14;
            this.buttonYear.Tag = "This button shows the current time";
            this.buttonYear.Text = "Year";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay.ForeColor = System.Drawing.Color.Blue;
            this.buttonDay.Location = new System.Drawing.Point(215, 32);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(127, 39);
            this.buttonDay.TabIndex = 13;
            this.buttonDay.Tag = "This button shows the current time";
            this.buttonDay.Text = "Day";
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // buttonDayOfYear
            // 
            this.buttonDayOfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDayOfYear.ForeColor = System.Drawing.Color.Blue;
            this.buttonDayOfYear.Location = new System.Drawing.Point(55, 208);
            this.buttonDayOfYear.Name = "buttonDayOfYear";
            this.buttonDayOfYear.Size = new System.Drawing.Size(120, 39);
            this.buttonDayOfYear.TabIndex = 12;
            this.buttonDayOfYear.Tag = "This button shows the current time";
            this.buttonDayOfYear.Text = "DayOfYear";
            this.buttonDayOfYear.UseVisualStyleBackColor = true;
            this.buttonDayOfYear.Click += new System.EventHandler(this.buttonDayOfYear_Click);
            // 
            // buttonDayOfWeek
            // 
            this.buttonDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDayOfWeek.ForeColor = System.Drawing.Color.Blue;
            this.buttonDayOfWeek.Location = new System.Drawing.Point(55, 155);
            this.buttonDayOfWeek.Name = "buttonDayOfWeek";
            this.buttonDayOfWeek.Size = new System.Drawing.Size(120, 39);
            this.buttonDayOfWeek.TabIndex = 11;
            this.buttonDayOfWeek.Tag = "This button shows the current time";
            this.buttonDayOfWeek.Text = "DayOfWeek";
            this.buttonDayOfWeek.UseVisualStyleBackColor = true;
            this.buttonDayOfWeek.Click += new System.EventHandler(this.buttonDayOfWeek_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.Blue;
            this.buttonToday.Location = new System.Drawing.Point(55, 93);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(120, 39);
            this.buttonToday.TabIndex = 10;
            this.buttonToday.Tag = "This button shows the current time";
            this.buttonToday.Text = "&Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonNow
            // 
            this.buttonNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNow.ForeColor = System.Drawing.Color.Blue;
            this.buttonNow.Location = new System.Drawing.Point(55, 36);
            this.buttonNow.Name = "buttonNow";
            this.buttonNow.Size = new System.Drawing.Size(120, 39);
            this.buttonNow.TabIndex = 9;
            this.buttonNow.Tag = "This button shows the current time";
            this.buttonNow.Text = "&Now";
            this.buttonNow.UseVisualStyleBackColor = true;
            this.buttonNow.Click += new System.EventHandler(this.buttonNow_Click);
            // 
            // textBoxToday
            // 
            this.textBoxToday.Location = new System.Drawing.Point(57, 183);
            this.textBoxToday.Name = "textBoxToday";
            this.textBoxToday.Size = new System.Drawing.Size(158, 20);
            this.textBoxToday.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Today";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(237, 183);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(158, 20);
            this.textBoxDay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Day";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(237, 113);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(158, 20);
            this.textBoxMonth.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Month";
            // 
            // textBoxDayOfWeek
            // 
            this.textBoxDayOfWeek.Location = new System.Drawing.Point(433, 183);
            this.textBoxDayOfWeek.Name = "textBoxDayOfWeek";
            this.textBoxDayOfWeek.Size = new System.Drawing.Size(158, 20);
            this.textBoxDayOfWeek.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Day of  Week";
            // 
            // textBoxTimeOfDay
            // 
            this.textBoxTimeOfDay.Location = new System.Drawing.Point(433, 113);
            this.textBoxTimeOfDay.Name = "textBoxTimeOfDay";
            this.textBoxTimeOfDay.Size = new System.Drawing.Size(158, 20);
            this.textBoxTimeOfDay.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Time of Day";
            // 
            // textBoxDayOfYear
            // 
            this.textBoxDayOfYear.Location = new System.Drawing.Point(433, 261);
            this.textBoxDayOfYear.Name = "textBoxDayOfYear";
            this.textBoxDayOfYear.Size = new System.Drawing.Size(158, 20);
            this.textBoxDayOfYear.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Day of Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(237, 261);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(158, 20);
            this.textBoxYear.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "year";
            // 
            // buttonOperation
            // 
            this.buttonOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperation.ForeColor = System.Drawing.Color.Blue;
            this.buttonOperation.Location = new System.Drawing.Point(57, 304);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Size = new System.Drawing.Size(158, 74);
            this.buttonOperation.TabIndex = 17;
            this.buttonOperation.Tag = "This button shows the current time";
            this.buttonOperation.Text = "Operantions of Date and Time";
            this.buttonOperation.UseVisualStyleBackColor = true;
            this.buttonOperation.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Long Date";
            // 
            // textBoxLongDate
            // 
            this.textBoxLongDate.Location = new System.Drawing.Point(237, 436);
            this.textBoxLongDate.Name = "textBoxLongDate";
            this.textBoxLongDate.Size = new System.Drawing.Size(158, 20);
            this.textBoxLongDate.TabIndex = 19;
            // 
            // textBoxLongTime
            // 
            this.textBoxLongTime.Location = new System.Drawing.Point(237, 512);
            this.textBoxLongTime.Name = "textBoxLongTime";
            this.textBoxLongTime.Size = new System.Drawing.Size(158, 20);
            this.textBoxLongTime.TabIndex = 21;
            // 
            // labelLongTime
            // 
            this.labelLongTime.AutoSize = true;
            this.labelLongTime.Location = new System.Drawing.Point(234, 486);
            this.labelLongTime.Name = "labelLongTime";
            this.labelLongTime.Size = new System.Drawing.Size(57, 13);
            this.labelLongTime.TabIndex = 20;
            this.labelLongTime.Text = "Long Time";
            // 
            // textBoxShortTime
            // 
            this.textBoxShortTime.Location = new System.Drawing.Point(417, 512);
            this.textBoxShortTime.Name = "textBoxShortTime";
            this.textBoxShortTime.Size = new System.Drawing.Size(158, 20);
            this.textBoxShortTime.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Short Time";
            // 
            // textBoxShortDate
            // 
            this.textBoxShortDate.Location = new System.Drawing.Point(417, 436);
            this.textBoxShortDate.Name = "textBoxShortDate";
            this.textBoxShortDate.Size = new System.Drawing.Size(158, 20);
            this.textBoxShortDate.TabIndex = 23;
            this.textBoxShortDate.TextChanged += new System.EventHandler(this.textBoxShortDate_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Short Date";
            // 
            // groupBoxMethods
            // 
            this.groupBoxMethods.Controls.Add(this.buttonShortTime);
            this.groupBoxMethods.Controls.Add(this.buttonLongTime);
            this.groupBoxMethods.Controls.Add(this.buttonShortDate);
            this.groupBoxMethods.Controls.Add(this.buttonLongDate);
            this.groupBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMethods.ForeColor = System.Drawing.Color.Red;
            this.groupBoxMethods.Location = new System.Drawing.Point(616, 382);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Size = new System.Drawing.Size(390, 186);
            this.groupBoxMethods.TabIndex = 26;
            this.groupBoxMethods.TabStop = false;
            this.groupBoxMethods.Text = "Methods";
            // 
            // buttonLongDate
            // 
            this.buttonLongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLongDate.ForeColor = System.Drawing.Color.Blue;
            this.buttonLongDate.Location = new System.Drawing.Point(27, 49);
            this.buttonLongDate.Name = "buttonLongDate";
            this.buttonLongDate.Size = new System.Drawing.Size(160, 39);
            this.buttonLongDate.TabIndex = 17;
            this.buttonLongDate.Text = "ToLongDateString";
            this.buttonLongDate.UseVisualStyleBackColor = true;
            this.buttonLongDate.Click += new System.EventHandler(this.buttonLongDate_Click);
            // 
            // buttonShortDate
            // 
            this.buttonShortDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShortDate.ForeColor = System.Drawing.Color.Blue;
            this.buttonShortDate.Location = new System.Drawing.Point(206, 49);
            this.buttonShortDate.Name = "buttonShortDate";
            this.buttonShortDate.Size = new System.Drawing.Size(160, 39);
            this.buttonShortDate.TabIndex = 18;
            this.buttonShortDate.Text = "ToShortDateString";
            this.buttonShortDate.UseVisualStyleBackColor = true;
            this.buttonShortDate.Click += new System.EventHandler(this.buttonShortDate_Click);
            // 
            // buttonShortTime
            // 
            this.buttonShortTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShortTime.ForeColor = System.Drawing.Color.Blue;
            this.buttonShortTime.Location = new System.Drawing.Point(206, 116);
            this.buttonShortTime.Name = "buttonShortTime";
            this.buttonShortTime.Size = new System.Drawing.Size(160, 39);
            this.buttonShortTime.TabIndex = 20;
            this.buttonShortTime.Text = "ToShortTimeString";
            this.buttonShortTime.UseVisualStyleBackColor = true;
            this.buttonShortTime.Click += new System.EventHandler(this.buttonShortTime_Click);
            // 
            // buttonLongTime
            // 
            this.buttonLongTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLongTime.ForeColor = System.Drawing.Color.Blue;
            this.buttonLongTime.Location = new System.Drawing.Point(27, 116);
            this.buttonLongTime.Name = "buttonLongTime";
            this.buttonLongTime.Size = new System.Drawing.Size(160, 39);
            this.buttonLongTime.TabIndex = 19;
            this.buttonLongTime.Text = "ToLongTimeString";
            this.buttonLongTime.UseVisualStyleBackColor = true;
            this.buttonLongTime.Click += new System.EventHandler(this.buttonLongTime_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Blue;
            this.buttonClear.Location = new System.Drawing.Point(127, 253);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(155, 44);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Tag = "This button shows the current time";
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Blue;
            this.buttonClose.Location = new System.Drawing.Point(57, 489);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(158, 44);
            this.buttonClose.TabIndex = 28;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 615);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxMethods);
            this.Controls.Add(this.textBoxShortTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxShortDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxLongTime);
            this.Controls.Add(this.labelLongTime);
            this.Controls.Add(this.textBoxLongDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonOperation);
            this.Controls.Add(this.textBoxDayOfYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDayOfWeek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTimeOfDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxToday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.textBoxNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDateTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDateTime_Load);
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxMethods.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNow;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.Button buttonNow;
        private System.Windows.Forms.TextBox textBoxToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonTimeOfDay;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.Button buttonDayOfYear;
        private System.Windows.Forms.Button buttonDayOfWeek;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDayOfWeek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTimeOfDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDayOfYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLongDate;
        private System.Windows.Forms.TextBox textBoxLongTime;
        private System.Windows.Forms.Label labelLongTime;
        private System.Windows.Forms.TextBox textBoxShortTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxShortDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxMethods;
        private System.Windows.Forms.Button buttonShortTime;
        private System.Windows.Forms.Button buttonLongTime;
        private System.Windows.Forms.Button buttonShortDate;
        private System.Windows.Forms.Button buttonLongDate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
    }
}

