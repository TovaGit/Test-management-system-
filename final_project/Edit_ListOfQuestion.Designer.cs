namespace final_project
{
    partial class Edit_ListOfQuestion
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
            next_btn = new Button();
            prev_btn = new Button();
            option1 = new Label();
            option4_tx = new TextBox();
            option2_tx = new TextBox();
            option2 = new Label();
            option3_tx = new TextBox();
            option3 = new Label();
            option1_tx = new TextBox();
            option4 = new Label();
            answer2 = new Label();
            answer2tx = new TextBox();
            deleteQ = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(669, 386);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 56;
            label1.Text = ":סך הנקודות למבחן זה";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.RosyBrown;
            progressBar1.Cursor = Cursors.Hand;
            progressBar1.ForeColor = Color.Black;
            progressBar1.Location = new Point(44, 381);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(625, 31);
            progressBar1.Step = 0;
            progressBar1.TabIndex = 55;
            // 
            // saveQ
            // 
            saveQ.Location = new Point(58, 263);
            saveQ.Margin = new Padding(3, 2, 3, 2);
            saveQ.Name = "saveQ";
            saveQ.Size = new Size(93, 22);
            saveQ.TabIndex = 51;
            saveQ.Text = "שמירת שאלה";
            saveQ.UseVisualStyleBackColor = true;
            saveQ.Click += saveQ_Click;
            // 
            // finishT
            // 
            finishT.Location = new Point(58, 289);
            finishT.Margin = new Padding(3, 2, 3, 2);
            finishT.Name = "finishT";
            finishT.Size = new Size(93, 22);
            finishT.TabIndex = 50;
            finishT.Text = "סיים עריכה  ";
            finishT.UseVisualStyleBackColor = true;
            finishT.Click += finishT_Click;
            // 
            // answer_l
            // 
            answer_l.AutoSize = true;
            answer_l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answer_l.Location = new Point(419, 151);
            answer_l.Name = "answer_l";
            answer_l.Size = new Size(70, 21);
            answer_l.TabIndex = 49;
            answer_l.Text = "התשובה";
            // 
            // Score
            // 
            Score.Location = new Point(273, 190);
            Score.Margin = new Padding(3, 2, 3, 2);
            Score.Name = "Score";
            Score.Size = new Size(130, 23);
            Score.TabIndex = 48;
            Score.TextChanged += Score_TextChanged;
            // 
            // score_l
            // 
            score_l.AutoSize = true;
            score_l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            score_l.Location = new Point(427, 187);
            score_l.Name = "score_l";
            score_l.Size = new Size(43, 21);
            score_l.TabIndex = 47;
            score_l.Text = "ניקוד";
            // 
            // answerQ
            // 
            answerQ.Location = new Point(273, 154);
            answerQ.Margin = new Padding(3, 2, 3, 2);
            answerQ.Name = "answerQ";
            answerQ.Size = new Size(130, 23);
            answerQ.TabIndex = 46;
            // 
            // typeQ_l
            // 
            typeQ_l.AutoSize = true;
            typeQ_l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            typeQ_l.Location = new Point(411, 69);
            typeQ_l.Name = "typeQ_l";
            typeQ_l.Size = new Size(79, 21);
            typeQ_l.TabIndex = 45;
            typeQ_l.Text = "סוג שאלה";
            // 
            // typeQ
            // 
            typeQ.AllowDrop = true;
            typeQ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            typeQ.BackColor = SystemColors.Menu;
            typeQ.FormattingEnabled = true;
            typeQ.Items.AddRange(new object[] { "כן/לא", "אמריקאי", "בחירה מרובה" });
            typeQ.Location = new Point(273, 72);
            typeQ.Margin = new Padding(3, 2, 3, 2);
            typeQ.Name = "typeQ";
            typeQ.Size = new Size(130, 58);
            typeQ.TabIndex = 44;
            typeQ.ItemCheck += typeQ_ItemCheck_1;
            // 
            // enterQ_l
            // 
            enterQ_l.AutoSize = true;
            enterQ_l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enterQ_l.Location = new Point(407, 38);
            enterQ_l.Name = "enterQ_l";
            enterQ_l.Size = new Size(94, 21);
            enterQ_l.TabIndex = 43;
            enterQ_l.Text = "הכנס שאלה";
            // 
            // enterQ
            // 
            enterQ.Location = new Point(273, 39);
            enterQ.Margin = new Padding(3, 2, 3, 2);
            enterQ.Name = "enterQ";
            enterQ.Size = new Size(130, 23);
            enterQ.TabIndex = 42;
            // 
            // next_btn
            // 
            next_btn.Location = new Point(675, 289);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(75, 23);
            next_btn.TabIndex = 57;
            next_btn.Text = "קדימה";
            next_btn.UseVisualStyleBackColor = true;
            next_btn.Click += next_btn_Click_1;
            // 
            // prev_btn
            // 
            prev_btn.Location = new Point(594, 289);
            prev_btn.Name = "prev_btn";
            prev_btn.Size = new Size(75, 23);
            prev_btn.TabIndex = 58;
            prev_btn.Text = "אחורה";
            prev_btn.UseVisualStyleBackColor = true;
            prev_btn.Click += prev_btn_Click;
            // 
            // option1
            // 
            option1.AutoSize = true;
            option1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option1.Location = new Point(417, 234);
            option1.Name = "option1";
            option1.Size = new Size(67, 21);
            option1.TabIndex = 59;
            option1.Text = "אופציה1";
            option1.Visible = false;
            // 
            // option4_tx
            // 
            option4_tx.Location = new Point(273, 323);
            option4_tx.Name = "option4_tx";
            option4_tx.Size = new Size(130, 23);
            option4_tx.TabIndex = 60;
            option4_tx.Visible = false;
            // 
            // option2_tx
            // 
            option2_tx.Location = new Point(273, 264);
            option2_tx.Name = "option2_tx";
            option2_tx.Size = new Size(130, 23);
            option2_tx.TabIndex = 62;
            option2_tx.Visible = false;
            // 
            // option2
            // 
            option2.AutoSize = true;
            option2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option2.Location = new Point(417, 264);
            option2.Name = "option2";
            option2.Size = new Size(67, 21);
            option2.TabIndex = 61;
            option2.Text = "אופציה2";
            option2.Visible = false;
            // 
            // option3_tx
            // 
            option3_tx.Location = new Point(273, 294);
            option3_tx.Name = "option3_tx";
            option3_tx.Size = new Size(130, 23);
            option3_tx.TabIndex = 64;
            option3_tx.Visible = false;
            // 
            // option3
            // 
            option3.AutoSize = true;
            option3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option3.Location = new Point(419, 294);
            option3.Name = "option3";
            option3.Size = new Size(67, 21);
            option3.TabIndex = 63;
            option3.Text = "אופציה3";
            option3.Visible = false;
            // 
            // option1_tx
            // 
            option1_tx.Location = new Point(273, 234);
            option1_tx.Name = "option1_tx";
            option1_tx.Size = new Size(130, 23);
            option1_tx.TabIndex = 66;
            option1_tx.Visible = false;
            // 
            // option4
            // 
            option4.AutoSize = true;
            option4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            option4.Location = new Point(417, 323);
            option4.Name = "option4";
            option4.Size = new Size(67, 21);
            option4.TabIndex = 65;
            option4.Text = "אופציה4";
            option4.Visible = false;
            // 
            // answer2
            // 
            answer2.AutoSize = true;
            answer2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answer2.Location = new Point(188, 156);
            answer2.Name = "answer2";
            answer2.Size = new Size(79, 21);
            answer2.TabIndex = 68;
            answer2.Text = "התשובה2";
            answer2.Visible = false;
            // 
            // answer2tx
            // 
            answer2tx.Location = new Point(58, 154);
            answer2tx.Margin = new Padding(3, 2, 3, 2);
            answer2tx.Name = "answer2tx";
            answer2tx.Size = new Size(130, 23);
            answer2tx.TabIndex = 67;
            answer2tx.Visible = false;
            // 
            // deleteQ
            // 
            deleteQ.Location = new Point(58, 316);
            deleteQ.Name = "deleteQ";
            deleteQ.Size = new Size(93, 23);
            deleteQ.TabIndex = 69;
            deleteQ.Text = "מחיקת שאלה";
            deleteQ.UseVisualStyleBackColor = true;
            deleteQ.Click += deleteQ_Click;
            // 
            // Edit_ListOfQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteQ);
            Controls.Add(answer2);
            Controls.Add(answer2tx);
            Controls.Add(option1_tx);
            Controls.Add(option4);
            Controls.Add(option3_tx);
            Controls.Add(option3);
            Controls.Add(option2_tx);
            Controls.Add(option2);
            Controls.Add(option4_tx);
            Controls.Add(option1);
            Controls.Add(prev_btn);
            Controls.Add(next_btn);
            Controls.Add(label1);
            Controls.Add(progressBar1);
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
            Name = "Edit_ListOfQuestion";
            Text = "Edit_ListOfQuestion";
            Load += Edit_ListOfQuestion_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
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
        private Button next_btn;
        private Button prev_btn;
        private Label option1;
        private TextBox option4_tx;
        private TextBox option2_tx;
        private Label option2;
        private TextBox option3_tx;
        private Label option3;
        private TextBox option1_tx;
        private Label option4;
        private Label answer2;
        private TextBox answer2tx;
        private Button deleteQ;
    }
}