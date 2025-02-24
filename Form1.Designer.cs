namespace ProgrammingExercise3_1
{
    partial class Form1
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
            textBox1 = new TextBox();
            label1 = new Label();
            CalculateButton = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 134);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Inches";
            label1.Click += label1_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.AccessibleName = "";
            CalculateButton.Location = new Point(280, 215);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(194, 23);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Click to Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 176);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Centimeters";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(342, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "Please use this tool to convert inches calculated to centimeters";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 551);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(CalculateButton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "ProgrammingForm3_1_Andrew_Stribling_Submission";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button CalculateButton;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
