namespace WinFormsAppTest
{
    partial class MathQuiz
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            timeLeftLabel = new Label();
            plusLeftLabel = new Label();
            plusLabel = new Label();
            plusRightLabel = new Label();
            equalLabel_plus = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            equalLabel_minus = new Label();
            minusRightLabel = new Label();
            minus = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            equalLabel_multiply = new Label();
            timesRightLabel = new Label();
            multiplyLabel = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            equalLabel_divide = new Label();
            dividedRightLabel = new Label();
            devideLabel = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("맑은 고딕", 15.75F);
            timeLabel.Location = new Point(268, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // timeLeftLabel
            // 
            timeLeftLabel.AutoSize = true;
            timeLeftLabel.Font = new Font("맑은 고딕", 15.75F);
            timeLeftLabel.Location = new Point(166, 10);
            timeLeftLabel.Name = "timeLeftLabel";
            timeLeftLabel.Size = new Size(100, 30);
            timeLeftLabel.TabIndex = 1;
            timeLeftLabel.Text = "Time Left";
            timeLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("맑은 고딕", 18F);
            plusLeftLabel.Location = new Point(50, 55);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusLabel
            // 
            plusLabel.Font = new Font("맑은 고딕", 18F);
            plusLabel.Location = new Point(116, 55);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(60, 50);
            plusLabel.TabIndex = 3;
            plusLabel.Text = "+";
            plusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("맑은 고딕", 18F);
            plusRightLabel.Location = new Point(182, 55);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalLabel_plus
            // 
            equalLabel_plus.Font = new Font("맑은 고딕", 18F);
            equalLabel_plus.Location = new Point(248, 55);
            equalLabel_plus.Name = "equalLabel_plus";
            equalLabel_plus.Size = new Size(60, 50);
            equalLabel_plus.TabIndex = 5;
            equalLabel_plus.Text = "=";
            equalLabel_plus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("맑은 고딕", 18F);
            sum.Location = new Point(314, 62);
            sum.MaximumSize = new Size(100, 0);
            sum.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            // 
            // difference
            // 
            difference.Font = new Font("맑은 고딕", 18F);
            difference.Location = new Point(314, 112);
            difference.MaximumSize = new Size(100, 0);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            // 
            // equalLabel_minus
            // 
            equalLabel_minus.Font = new Font("맑은 고딕", 18F);
            equalLabel_minus.Location = new Point(248, 105);
            equalLabel_minus.Name = "equalLabel_minus";
            equalLabel_minus.Size = new Size(60, 50);
            equalLabel_minus.TabIndex = 10;
            equalLabel_minus.Text = "=";
            equalLabel_minus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("맑은 고딕", 18F);
            minusRightLabel.Location = new Point(182, 105);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 9;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minus
            // 
            minus.Font = new Font("맑은 고딕", 18F);
            minus.Location = new Point(116, 105);
            minus.Name = "minus";
            minus.Size = new Size(60, 50);
            minus.TabIndex = 8;
            minus.Text = "-";
            minus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("맑은 고딕", 18F);
            minusLeftLabel.Location = new Point(50, 105);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("맑은 고딕", 18F);
            product.Location = new Point(314, 162);
            product.MaximumSize = new Size(100, 0);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            // 
            // equalLabel_multiply
            // 
            equalLabel_multiply.Font = new Font("맑은 고딕", 18F);
            equalLabel_multiply.Location = new Point(248, 155);
            equalLabel_multiply.Name = "equalLabel_multiply";
            equalLabel_multiply.Size = new Size(60, 50);
            equalLabel_multiply.TabIndex = 15;
            equalLabel_multiply.Text = "=";
            equalLabel_multiply.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("맑은 고딕", 18F);
            timesRightLabel.Location = new Point(182, 155);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplyLabel
            // 
            multiplyLabel.Font = new Font("맑은 고딕", 18F);
            multiplyLabel.Location = new Point(116, 155);
            multiplyLabel.Name = "multiplyLabel";
            multiplyLabel.Size = new Size(60, 50);
            multiplyLabel.TabIndex = 13;
            multiplyLabel.Text = "×";
            multiplyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("맑은 고딕", 18F);
            timesLeftLabel.Location = new Point(50, 155);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("맑은 고딕", 18F);
            quotient.Location = new Point(314, 212);
            quotient.MaximumSize = new Size(100, 0);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            // 
            // equalLabel_divide
            // 
            equalLabel_divide.Font = new Font("맑은 고딕", 18F);
            equalLabel_divide.Location = new Point(248, 205);
            equalLabel_divide.Name = "equalLabel_divide";
            equalLabel_divide.Size = new Size(60, 50);
            equalLabel_divide.TabIndex = 20;
            equalLabel_divide.Text = "=";
            equalLabel_divide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("맑은 고딕", 18F);
            dividedRightLabel.Location = new Point(182, 205);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 19;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // devideLabel
            // 
            devideLabel.Font = new Font("맑은 고딕", 18F);
            devideLabel.Location = new Point(116, 205);
            devideLabel.Name = "devideLabel";
            devideLabel.Size = new Size(60, 50);
            devideLabel.TabIndex = 18;
            devideLabel.Text = "÷";
            devideLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("맑은 고딕", 18F);
            dividedLeftLabel.Location = new Point(50, 205);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.None;
            startButton.AutoSize = true;
            startButton.Font = new Font("맑은 고딕", 14F);
            startButton.Location = new Point(175, 300);
            startButton.Name = "startButton";
            startButton.Size = new Size(141, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MathQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 357);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(equalLabel_divide);
            Controls.Add(dividedRightLabel);
            Controls.Add(devideLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(equalLabel_multiply);
            Controls.Add(timesRightLabel);
            Controls.Add(multiplyLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(equalLabel_minus);
            Controls.Add(minusRightLabel);
            Controls.Add(minus);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(equalLabel_plus);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(timeLeftLabel);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimizeBox = false;
            Name = "MathQuiz";
            Text = "Math Quze";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label timeLeftLabel;
        private Label plusLeftLabel;
        private Label plusLabel;
        private Label plusRightLabel;
        private Label equalLabel_plus;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label equalLabel_minus;
        private Label minusRightLabel;
        private Label minus;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label equalLabel_multiply;
        private Label timesRightLabel;
        private Label multiplyLabel;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label equalLabel_divide;
        private Label dividedRightLabel;
        private Label devideLabel;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
