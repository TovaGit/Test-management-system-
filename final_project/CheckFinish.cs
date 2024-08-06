using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class CheckFinish : Form
    {

        List<Question> existDataQuestionList;
        int[] answer1;
        int[] answer2;
        string testName;
        int countEmptyAnswers;
        public CheckFinish(string Name, List<Question> existDataQuestionList, int[] answer1, int[] answer2, int countEmptyAnswers)
        {
            this.existDataQuestionList = existDataQuestionList;
            this.answer1 = answer1;
            this.answer2 = answer2;
            testName = Name;
            this.countEmptyAnswers = countEmptyAnswers;
            InitializeComponent();
        }

        private void yes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MarkForm t2 = new MarkForm(existDataQuestionList, answer1, answer2);
            t2.Closed += (s, args) => this.Close();
            t2.Show();

        }

        private void no_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Students t1 = new Students(testName, false);
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckFinish_Load(object sender, EventArgs e)
        {
            num.Text = Convert.ToString(countEmptyAnswers);
        }

       
    }
}
