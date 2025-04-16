namespace clientScheduler
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(605, 23);
            label1.Name = "label1";
            label1.Size = new Size(300, 33);
            label1.TabIndex = 0;
            label1.Text = "Appointment Manager";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(42, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(692, 430);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += openMonth;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1010, 74);
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
            label3.Location = new Point(291, 73);
            label3.Name = "label3";
            label3.Size = new Size(188, 37);
            label3.TabIndex = 3;
            label3.Text = "Calendar View";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(806, 114);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(692, 178);
            dataGridView2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(1026, 309);
            label4.Name = "label4";
            label4.Size = new Size(262, 37);
            label4.TabIndex = 5;
            label4.Text = "Appointment Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(235, 114);
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
            label6.Location = new Point(369, 114);
            label6.Name = "label6";
            label6.Size = new Size(82, 37);
            label6.TabIndex = 7;
            label6.Text = "None";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView3.Location = new Point(42, 166);
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
            button1.Location = new Point(534, 114);
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
            label7.Location = new Point(42, 114);
            label7.Name = "label7";
            label7.Size = new Size(73, 37);
            label7.TabIndex = 10;
            label7.Text = "Year:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(121, 113);
            label8.Name = "label8";
            label8.Size = new Size(0, 37);
            label8.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(127, 114);
            label9.Name = "label9";
            label9.Size = new Size(82, 37);
            label9.TabIndex = 12;
            label9.Text = "None";
            // 
            // button2
            // 
            button2.Location = new Point(46, 87);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 13;
            button2.Text = "◀";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(121, 87);
            button3.Name = "button3";
            button3.Size = new Size(46, 23);
            button3.TabIndex = 14;
            button3.Text = "▶";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AppointmentEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 908);
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
    }
}