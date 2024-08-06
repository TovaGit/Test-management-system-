
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace final_project
{
    public partial class NewTestForm : Form
    {
        GetFromJson j = new GetFromJson();
        List<Label> Newlabels = new List<Label> { };
        List<TextBox> OptionToAnswerArr = new List<TextBox> { };
        Question question;
        Test test;
        Test tmp;
        public NewTestForm()
        {
            test = new Test();
            test.allScore = 0;
            test.status = false;
            question = new Question();
            question.questionOption = new List<string>();
            question.id = "";
            InitializeComponent();
        }
        private void typeQ_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void OptionsOfAnswer()
        {

            int y = Score.Location.Y + 48;
            for (int i = 1; i <= 4; i++)
            {
                Label q1 = new Label();
                Newlabels.Add(q1);
                q1.Location = new Point(score_l.Location.X + 10, y);
                q1.Text = i + " אופציה";
                q1.Font = new Font("Segoe UI", 14);

                TextBox ans = new TextBox();
                ans.Location = new Point(Score.Location.X, y);
                ans.Size = new Size(148, 27);
                this.Controls.Add(ans);
                this.Controls.Add(q1);
                ans.Name = "answer" + i;
                OptionToAnswerArr.Add(ans);
                y += 48;

            }
        }
        private void enterQ_TextChanged(object sender, EventArgs e)
        {
            // question.question = ((TextBox)sender).Text;
        }
        private void answerQ_TextChanged(object sender, EventArgs e)
        {
            // question.answer = ((TextBox)sender).Text;
        }
        private void saveQ_Click(object sender, EventArgs e)
        {

            TextBox answerQ = (TextBox)Controls["answerQ"];
            TextBox enterQ = (TextBox)Controls["enterQ"];
            TextBox score = (TextBox)Controls["Score"];
            TextBox testName = (TextBox)Controls["TestName_t"];
            TextBox answerQ1 = (TextBox)Controls["ans1"];
            if (answerQ.Text != "" && enterQ.Text != "" && score.Text != "" && testName.Text != "")
            {
                int t1 = 0;
                foreach (TextBox t in OptionToAnswerArr)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("msg1: נא מלא את כל השדות לפני השמירה");
                        t1 = 1;
                        return;
                    }
                    question.questionOption?.Add(t.Text);
                }
                OptionToAnswerArr.Clear();
                if (t1 == 0)
                {
                    question.answer = Int32.Parse((answerQ.Text));
                    question.question = enterQ.Text;
                    question.score = Int32.Parse(score.Text);
                    question.id = testName.Text;
                    if (answerQ1 != null)
                        question.secondAnswer = Int32.Parse((answerQ1.Text));
                    List<Question> existingData;
                    existingData = j.GetFromQuestionJson();
                    if (existingData == null)
                    { existingData = new List<Question>(); }

                    List<Test> existDataTest;
                    existDataTest = j.GetFromTestJson();

                    if (existDataTest == null)
                    {
                        existDataTest = new List<Test>();
                        test.allScore = question.score;
                        if (question.score < 100)
                            test.status = false;
                        else if (question.score == 100)
                            test.status = true;
                        existDataTest?.Add(test);
                        progressBar1.Value = test.allScore;
                        progressBar1.PerformStep();
                        existingData?.Add(question);
                        string updatedJson = JsonConvert.SerializeObject(existingData);
                        File.WriteAllText("question.json", updatedJson);

                    }
                    else
                    {
                        tmp = existDataTest.Find(t => t.testName == question.id);
                        if (tmp == null)
                        {
                            test.allScore = question.score;
                            test.testName = question.id;
                            if (question.score < 100)
                                test.status = false;
                            else if (question.score == 100)
                                test.status = true;
                            existDataTest?.Add(test);
                            progressBar1.Value = test.allScore;
                            progressBar1.PerformStep();
                            existingData?.Add(question);
                            string updatedJson = JsonConvert.SerializeObject(existingData);
                            File.WriteAllText("question.json", updatedJson);
                        }
                        else
                        {

                            if (tmp.allScore + question.score > 100)
                            {
                                MessageBox.Show(" לא ניתן להוסיף שאלה זו לבמבחן הזה הניקוד עולה על 100 אחוז");
                            }

                            else
                            {
                                tmp.allScore += question.score;
                                if (tmp.allScore == 100)
                                {
                                    tmp.status = true;
                                }

                                existDataTest?.Remove(tmp);
                                existingData?.Add(question);
                                string updatedJson = JsonConvert.SerializeObject(existingData);
                                File.WriteAllText("question.json", updatedJson);
                                existDataTest?.Add(tmp);
                                progressBar1.Value = tmp.allScore;
                                progressBar1.PerformStep();
                            }
                        }
                    }

                    string updatedJsonTest = JsonConvert.SerializeObject(existDataTest);
                    File.WriteAllText("tests.json", updatedJsonTest);
                }
            }
            else
            {
                MessageBox.Show("msg2: נא מלא את כל השדות לפני השמירה");
            }
        }
        private void NewTestForm_Load(object sender, EventArgs e)
        {

        }
        private void finishT_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                if (tmp.status == false)
                    MessageBox.Show("סך הנקודות למבחן ב" + test.testName + " עדין לא 100 אחוז המבחן ישמר כטיוטה");
                else
                    MessageBox.Show("המבחן ב" + test.testName + " " + "נשמר בהצלחה");
            }
            else
            {
                if (test.status == false)
                    MessageBox.Show("סך הנקודות למבחן ב" + test.testName + " עדין לא 100 אחוז המבחן ישמר כטיוטה");
                else
                    MessageBox.Show("המבחן ב" + test.testName + " " + "נשמר בהצלחה");
            }

            this.Hide();
            TeachersForm t1 = new TeachersForm();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }
        private void addQ_Click(object sender, EventArgs e)
        {
            question.questionOption?.Clear();
            this.Hide();
            NewTestForm t1 = new NewTestForm();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }
        private void deleteNewAdded()
        {
            foreach (TextBox textBox in OptionToAnswerArr)
            {
                this.Controls.Remove(textBox);
                textBox.Dispose();
            }
            OptionToAnswerArr.Clear();
            foreach (Label l in Newlabels)
            {
                this.Controls.Remove(l);
                l.Dispose();
            }
            Newlabels.Clear();
            Controls.RemoveByKey("ans1");
        }
        private void typeQ_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (((CheckedListBox)sender).Items[((CheckedListBox)sender).SelectedIndex].ToString())
            {
                case "כן/לא":

                    int y = Score.Location.Y + 48;
                    deleteNewAdded();
                    for (int i = 1; i <= 2; i++)
                    {
                        Label l1 = new Label();
                        l1.Location = new Point(score_l.Location.X + 10, y);
                        l1.Text = i + " אופציה";
                        l1.Font = new Font("Segoe UI", 14);

                        TextBox answer1 = new TextBox();
                        answer1.Size = new Size(148, 27);
                        answer1.Location = new Point(Score.Location.X, y);
                        answer1.Name = "answer" + i;
                        OptionToAnswerArr.Add(answer1);
                        Newlabels.Add(l1);
                        this.Controls.Add(answer1);
                        this.Controls.Add(l1);
                        y += 48;
                        question.type = "כן/לא";
                    }

                    break;
                case "אמריקאי":
                    deleteNewAdded();
                    OptionsOfAnswer();
                    question.type = "אמריקאי";

                    break;
                case "בחירה מרובה":
                    deleteNewAdded();
                    Label q1 = new Label();
                    q1.Name = "optsionAnswer";
                    q1.Location = new Point(answerQ.Location.X - 100, answerQ.Location.Y);
                    q1.Text = "תשובה 2";
                    q1.AutoSize = true;
                    q1.Font = new Font("Segoe UI", 14);
                    TextBox ans1 = new TextBox();
                    ans1.Size = new Size(148, 27);

                    ans1.Location = new Point(answerQ.Location.X - 250, answerQ.Location.Y);
                    ans1.Name = "ans1";
                    Newlabels.Add(q1);
                    this.Controls.Add(ans1);
                    this.Controls.Add(q1);
                    OptionsOfAnswer();
                    question.type = "בחירה מרובה";
                    break;

            }
            for (int i = 0; i < typeQ.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    typeQ.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        private void Score_TextChanged(object sender, EventArgs e)
        {
        }
        private void TestName_t_TextChanged(object sender, EventArgs e)
        {
            test.testName = ((TextBox)sender).Text;
        }

        private void enterQ_l_Click(object sender, EventArgs e)
        {

        }

        private void typeQ_l_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewTestForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

