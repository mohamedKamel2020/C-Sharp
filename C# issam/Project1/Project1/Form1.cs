namespace Project1
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            this.radioButton1 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.button1 = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = SystemColors.GradientActiveCaption;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new Font("Magneto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.radioButton1.Location = new Point(141, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(103, 32);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = SystemColors.GradientActiveCaption;
            this.radioButton2.Font = new Font("Magneto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.radioButton2.Location = new Point(141, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(126, 32);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "famale";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = Color.IndianRed;
            this.button1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.button1.Location = new Point(141, 163);
            this.button1.Name = "button1";
            this.button1.Size = new Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.Info;
            ClientSize = new Size(644, 244);
            Controls.Add(this.button1);
            Controls.Add(this.radioButton2);
            Controls.Add(this.radioButton1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("this is male");
            }
            else
            {
                MessageBox.Show("this is female");
            }
        }
    }
}