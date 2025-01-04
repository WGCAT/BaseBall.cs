namespace BaseBall
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
            btnGeneration = new Button();
            lblBool = new Label();
            tbNum1 = new TextBox();
            btnInput = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lblStrike = new Label();
            lblBall = new Label();
            tbNum2 = new TextBox();
            tbNum3 = new TextBox();
            lblTest = new Label();
            lbxHistory = new ListBox();
            lblHistory = new Label();
            lbxSB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGeneration
            // 
            btnGeneration.Location = new Point(12, 12);
            btnGeneration.Name = "btnGeneration";
            btnGeneration.Size = new Size(72, 35);
            btnGeneration.TabIndex = 0;
            btnGeneration.Text = "시작";
            btnGeneration.UseVisualStyleBackColor = true;
            btnGeneration.Click += btnGeneration_Click;
            // 
            // lblBool
            // 
            lblBool.AutoSize = true;
            lblBool.Location = new Point(143, 22);
            lblBool.Name = "lblBool";
            lblBool.Size = new Size(110, 15);
            lblBool.TabIndex = 1;
            lblBool.Text = "시작을 눌러주세요.";
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(17, 81);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(38, 23);
            tbNum1.TabIndex = 2;
            // 
            // btnInput
            // 
            btnInput.Location = new Point(168, 81);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(75, 23);
            btnInput.TabIndex = 5;
            btnInput.Text = "입력";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(17, 340);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(67, 15);
            lbl1.TabIndex = 6;
            lbl1.Text = "스트라이크";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(36, 377);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(19, 15);
            lbl2.TabIndex = 7;
            lbl2.Text = "볼";
            // 
            // lblStrike
            // 
            lblStrike.AutoSize = true;
            lblStrike.Location = new Point(119, 340);
            lblStrike.Name = "lblStrike";
            lblStrike.Size = new Size(39, 15);
            lblStrike.TabIndex = 8;
            lblStrike.Text = "label1";
            // 
            // lblBall
            // 
            lblBall.AutoSize = true;
            lblBall.Location = new Point(119, 377);
            lblBall.Name = "lblBall";
            lblBall.Size = new Size(39, 15);
            lblBall.TabIndex = 9;
            lblBall.Text = "label2";
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(61, 81);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(38, 23);
            tbNum2.TabIndex = 14;
            // 
            // tbNum3
            // 
            tbNum3.Location = new Point(105, 81);
            tbNum3.Name = "tbNum3";
            tbNum3.Size = new Size(38, 23);
            tbNum3.TabIndex = 15;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(367, 59);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(41, 15);
            lblTest.TabIndex = 16;
            lblTest.Text = "lblTest";
            // 
            // lbxHistory
            // 
            lbxHistory.FormattingEnabled = true;
            lbxHistory.ItemHeight = 15;
            lbxHistory.Location = new Point(275, 235);
            lbxHistory.Name = "lbxHistory";
            lbxHistory.Size = new Size(59, 184);
            lbxHistory.TabIndex = 17;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(309, 181);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(43, 15);
            lblHistory.TabIndex = 18;
            lblHistory.Text = "history";
            // 
            // lbxSB
            // 
            lbxSB.FormattingEnabled = true;
            lbxSB.ItemHeight = 15;
            lbxSB.Location = new Point(350, 235);
            lbxSB.Name = "lbxSB";
            lbxSB.Size = new Size(79, 184);
            lbxSB.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 207);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 20;
            label1.Text = "입력숫자";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 207);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 21;
            label2.Text = "스트라이크/볼";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxSB);
            Controls.Add(lblHistory);
            Controls.Add(lbxHistory);
            Controls.Add(lblTest);
            Controls.Add(tbNum3);
            Controls.Add(tbNum2);
            Controls.Add(lblBall);
            Controls.Add(lblStrike);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnInput);
            Controls.Add(tbNum1);
            Controls.Add(lblBool);
            Controls.Add(btnGeneration);
            Name = "Form1";
            Text = "5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneration;
        private Label lblBool;
        private TextBox tbNum1;
        private Button btnInput;
        private Label lbl1;
        private Label lbl2;
        private Label lblStrike;
        private Label lblBall;
        private TextBox tbNum2;
        private TextBox tbNum3;
        private Label lblTest;
        private ListBox lbxHistory;
        private Label lblHistory;
        private ListBox lbxSB;
        private Label label1;
        private Label label2;
    }
}
