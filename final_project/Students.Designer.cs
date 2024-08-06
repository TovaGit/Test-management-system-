namespace final_project
{
    partial class Students
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
            progressBar1 = new ProgressBar();
            TestName = new Label();
            finishT = new Button();
            answer_l = new Label();
            score_l = new Label();
            answerQ = new TextBox();
            typeQ_l = new Label();
            enterQ_l = new Label();
            label2 = new Label();
            answer2Q = new TextBox();
            option4 = new Label();
            option3 = new Label();
            option2 = new Label();
            option1 = new Label();
            prev_btn = new Button();
            next_btn = new Button();
            opt1 = new Label();
            opt2 = new Label();
            opt4 = new Label();
            opt3 = new Label();
            nameTest = new Label();
            typeQ = new Label();
            scoreL = new Label();
            QuestionL = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(625, 400);
            label1.Name = "label1";
            label1.Size = new Size(167, 17);
            label1.TabIndex = 56;
            label1.Text = ":סך השאלות שענית עד כה";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 390);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(586, 31);
            progressBar1.Step = 0;
            progressBar1.TabIndex = 55;
            // 
            // TestName
            // 
            TestName.AutoSize = true;
            TestName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TestName.Location = new Point(666, 26);
            TestName.Name = "TestName";
            TestName.Size = new Size(83, 25);
            TestName.TabIndex = 53;
            TestName.Text = ":מבחן  ב";
            // 
            // finishT
            // 
            finishT.Location = new Point(33, 341);
            finishT.Margin = new Padding(3, 2, 3, 2);
            finishT.Name = "finishT";
            finishT.Size = new Size(93, 22);
            finishT.TabIndex = 50;
            finishT.Text = "סיים מבחן";
            finishT.UseVisualStyleBackColor = true;
            finishT.Visible = false;
            finishT.Click += finishT_Click_1;
            // 
            // answer_l
            // 
            answer_l.AutoSize = true;
            answer_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            answer_l.Location = new Point(380, 296);
            answer_l.Name = "answer_l";
            answer_l.Size = new Size(85, 25);
            answer_l.TabIndex = 49;
            answer_l.Text = "התשובה";
            // 
            // score_l
            // 
            score_l.AutoSize = true;
            score_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            score_l.Location = new Point(689, 95);
            score_l.Name = "score_l";
            score_l.Size = new Size(60, 25);
            score_l.TabIndex = 47;
            score_l.Text = ":ניקוד";
            // 
            // answerQ
            // 
            answerQ.BackColor = SystemColors.InactiveBorder;
            answerQ.Location = new Point(350, 296);
            answerQ.Margin = new Padding(3, 2, 3, 2);
            answerQ.Name = "answerQ";
            answerQ.Size = new Size(24, 23);
            answerQ.TabIndex = 46;
            answerQ.TextChanged += answerQ_TextChanged_1;
            // 
            // typeQ_l
            // 
            typeQ_l.AutoSize = true;
            typeQ_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            typeQ_l.Location = new Point(634, 59);
            typeQ_l.Name = "typeQ_l";
            typeQ_l.Size = new Size(118, 25);
            typeQ_l.TabIndex = 45;
            typeQ_l.Text = ":סוג השאלה";
            // 
            // enterQ_l
            // 
            enterQ_l.AutoSize = true;
            enterQ_l.Location = new Point(437, 105);
            enterQ_l.Name = "enterQ_l";
            enterQ_l.Size = new Size(0, 15);
            enterQ_l.TabIndex = 43;
            enterQ_l.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(380, 335);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 58;
            label2.Text = "התשובה2";
            // 
            // answer2Q
            // 
            answer2Q.BackColor = SystemColors.InactiveBorder;
            answer2Q.Location = new Point(350, 340);
            answer2Q.Margin = new Padding(3, 2, 3, 2);
            answer2Q.Name = "answer2Q";
            answer2Q.Size = new Size(24, 23);
            answer2Q.TabIndex = 57;
            answer2Q.TextChanged += answer2Q_TextChanged_1;
            // 
            // option4
            // 
            option4.AutoSize = true;
            option4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            option4.Location = new Point(406, 232);
            option4.Name = "option4";
            option4.Size = new Size(28, 25);
            option4.TabIndex = 75;
            option4.Text = ".4";
            // 
            // option3
            // 
            option3.AutoSize = true;
            option3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            option3.Location = new Point(406, 203);
            option3.Name = "option3";
            option3.Size = new Size(28, 25);
            option3.TabIndex = 73;
            option3.Text = ".3";
            // 
            // option2
            // 
            option2.AutoSize = true;
            option2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            option2.Location = new Point(406, 173);
            option2.Name = "option2";
            option2.Size = new Size(28, 25);
            option2.TabIndex = 71;
            option2.Text = ".2";
            // 
            // option1
            // 
            option1.AutoSize = true;
            option1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            option1.Location = new Point(406, 143);
            option1.Name = "option1";
            option1.Size = new Size(23, 21);
            option1.TabIndex = 69;
            option1.Text = ".1";
            // 
            // prev_btn
            // 
            prev_btn.Location = new Point(608, 340);
            prev_btn.Name = "prev_btn";
            prev_btn.Size = new Size(75, 23);
            prev_btn.TabIndex = 68;
            prev_btn.Text = "אחורה";
            prev_btn.UseVisualStyleBackColor = true;
            prev_btn.Click += prev_btn_Click_1;
            // 
            // next_btn
            // 
            next_btn.Location = new Point(689, 340);
            next_btn.Name = "next_btn";
            next_btn.RightToLeft = RightToLeft.Yes;
            next_btn.Size = new Size(75, 23);
            next_btn.TabIndex = 67;
            next_btn.Text = "קדימה";
            next_btn.UseVisualStyleBackColor = true;
            next_btn.Click += next_btn_Click_1;
            // 
            // opt1
            // 
            opt1.AutoSize = true;
            opt1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            opt1.Location = new Point(364, 143);
            opt1.Name = "opt1";
            opt1.RightToLeft = RightToLeft.Yes;
            opt1.Size = new Size(22, 25);
            opt1.TabIndex = 76;
            opt1.Text = "1";
            // 
            // opt2
            // 
            opt2.AutoSize = true;
            opt2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            opt2.Location = new Point(364, 173);
            opt2.Name = "opt2";
            opt2.RightToLeft = RightToLeft.Yes;
            opt2.Size = new Size(22, 25);
            opt2.TabIndex = 77;
            opt2.Text = "2";
            // 
            // opt4
            // 
            opt4.AutoSize = true;
            opt4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            opt4.Location = new Point(364, 232);
            opt4.Name = "opt4";
            opt4.RightToLeft = RightToLeft.Yes;
            opt4.Size = new Size(22, 25);
            opt4.TabIndex = 79;
            opt4.Text = "4";
            // 
            // opt3
            // 
            opt3.AutoSize = true;
            opt3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            opt3.Location = new Point(364, 203);
            opt3.Name = "opt3";
            opt3.RightToLeft = RightToLeft.Yes;
            opt3.Size = new Size(22, 25);
            opt3.TabIndex = 78;
            opt3.Text = "3";
            // 
            // nameTest
            // 
            nameTest.AutoSize = true;
            nameTest.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameTest.Location = new Point(579, 26);
            nameTest.Name = "nameTest";
            nameTest.RightToLeft = RightToLeft.Yes;
            nameTest.Size = new Size(70, 25);
            nameTest.TabIndex = 80;
            nameTest.Text = "מבחן ב";
            // 
            // typeQ
            // 
            typeQ.AutoSize = true;
            typeQ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeQ.Location = new Point(579, 59);
            typeQ.Name = "typeQ";
            typeQ.RightToLeft = RightToLeft.Yes;
            typeQ.Size = new Size(38, 25);
            typeQ.TabIndex = 81;
            typeQ.Text = "סוג";
            // 
            // scoreL
            // 
            scoreL.AutoSize = true;
            scoreL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            scoreL.Location = new Point(625, 95);
            scoreL.Name = "scoreL";
            scoreL.RightToLeft = RightToLeft.Yes;
            scoreL.Size = new Size(52, 25);
            scoreL.TabIndex = 82;
            scoreL.Text = "ניקוד";
            // 
            // QuestionL
            // 
            QuestionL.AutoSize = true;
            QuestionL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            QuestionL.Location = new Point(364, 105);
            QuestionL.Name = "QuestionL";
            QuestionL.RightToLeft = RightToLeft.Yes;
            QuestionL.Size = new Size(65, 25);
            QuestionL.TabIndex = 83;
            QuestionL.Text = "שאלה";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(789, 433);
            Controls.Add(QuestionL);
            Controls.Add(scoreL);
            Controls.Add(typeQ);
            Controls.Add(nameTest);
            Controls.Add(opt4);
            Controls.Add(opt3);
            Controls.Add(opt2);
            Controls.Add(opt1);
            Controls.Add(option4);
            Controls.Add(option3);
            Controls.Add(option2);
            Controls.Add(option1);
            Controls.Add(prev_btn);
            Controls.Add(next_btn);
            Controls.Add(label2);
            Controls.Add(answer2Q);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(TestName);
            Controls.Add(finishT);
            Controls.Add(answer_l);
            Controls.Add(score_l);
            Controls.Add(answerQ);
            Controls.Add(typeQ_l);
            Controls.Add(enterQ_l);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Students";
            Text = "Students";
            TransparencyKey = Color.White;
            Load += Students_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label TestName;
        private Button finishT;
        private Label answer_l;
        private Label score_l;
        private TextBox answerQ;
        private Label typeQ_l;
        private Label enterQ_l;
        private Label label2;
        private TextBox answer2Q;
        private Label option4;
        private Label option3;
        private Label option2;
        private Label option1;
        private Button prev_btn;
        private Button next_btn;
        private Label opt1;
        private Label opt2;
        private Label opt4;
        private Label opt3;
        private Label nameTest;
        private Label typeQ;
        private Label scoreL;
        private Label QuestionL;
    }
}