using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace final_project
{
    public partial class Students : Form
    {
        static string senderName = "";
        bool fromWhere;
        public Students(string testName, bool fromWhere)
        {
            this.fromWhere = fromWhere;
            senderName = testName;
            InitializeComponent();
        }
        List<Question> existDataQuestion;
        GetFromJson e1 = new GetFromJson();
        List<Question> existDataQuestionList;
        //List<Dictionary<bool, int>>[] answers;

        static int[] answer1;
        static int[] answer2;
        int amountOfAnswer = 0;
        int amountOfQuestion = 0;
        int index;
        int countEmptyAnswers = 0;

        private void Students_Load_1(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            existDataQuestion = e1.GetFromQuestionJson();

            existDataQuestionList = (from i in existDataQuestion
                                     where i.id == senderName
                                     select i).ToList();

            //existDataQuestionList = existDataQuestion.FindAll(t => t.id == senderName);
            progressBar1.Maximum = existDataQuestionList.Count;
            index = 0;
            if (fromWhere)
            {
                answer1 = new int[existDataQuestionList.Count];
                answer2 = new int[existDataQuestionList.Count];
            }


            //answers = new List<Dictionary<bool, int>>[existDataQuestionList.Count() - 1];
            Inserting_Content();
        }

        void Inserting_Content()
        {
            if (index == existDataQuestionList.Count - 1)
            { finishT.Visible = true; }
            nameTest.Text = existDataQuestionList[index].id;
            nameTest.AutoSize = true;
            scoreL.Text = Convert.ToString(existDataQuestionList[index].score);
            typeQ.Text = existDataQuestionList[index].type;
            typeQ.AutoSize = true;
            QuestionL.Text = existDataQuestionList[index].question;
            QuestionL.AutoSize = true;
            if ((answer1[index]) != 0) answerQ.Text = Convert.ToString(answer1[index]);
            else answerQ.Text = "";
            if ((answer2[index]) != 0) answer2Q.Text = Convert.ToString(answer2[index]);
            else answer2Q.Text = "";

            switch (existDataQuestionList[index].type)
            {
                case "בחירה מרובה":
                    {
                        answer2Q.Visible = true;
                        label2.Visible = true;
                        opt3.Visible = true;
                        option3.Visible = true;
                        opt4.Visible = true;
                        option4.Visible = true;
                        opt1.Text = existDataQuestionList[index].questionOption[0];
                        opt2.Text = existDataQuestionList[index].questionOption[1];
                        opt3.Text = existDataQuestionList[index].questionOption[2];
                        opt4.Text = existDataQuestionList[index].questionOption[3];

                    }
                    break;
                case "כן/לא":
                    {
                        answer2Q.Visible = false;
                        label2.Visible = false;
                        opt3.Visible = false;
                        option3.Visible = false;
                        opt4.Visible = false;
                        option4.Visible = false;
                        opt1.Text = existDataQuestionList[index].questionOption[0];
                        opt2.Text = existDataQuestionList[index].questionOption[1];
                    }
                    break;
                case "אמריקאי":
                    {
                        answer2Q.Visible = false;
                        label2.Visible = false;
                        opt3.Visible = true;
                        option3.Visible = true;
                        opt4.Visible = true;
                        option4.Visible = true;
                        opt1.Text = existDataQuestionList[index]?.questionOption[0];
                        opt2.Text = existDataQuestionList[index]?.questionOption[1];
                        opt3.Text = existDataQuestionList[index]?.questionOption[2];
                        opt4.Text = existDataQuestionList[index]?.questionOption[3];
                    }
                    break;
            }


        }
        private void TestName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void next_btn_Click_1(object sender, EventArgs e)
        {
            if (index + 1 <= existDataQuestionList.Count - 1)
            {
                index++;
                finishT.Visible = false;
                Inserting_Content();
            }
            if (index == existDataQuestionList.Count - 1)
            { finishT.Visible = true; }


        }

        private void prev_btn_Click_1(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                index--;
                finishT.Visible = false;
                Inserting_Content();

            }
        }

        private void typeQ_Click(object sender, EventArgs e)
        {

        }

        private void answerQ_TextChanged_1(object sender, EventArgs e)
        {

            if (((TextBox)sender).Text != "")
            {
                try
                {
                    answer1[index] = Int32.Parse(((TextBox)sender).Text);
                    progressBar1.Value += 1;
                }
                catch
                {
                    MessageBox.Show(" לא ניתן להגיש תשובה, נא הקלד רק מספרים");
                    //progressBar1.Value = 1;
                }

                if (answer1[index] == 0 && progressBar1.Value - 1 > 0)
                    progressBar1.Value -= 1;
            }
            else if (progressBar1.Value - 1 >= 0)
                if (answer1[index] != 0)
                    progressBar1.Value -= 1;
            progressBar1.PerformStep();



        }

        private void finishT_Click_1(object sender, EventArgs e)
        {
            int t = 0;
            foreach (int i in answer1)
            { if (i == 0) t++; if (i == 0) countEmptyAnswers++; }

            if (t > 0)
            {
                this.Hide();
                CheckFinish t1 = new CheckFinish(senderName, existDataQuestionList, answer1, answer2, countEmptyAnswers);
                t1.Closed += (s, args) => this.Close();
                t1.Show();
            }
            else
            {
                this.Hide();
                MarkForm t2 = new MarkForm(existDataQuestionList, answer1, answer2);
                t2.Closed += (s, args) => this.Close();
                t2.Show();
            }

        }

        private void answer2Q_TextChanged_1(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
                answer2[index] = Int32.Parse(((TextBox)sender).Text);


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void finishT_Click(object sender, EventArgs e)
        {

        }

     
    }
}

