namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtX = new TextBox();
            button1 = new Button();
            txtY = new TextBox();
            labelResult = new Label();
            targetX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NtxtY = new TextBox();
            NtxtX = new TextBox();
            NtargetX = new TextBox();
            button2 = new Button();
            NlabelResult = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Location = new Point(209, 166);
            txtX.Margin = new Padding(4, 3, 4, 3);
            txtX.Name = "txtX";
            txtX.Size = new Size(582, 37);
            txtX.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(209, 429);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(157, 50);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtY
            // 
            txtY.Location = new Point(209, 258);
            txtY.Margin = new Padding(4, 3, 4, 3);
            txtY.Name = "txtY";
            txtY.Size = new Size(582, 37);
            txtY.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = SystemColors.GradientActiveCaption;
            labelResult.Location = new Point(524, 454);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(90, 25);
            labelResult.TabIndex = 3;
            labelResult.Text = "Result";
            // 
            // targetX
            // 
            targetX.Location = new Point(209, 349);
            targetX.Margin = new Padding(4, 3, 4, 3);
            targetX.Name = "targetX";
            targetX.Size = new Size(208, 37);
            targetX.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(85, 178);
            label1.Margin = new Padding(10, 5, 10, 5);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 5;
            label1.Text = "X [] =  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(84, 261);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 6;
            label2.Text = "F(X) = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Andalus", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 347);
            label3.Name = "label3";
            label3.Size = new Size(85, 34);
            label3.TabIndex = 7;
            label3.Text = "target X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Andalus", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(298, 60);
            label4.Name = "label4";
            label4.Size = new Size(247, 43);
            label4.TabIndex = 8;
            label4.Text = "Lagrang Polynomial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Andalus", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(1121, 60);
            label5.Name = "label5";
            label5.Size = new Size(209, 43);
            label5.TabIndex = 9;
            label5.Text = "Neville's Method";
            // 
            // NtxtY
            // 
            NtxtY.Location = new Point(1025, 258);
            NtxtY.Margin = new Padding(4, 3, 4, 3);
            NtxtY.Name = "NtxtY";
            NtxtY.Size = new Size(582, 37);
            NtxtY.TabIndex = 10;
            // 
            // NtxtX
            // 
            NtxtX.Location = new Point(1025, 166);
            NtxtX.Margin = new Padding(4, 3, 4, 3);
            NtxtX.Name = "NtxtX";
            NtxtX.Size = new Size(582, 37);
            NtxtX.TabIndex = 11;
            // 
            // NtargetX
            // 
            NtargetX.Location = new Point(1025, 349);
            NtargetX.Margin = new Padding(4, 3, 4, 3);
            NtargetX.Name = "NtargetX";
            NtargetX.Size = new Size(208, 37);
            NtargetX.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1025, 429);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(157, 50);
            button2.TabIndex = 13;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // NlabelResult
            // 
            NlabelResult.AutoSize = true;
            NlabelResult.BackColor = SystemColors.GradientActiveCaption;
            NlabelResult.Location = new Point(1334, 454);
            NlabelResult.Margin = new Padding(4, 0, 4, 0);
            NlabelResult.Name = "NlabelResult";
            NlabelResult.Size = new Size(90, 25);
            NlabelResult.TabIndex = 14;
            NlabelResult.Text = "Result";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Location = new Point(883, 178);
            label7.Margin = new Padding(10, 5, 10, 5);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 15;
            label7.Text = "X [] =  ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientActiveCaption;
            label8.Location = new Point(883, 270);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 16;
            label8.Text = "F(X) = ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.Font = new Font("Andalus", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(883, 352);
            label9.Name = "label9";
            label9.Size = new Size(85, 34);
            label9.TabIndex = 17;
            label9.Text = "target X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1703, 636);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(NlabelResult);
            Controls.Add(button2);
            Controls.Add(NtargetX);
            Controls.Add(NtxtX);
            Controls.Add(NtxtY);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(targetX);
            Controls.Add(labelResult);
            Controls.Add(txtY);
            Controls.Add(button1);
            Controls.Add(txtX);
            Font = new Font("Algerian", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "MATH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX;
        private Button button1;
        private TextBox txtY;
        private Label labelResult;
        private TextBox targetX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NtxtY;
        private TextBox NtxtX;
        private TextBox NtargetX;
        private Button button2;
        private Label NlabelResult;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
