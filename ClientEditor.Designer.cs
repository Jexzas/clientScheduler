namespace clientScheduler
{
    partial class clientEditor
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            numericUpDown3 = new NumericUpDown();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(690, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 39);
            label1.TabIndex = 0;
            label1.Text = "Client Editor";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1541, 211);
            dataGridView1.TabIndex = 1;
            dataGridView1.Click += rowSelected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(298, 293);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 2;
            label2.Text = "Client Information";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 322);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 3;
            label3.Text = "Client ID";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(33, 360);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 30);
            numericUpDown1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 407);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 5;
            label4.Text = "Client Name";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 452);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 538);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 30);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 490);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 7;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 585);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 9;
            label6.Text = "City ID";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(33, 625);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 30);
            numericUpDown2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(400, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 30);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(400, 322);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 11;
            label7.Text = "Postal Code";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(400, 452);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 30);
            textBox4.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(400, 407);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 13;
            label8.Text = "Phone";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(400, 539);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 30);
            numericUpDown3.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(400, 490);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 15;
            label9.Text = "Active? ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(690, 337);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(884, 386);
            dataGridView2.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(1068, 293);
            label10.Name = "label10";
            label10.Size = new Size(201, 25);
            label10.TabIndex = 18;
            label10.Text = "Client's Appointments";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(33, 684);
            button1.Name = "button1";
            button1.Size = new Size(184, 39);
            button1.TabIndex = 19;
            button1.Text = "Update (or Create)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Location = new Point(399, 684);
            button2.Name = "button2";
            button2.Size = new Size(184, 39);
            button2.TabIndex = 20;
            button2.Text = "Delete Record";
            button2.UseVisualStyleBackColor = false;
            // 
            // clientEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 757);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(dataGridView2);
            Controls.Add(numericUpDown3);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(numericUpDown2);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 7, 5, 7);
            Name = "clientEditor";
            Text = "clientEditor";
            Load += clientEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private NumericUpDown numericUpDown3;
        private Label label9;
        private DataGridView dataGridView2;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}