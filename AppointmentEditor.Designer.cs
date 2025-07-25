﻿namespace clientScheduler
{
    partial class AppointmentEditor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView3 = new DataGridView();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            numericUpDown2 = new NumericUpDown();
            label12 = new Label();
            numericUpDown3 = new NumericUpDown();
            label13 = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            textBox2 = new TextBox();
            label15 = new Label();
            textBox3 = new TextBox();
            label16 = new Label();
            textBox4 = new TextBox();
            label17 = new Label();
            textBox5 = new TextBox();
            label18 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label19 = new Label();
            label20 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label21 = new Label();
            label22 = new Label();
            textBox7 = new TextBox();
            label23 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label24 = new Label();
            textBox8 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 33);
            label1.TabIndex = 0;
            label1.Text = "Appointment Manager";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(692, 430);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += openMonth;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(914, 16);
            label2.Name = "label2";
            label2.Size = new Size(300, 37);
            label2.TabIndex = 2;
            label2.Text = "Available Appointments";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(261, 42);
            label3.Name = "label3";
            label3.Size = new Size(188, 37);
            label3.TabIndex = 3;
            label3.Text = "Calendar View";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(710, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(720, 178);
            dataGridView2.TabIndex = 4;
            dataGridView2.Click += rowSelected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(974, 237);
            label4.Name = "label4";
            label4.Size = new Size(262, 37);
            label4.TabIndex = 5;
            label4.Text = "Appointment Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(205, 83);
            label5.Name = "label5";
            label5.Size = new Size(102, 37);
            label5.TabIndex = 6;
            label5.Text = "Month:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(339, 83);
            label6.Name = "label6";
            label6.Size = new Size(82, 37);
            label6.TabIndex = 7;
            label6.Text = "None";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.Location = new Point(12, 138);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(692, 430);
            dataGridView3.TabIndex = 8;
            dataGridView3.CellClick += dataGridView3_CellContentClick;
            dataGridView3.CellContentDoubleClick += clickDay;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(504, 83);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 9;
            button1.Text = "Back to Months";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(12, 83);
            label7.Name = "label7";
            label7.Size = new Size(73, 37);
            label7.TabIndex = 10;
            label7.Text = "Year:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(91, 82);
            label8.Name = "label8";
            label8.Size = new Size(0, 37);
            label8.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(97, 83);
            label9.Name = "label9";
            label9.Size = new Size(82, 37);
            label9.TabIndex = 12;
            label9.Text = "None";
            // 
            // button2
            // 
            button2.Location = new Point(16, 56);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 13;
            button2.Text = "◀";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(91, 56);
            button3.Name = "button3";
            button3.Size = new Size(46, 23);
            button3.TabIndex = 14;
            button3.Text = "▶";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(721, 299);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(732, 281);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 16;
            label10.Text = "Appointment ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(744, 335);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 17;
            label11.Text = "CustomerID";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(721, 353);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 18;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(755, 391);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 19;
            label12.Text = "User ID";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(721, 409);
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 20;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1000, 281);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 21;
            label13.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(872, 298);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(984, 333);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 23;
            label14.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(872, 351);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 23);
            textBox2.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(988, 391);
            label15.Name = "label15";
            label15.Size = new Size(53, 15);
            label15.TabIndex = 25;
            label15.Text = "Location";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(872, 409);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 23);
            textBox3.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(988, 445);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 27;
            label16.Text = "Contact";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(872, 463);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(295, 23);
            textBox4.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(997, 491);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 29;
            label17.Text = "Type";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(872, 509);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(295, 23);
            textBox5.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1000, 534);
            label18.Name = "label18";
            label18.Size = new Size(28, 15);
            label18.TabIndex = 31;
            label18.Text = "URL";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(872, 561);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(295, 23);
            textBox6.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1176, 298);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1258, 280);
            label19.Name = "label19";
            label19.Size = new Size(90, 15);
            label19.TabIndex = 34;
            label19.Text = "Start Date/Time";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(1258, 325);
            label20.Name = "label20";
            label20.Size = new Size(86, 15);
            label20.TabIndex = 35;
            label20.Text = "End Date/Time";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(1176, 353);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 23);
            dateTimePicker2.TabIndex = 36;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(1178, 409);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(254, 23);
            dateTimePicker3.TabIndex = 37;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1262, 391);
            label21.Name = "label21";
            label21.Size = new Size(68, 15);
            label21.TabIndex = 38;
            label21.Text = "Create Date";
            label21.TextAlign = ContentAlignment.TopCenter;
            label21.Click += label21_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(1262, 446);
            label22.Name = "label22";
            label22.Size = new Size(64, 15);
            label22.TabIndex = 39;
            label22.Text = "Created By";
            label22.TextAlign = ContentAlignment.TopCenter;
            label22.Click += label22_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1211, 464);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(176, 23);
            textBox7.TabIndex = 40;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1242, 491);
            label23.Name = "label23";
            label23.Size = new Size(128, 15);
            label23.TabIndex = 41;
            label23.Text = "Last Update Date/Time";
            label23.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Enabled = false;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(1176, 509);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(254, 23);
            dateTimePicker4.TabIndex = 42;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1255, 543);
            label24.Name = "label24";
            label24.Size = new Size(92, 15);
            label24.TabIndex = 43;
            label24.Text = "Last Updated By";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1211, 561);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(176, 23);
            textBox8.TabIndex = 44;
            // 
            // button4
            // 
            button4.Location = new Point(721, 470);
            button4.Name = "button4";
            button4.Size = new Size(120, 23);
            button4.TabIndex = 45;
            button4.Text = "Clear Fields";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Segoe UI", 16F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(847, 607);
            button5.Name = "button5";
            button5.Size = new Size(334, 59);
            button5.TabIndex = 46;
            button5.Text = "Create or Update Record";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Segoe UI", 16F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(710, 509);
            button6.Name = "button6";
            button6.Size = new Size(160, 83);
            button6.TabIndex = 47;
            button6.Text = "Delete Appointment";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // AppointmentEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 682);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox8);
            Controls.Add(label24);
            Controls.Add(dateTimePicker4);
            Controls.Add(label23);
            Controls.Add(textBox7);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label18);
            Controls.Add(textBox5);
            Controls.Add(label17);
            Controls.Add(textBox4);
            Controls.Add(label16);
            Controls.Add(textBox3);
            Controls.Add(label15);
            Controls.Add(textBox2);
            Controls.Add(label14);
            Controls.Add(textBox1);
            Controls.Add(label13);
            Controls.Add(numericUpDown3);
            Controls.Add(label12);
            Controls.Add(numericUpDown2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(dataGridView3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AppointmentEditor";
            Text = "AppointmentEditor";
            Load += AppointmentEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView3;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
        private Button button3;
        private NumericUpDown numericUpDown1;
        private Label label10;
        private Label label11;
        private NumericUpDown numericUpDown2;
        private Label label12;
        private NumericUpDown numericUpDown3;
        private Label label13;
        private TextBox textBox1;
        private Label label14;
        private TextBox textBox2;
        private Label label15;
        private TextBox textBox3;
        private Label label16;
        private TextBox textBox4;
        private Label label17;
        private TextBox textBox5;
        private Label label18;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Label label19;
        private Label label20;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label21;
        private Label label22;
        private TextBox textBox7;
        private Label label23;
        private DateTimePicker dateTimePicker4;
        private Label label24;
        private TextBox textBox8;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}