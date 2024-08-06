using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;


namespace final_project
{
    public partial class MarkForm : Form
    {
        List<Question> existDataQuestionList;
        int[] answer1;
        int[] answer2;
        int testMark = 0;
        int tmp = 0;
        public MarkForm(List<Question> existDataQuestionList, int[] answer1, int[] answer2)
        {
            this.existDataQuestionList = existDataQuestionList;
            this.answer1 = answer1;
            this.answer2 = answer2;
            InitializeComponent();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {


            foreach (var i in existDataQuestionList)
            {

                if (i.type == "בחירה מרובה")
                {
                    if (i.answer == answer1[tmp] && i.secondAnswer == answer2[tmp] || i.answer == answer2[tmp] && i.secondAnswer == answer1[tmp])
                        testMark += i.score;
                }
                else
                {
                    if (i.answer == answer1[tmp])
                        testMark += i.score;
                }
                tmp++;
            }
          
            markl.Text = Convert.ToString(testMark);
            int x = mark.Location.X;
            int x1 = markl.Location.X - 20; ;
            int y = mark.Location.Y + 70;
            bool good0 = false;
            int t1;
            int t2;

            tmp = 0;
            foreach (var i in existDataQuestionList)
            {
                good0 = false;
                if (i.type == "בחירה מרובה")
                {
                    t1 = answer1[tmp];
                    t2 = answer2[tmp];
                    if (t1 > 4 || t2 > 4)
                    {
                        MessageBox.Show("תשובה לא תקינה");
                        break;
                    }
                    if (i.secondAnswer != t1 && i.answer != t1)
                    {
                        Label q = new Label();
                        Label q1 = new Label();
                        q.Location = new Point(x, y);
                        q1.Location = new Point(x1, y);
                        q.Text = ":השאלה";
                        q1.Text = i.question;

                        q.AutoSize = true;
                        this.Controls.Add(q);
                        this.Controls.Add(q1);
                        y += 20;
                        Label good2 = new Label();
                        good2.AutoSize = true;
                        good2.Location = new Point(x, y);
                        good2.Text = ":התשובה הנכונה";
                        Label good3 = new Label();
                        good3.AutoSize = true;
                        good3.Location = new Point(x1, y);
                        if (i.secondAnswer != t1)
                            good3.Text = i.questionOption[Convert.ToInt32(i.answer) - 1];
                        else
                            good3.Text = i.questionOption[Convert.ToInt32(i.secondAnswer) - 1];

                        y += 20;
                        Label worng4 = new Label();
                        worng4.AutoSize = true;
                        worng4.Location = new Point(x, y);
                        worng4.Text = ":תשובתך";
                        Label w = new Label();
                        w.AutoSize = true;
                        w.Location = new Point(x1, y);
                        if (t1 == 0) { w.Text = "לא ענית תשובה"; }
                        try { w.Text = i.questionOption[t1 - 1]; }
                        catch { w.Text = "0"; }
                        this.Controls.Add(good2);
                        this.Controls.Add(worng4);
                        this.Controls.Add(good3);
                        this.Controls.Add(w);
                        y += 20;
                        good0 = true;

                    }
                    if (i.secondAnswer != t2 && i.answer != t2)
                    {
                        if (!good0)
                        {
                            Label q = new Label();
                            Label q1 = new Label();
                            q.Location = new Point(x, y);
                            q1.Location = new Point(x1, y);
                            q.Text = ":השאלה";
                            q1.Text = i.question;
                            q.AutoSize = true;
                            this.Controls.Add(q);
                            this.Controls.Add(q1);


                        }
                        y += 20;
                        Label good2 = new Label();
                        good2.AutoSize = true;
                        good2.Location = new Point(x, y);
                        good2.Text = ":התשובה הנכונה";
                        Label good4 = new Label();
                        good4.AutoSize = true;
                        good4.Location = new Point(x1, y);
                        if (i.secondAnswer != t2)
                            good4.Text = i.questionOption[Convert.ToInt32(i.secondAnswer) - 1];
                        else
                            good4.Text = i.questionOption[Convert.ToInt32(i.answer) - 1];

                        y += 20;
                        Label worng4 = new Label();
                        worng4.AutoSize = true;
                        worng4.Location = new Point(x, y);
                        worng4.Text = ":תשובתך";
                        Label w = new Label();
                        w.AutoSize = true;
                        w.Location = new Point(x1, y);
                        if (t2 == 0) { w.Text = "לא ענית תשובה"; }
                        try { w.Text = i.questionOption[t2 - 1]; }
                        catch { w.Text = "0"; }

                        this.Controls.Add(good2);
                        this.Controls.Add(worng4);
                        this.Controls.Add(good4);
                        this.Controls.Add(w);
                        y += 20;


                    }
                }
                else if (i.answer != answer1[tmp])
                {

                    Label q = new Label();
                    Label good = new Label();
                    Label worng = new Label();
                    Label q1 = new Label();
                    Label good1 = new Label();
                    Label worng1 = new Label();
                    q.Location = new Point(x, y);
                    q1.Location = new Point(x1, y);
                    y += 20;
                    good.Location = new Point(x, y);
                    good1.Location = new Point(x1, y);
                    y += 20;
                    worng.Location = new Point(x, y);
                    worng1.Location = new Point(x1, y);
                    y += 30;
                    q.AutoSize = true;
                    q1.AutoSize = true;
                    good.AutoSize = true;
                    good1.AutoSize = true;
                    worng.AutoSize = true;
                    worng1.AutoSize = true;

                    q.Text = ":השאלה";
                    q1.Text = i.question;
                    good.Text = ":התשובה הנכונה";
                    good1.Text = i.questionOption[Convert.ToInt32(i.answer) - 1];
                    worng.Text = ":תשובתך";
                    try { worng1.Text = i.questionOption[answer1[tmp] - 1]; }
                    catch { worng1.Text = "0"; }


                    this.Controls.Add(q);
                    this.Controls.Add(q1);
                    this.Controls.Add(good);
                    this.Controls.Add(good1);
                    this.Controls.Add(worng);
                    this.Controls.Add(worng1);


                }
                if (tmp + 1 != existDataQuestionList.Count)
                    tmp++;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestListForStudent t1 = new TestListForStudent();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            End t2 = new End();
            t2.Closed += (s, args) => this.Close();
            t2.Show();
        }
    }
}

