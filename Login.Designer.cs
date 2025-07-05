namespace clientScheduler;

partial class Login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        label3 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(351, 196);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 0;
        button1.Text = "Log In";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(289, 95);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(198, 23);
        textBox1.TabIndex = 1;
        textBox1.Text = "User Name";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(289, 149);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(198, 23);
        textBox2.TabIndex = 2;
        textBox2.Text = "Password";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(351, 336);
        label1.Name = "label1";
        label1.Size = new Size(48, 15);
        label1.TabIndex = 4;
        label1.Text = "Locality";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(335, 361);
        label2.Name = "label2";
        label2.Size = new Size(108, 15);
        label2.TabIndex = 5;
        label2.Text = "Language (System)";
        label2.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Checked = true;
        radioButton1.Location = new Point(289, 390);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(88, 19);
        radioButton1.TabIndex = 6;
        radioButton1.TabStop = true;
        radioButton1.Text = "English (US)";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(393, 390);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(93, 19);
        radioButton2.TabIndex = 7;
        radioButton2.Text = "Deutsch (DE)";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(261, 311);
        label3.Name = "label3";
        label3.Size = new Size(64, 15);
        label3.TabIndex = 8;
        label3.Text = "Time Zone";
        label3.Click += label3_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label3);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Name = "Login";
        Text = "Client Scheduling";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Label label2;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private Label label3;
}
