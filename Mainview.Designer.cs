namespace clientScheduler
{
    partial class Mainview
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
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(1369, 19);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(1405, 56);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 20.75F);
            label3.Location = new Point(590, 20);
            label3.Name = "label3";
            label3.Size = new Size(405, 36);
            label3.TabIndex = 2;
            label3.Text = "Client Schedule Management";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(219, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1146, 454);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 18F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(98, 702);
            button1.Name = "button1";
            button1.Size = new Size(414, 127);
            button1.TabIndex = 4;
            button1.Text = "Manage Clients";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 18F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(1062, 702);
            button2.Name = "button2";
            button2.Size = new Size(414, 127);
            button2.TabIndex = 5;
            button2.Text = "Manage Appointments";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Mainview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 900);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Mainview";
            Text = "Client Scheduling";
            FormClosed += mainClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}