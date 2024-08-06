using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static final_project.EditTest;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace final_project
{
    public partial class Edit_ListOfQuestion : Form
    {

        string senderName = "";
        int index = 0;

        public Edit_ListOfQuestion(string sender)
        {
            senderName = sender;
            InitializeComponent();
        }
        List<Question> existDataQuestion;
        GetFromJson e1 = new GetFromJson();
        List<Question> existDataQuestionList;
        List<Test> GetTestList;
        Test CurrTest;
        Int32 currScore;
        private void Edit_ListOfQuestion_Load_1(object sender, EventArgs e)
        {
            index = 0;
            existDataQuestion = e1.GetFromQuestionJson();
            existDataQuestionList = existDataQuestion.FindAll(t => t.id == senderName);
            GetTestList = e1.GetFromTestJson();
            CurrTest = GetTestList.Find(t => t.testName == senderName);
            GetTestList.Remove(CurrTest);
            existDataQuestion.RemoveAll(t => t.id == senderName);
            Inserting_Content();
        }

        void Inserting_Content()
        {
            if (existDataQuestionList != null)
            {
                progressBar1.Value = 0;
                enterQ.Text = existDataQuestionList[index].question;
                Score.Text = Convert.ToString(existDataQuestionList[index].score);
                currScore = Int32.Parse(Controls["Score"].Text);
                progressBar1.Value = CurrTest.allScore;
                progressBar1.PerformStep();
                answerQ.Text = Convert.ToString(existDataQuestionList[index].answer);
                switch (existDataQuestionList[index].type)
                {
                    case "בחירה מרובה":
                        {
                            typeQ.SetItemCheckState(2, CheckState.Checked);
                            answer2tx.Visible = true;
                            answer2.Visible = true;
                            answer2tx.Text = Convert.ToString(existDataQuestionList[index].secondAnswer);
                            for (int i = 1; i < 5; i++)
                            {
                                Controls["option" + i + "_tx"].Visible = true;
                                Controls["option" + i].Visible = true;
                                Controls["option" + i + "_tx"].Text = existDataQuestionList[index].questionOption[i - 1];
                            }
                        }
                        break;
                    case "כן/לא":
                        {
                            answer2tx.Visible = false;
                            option3_tx.Visible = false;
                            option3.Visible = false;
                            option4_tx.Visible = false;
                            option4.Visible = false;
                            answer2.Visible = false;
                            typeQ.SetItemCheckState(0, CheckState.Checked);
                            for (int i = 1; i < 3; i++)
                            {
                                Controls["option" + i + "_tx"].Visible = true;
                                Controls["option" + i].Visible = true;
                                Controls["option" + i + "_tx"].Text = existDataQuestionList[index].questionOption[i - 1];
                            }
                        }
                        break;
                    case "אמריקאי":
                        {
                            answer2tx.Visible = false;
                            answer2.Visible = false;
                            typeQ.SetItemCheckState(1, CheckState.Checked);
                            for (int i = 1; i < 5; i++)
                            {
                                Controls["option" + i + "_tx"].Visible = true;
                                Controls["option" + i].Visible = true;
                                Controls["option" + i + "_tx"].Text = existDataQuestionList[index].questionOption[i - 1];
                            }
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("no tests exists");
            }
        }
        private void next_btn_Click_1(object sender, EventArgs e)
        {
            if (index + 1 <= existDataQuestionList.Count - 1)
            {
                index++;
                Inserting_Content();
            }
        }
        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                index--;
                Inserting_Content();
            }
        }
        private void enterQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveQ_Click(object sender, EventArgs e)
        {
            currScore = existDataQuestionList[index].score;
            CurrTest.allScore -= currScore;
            TextBox answerQ = (TextBox)Controls["answerQ"];
            TextBox enterQ = (TextBox)Controls["enterQ"];
            TextBox score = (TextBox)Controls["Score"];
            TextBox answerQ1 = (TextBox)Controls["answer2tx"];
            if (answerQ.Text != "" && enterQ.Text != "" && score.Text != "")
            {
                int t1 = 0, count = 0;

                if (existDataQuestionList[index].type == "כן/לא") count = 2; else count = 4;
                for (int i = 1; i <= count; i++)
                {
                    if (Controls["option" + i + "_tx"].Text == "")
                    {
                        MessageBox.Show("msg1: נא מלא את כל השדות לפני השמירה");
                        t1 = 1;
                        return;
                    }
                    existDataQuestionList[index].questionOption[i - 1] = (Controls["option" + i + "_tx"].Text);
                }

                if (t1 == 0)
                {

                    if (CurrTest.allScore + Int32.Parse(score.Text) > 100)
                    {
                        MessageBox.Show(" לא ניתן להוסיף שאלה זו לבמבחן הזה הניקוד עולה על 100 אחו");
                    }
                    else
                    {

                        if (CurrTest.allScore + Int32.Parse(score.Text) == 100)
                            CurrTest.status = true;
                        else
                            CurrTest.status = false;
                        existDataQuestionList[index].answer = Int32.Parse((answerQ.Text));
                        existDataQuestionList[index].question = enterQ.Text;
                        existDataQuestionList[index].score = Int32.Parse(score.Text);
                        CurrTest.allScore += Int32.Parse(Controls["Score"].Text);
                        progressBar1.Value = CurrTest.allScore;
                        progressBar1.PerformStep();

                        if (answerQ1.Visible && answerQ1.Text != "")
                            existDataQuestionList[index].secondAnswer = Int32.Parse((answerQ1.Text));
                    }
                }
                else MessageBox.Show("msg2: נא מלא את כל השדות לפני השמירה");

            }
        }
        private void finishT_Click(object sender, EventArgs e)
        {
            if (CurrTest.allScore == 100)
            {
                CurrTest.status = true;
            }
            foreach (var i in existDataQuestionList)
            {
                existDataQuestion.Add(i);
            }
            string updatedJsonQ = JsonConvert.SerializeObject(existDataQuestion);
            File.WriteAllText("question.json", updatedJsonQ);
            GetTestList.Add(CurrTest);
            string updatedJsonTest = JsonConvert.SerializeObject(GetTestList);
            File.WriteAllText("tests.json", updatedJsonTest);
            this.Hide();
            EditTest t1 = new EditTest();
            t1.Closed += (s, args) => this.Close();
            t1.Show();

        }


        private void typeQ_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {

            if (((CheckedListBox)sender).SelectedIndex.ToString() != "-1")
            {
                switch (((CheckedListBox)sender).Items[((CheckedListBox)sender).SelectedIndex].ToString())
                {
                    case "כן/לא":
                        answer2tx.Visible = false;
                        option3_tx.Visible = false;
                        option3.Visible = false;
                        option4_tx.Visible = false;
                        option4.Visible = false;
                        answer2.Visible = false;
                        if (existDataQuestionList[index].questionOption?.Count == 4)
                        {
                            existDataQuestionList[index].questionOption?.Remove(option3_tx.Text);
                            existDataQuestionList[index].questionOption?.Remove(option4_tx.Text);
                        }
                        existDataQuestionList[index].secondAnswer = null;
                        existDataQuestionList[index].type = "כן/לא";
                        break;
                    case "אמריקאי":
                        answer2tx.Visible = false;
                        answer2.Visible = false;
                        for (int i = 1; i < 5; i++)
                        {
                            Controls["option" + i + "_tx"].Visible = true;
                            Controls["option" + i].Visible = true;
                        }
                        if (existDataQuestionList[index].questionOption?.Count != 4)
                        {
                            existDataQuestionList[index].questionOption?.Add(option3_tx.Text);
                            existDataQuestionList[index].questionOption?.Add(option4_tx.Text);
                        }
                        existDataQuestionList[index].type = "אמריקאי";
                        existDataQuestionList[index].secondAnswer = null;
                        break;
                    case "בחירה מרובה":
                        answer2tx.Visible = true;
                        answer2.Visible = true;
                        for (int i = 1; i < 5; i++)
                        {
                            Controls["option" + i + "_tx"].Visible = true;
                            Controls["option" + i].Visible = true;
                        }
                        if (existDataQuestionList[index].questionOption?.Count != 4)
                        {
                            existDataQuestionList[index].questionOption?.Add(option3_tx.Text);
                            existDataQuestionList[index].questionOption?.Add(option4_tx.Text);
                        }
                        existDataQuestionList[index].type = "בחירה מרובה";
                        break;
                }

            }

            for (int i = 0; i < typeQ.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    typeQ.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }


        private void deleteQ_Click(object sender, EventArgs e)
        {

            CurrTest.allScore -= existDataQuestionList[index].score;
            //CurrTest.status = false;
            existDataQuestionList.RemoveAt(index);
            foreach (var i in existDataQuestionList)
            {
                existDataQuestion.Add(i);
            }

            string updatedJsonQ = JsonConvert.SerializeObject(existDataQuestion);
            File.WriteAllText("question.json", updatedJsonQ);
            if (existDataQuestionList.Count != 0)
                GetTestList.Add(CurrTest);
            string updatedJsonTest = JsonConvert.SerializeObject(GetTestList);
            File.WriteAllText("tests.json", updatedJsonTest);
            if (existDataQuestionList.Count == 0)
            {
                this.Hide();
                EditTest t1 = new EditTest();
                t1.Closed += (s, args) => this.Close();
                t1.Show();
            }
            else
                Edit_ListOfQuestion_Load_1(null, EventArgs.Empty);

        }

        private void Score_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
