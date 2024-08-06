namespace final_project
{
    partial class NewTestForm
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
            addQ = new Button();
            saveQ = new Button();
            finishT = new Button();
            answer_l = new Label();
            Score = new TextBox();
            score_l = new Label();
            answerQ = new TextBox();
            typeQ_l = new Label();
            typeQ = new CheckedListBox();
            enterQ_l = new Label();
            enterQ = new TextBox();
            TestName = new Label();
            TestName_t = new TextBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // addQ
            // 
            addQ.Location = new Point(60, 261);
            addQ.Margin = new Padding(3, 2, 3, 2);
            addQ.Name = "addQ";
            addQ.Size = new Size(93, 22);
            addQ.TabIndex = 37;
            addQ.Text = "שאלה חדשה";
            addQ.UseVisualStyleBackColor = true;
            addQ.Click += addQ_Click;
            // 
            // saveQ
            // 
            saveQ.Location = new Point(60, 234);
            saveQ.Margin = new Padding(3, 2, 3, 2);
            saveQ.Name = "saveQ";
            saveQ.Size = new Size(93, 22);
            saveQ.TabIndex = 36;
            saveQ.Text = "שמירת שאלה";
            saveQ.UseVisualStyleBackColor = true;
            saveQ.Click += saveQ_Click;
            // 
            // finishT
            // 
            finishT.Location = new Point(60, 287);
            finishT.Margin = new Padding(3, 2, 3, 2);
            finishT.Name = "finishT";
            finishT.Size = new Size(93, 22);
            finishT.TabIndex = 35;
            finishT.Text = "סיים מבחן";
            finishT.UseVisualStyleBackColor = true;
            finishT.Click += finishT_Click;
            // 
            // answer_l
            // 
            answer_l.AutoSize = true;
            answer_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            answer_l.Location = new Point(439, 135);
            answer_l.Name = "answer_l";
            answer_l.Size = new Size(83, 25);
            answer_l.TabIndex = 34;
            answer_l.Text = "התשובה";
            // 
            // Score
            // 
            Score.Location = new Point(303, 171);
            Score.Margin = new Padding(3, 2, 3, 2);
            Score.Name = "Score";
            Score.Size = new Size(130, 23);
            Score.TabIndex = 33;
            Score.TextChanged += Score_TextChanged;
            // 
            // score_l
            // 
            score_l.AutoSize = true;
            score_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            score_l.Location = new Point(441, 169);
            score_l.Name = "score_l";
            score_l.Size = new Size(52, 25);
            score_l.TabIndex = 32;
            score_l.Text = "ניקוד";
            // 
            // answerQ
            // 
            answerQ.Location = new Point(303, 135);
            answerQ.Margin = new Padding(3, 2, 3, 2);
            answerQ.Name = "answerQ";
            answerQ.Size = new Size(130, 23);
            answerQ.TabIndex = 31;
            answerQ.TextChanged += answerQ_TextChanged;
            // 
            // typeQ_l
            // 
            typeQ_l.AutoSize = true;
            typeQ_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeQ_l.Location = new Point(439, 53);
            typeQ_l.Name = "typeQ_l";
            typeQ_l.Size = new Size(93, 25);
            typeQ_l.TabIndex = 30;
            typeQ_l.Text = "סוג שאלה";
            typeQ_l.Click += typeQ_l_Click;
            // 
            // typeQ
            // 
            typeQ.AllowDrop = true;
            typeQ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            typeQ.BackColor = SystemColors.Menu;
            typeQ.FormattingEnabled = true;
            typeQ.Items.AddRange(new object[] { "כן/לא", "אמריקאי", "בחירה מרובה" });
            typeQ.Location = new Point(303, 53);
            typeQ.Margin = new Padding(3, 2, 3, 2);
            typeQ.Name = "typeQ";
            typeQ.Size = new Size(130, 58);
            typeQ.TabIndex = 29;
            typeQ.ItemCheck += typeQ_ItemCheck;
            typeQ.SelectedIndexChanged += typeQ_SelectedIndexChanged;
            // 
            // enterQ_l
            // 
            enterQ_l.AutoSize = true;
            enterQ_l.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            enterQ_l.Location = new Point(437, 22);
            enterQ_l.Name = "enterQ_l";
            enterQ_l.Size = new Size(111, 25);
            enterQ_l.TabIndex = 28;
            enterQ_l.Text = "הכנס שאלה";
            enterQ_l.Click += enterQ_l_Click;
            // 
            // enterQ
            // 
            enterQ.Location = new Point(303, 20);
            enterQ.Margin = new Padding(3, 2, 3, 2);
            enterQ.Name = "enterQ";
            enterQ.Size = new Size(130, 23);
            enterQ.TabIndex = 27;
            enterQ.TextChanged += enterQ_TextChanged;
            // 
            // TestName
            // 
            TestName.AutoSize = true;
            TestName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TestName.Location = new Point(706, 22);
            TestName.Name = "TestName";
            TestName.Size = new Size(103, 25);
            TestName.TabIndex = 38;
            TestName.Text = "שם המבחן";
            // 
            // TestName_t
            // 
            TestName_t.Location = new Point(588, 27);
            TestName_t.Margin = new Padding(3, 2, 3, 2);
            TestName_t.Name = "TestName_t";
            TestName_t.Size = new Size(112, 23);
            TestName_t.TabIndex = 39;
            TestName_t.TextChanged += TestName_t_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.RosyBrown;
            progressBar1.ForeColor = Color.RosyBrown;
            progressBar1.Location = new Point(41, 385);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(612, 31);
            progressBar1.Step = 0;
            progressBar1.TabIndex = 40;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(659, 385);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 41;
            label1.Text = ":סך הנקודות למבחן זה";
            label1.Click += label1_Click;
            // 
            // NewTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(836, 433);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(TestName_t);
            Controls.Add(TestName);
            Controls.Add(addQ);
            Controls.Add(saveQ);
            Controls.Add(finishT);
            Controls.Add(answer_l);
            Controls.Add(Score);
            Controls.Add(score_l);
            Controls.Add(answerQ);
            Controls.Add(typeQ_l);
            Controls.Add(typeQ);
            Controls.Add(enterQ_l);
            Controls.Add(enterQ);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewTestForm";
            Text = "NewTestForm";
            Load += NewTestForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addQ;
        private Button saveQ;
        private Button finishT;
        private Label answer_l;
        private TextBox Score;
        private Label score_l;
        private TextBox answerQ;
        private Label typeQ_l;
        private CheckedListBox typeQ;
        private Label enterQ_l;
        private TextBox enterQ;
        private Label TestName;
        private TextBox TestName_t;
        private ProgressBar progressBar1;
        private Label label1;
    }
}