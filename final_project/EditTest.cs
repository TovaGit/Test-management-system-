
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using static System.Windows.Forms.DataFormats;

namespace final_project
{
    public partial class EditTest : Form
    {
        GetFromJson j = new GetFromJson();
        public EditTest()
        {
            InitializeComponent();
        }

        List<Test> existDataTest;
        private void EditTest_Load(object sender, EventArgs e)
        {

            existDataTest = j.GetFromTestJson();
            int y = 50;
            if (existDataTest != null)
            {
                for (int i = 0; i < existDataTest.Count; i++)
                {
                    System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                    b.Click += new EventHandler(b_Click);
                    b.Location = new Point(250, y);
                    b.Text = existDataTest[i].testName;
                    b.Name = "b" + existDataTest[i].testName;
                    b.AutoSize = true;
                    this.Controls.Add(b);
                    Button delete = new Button();
                    delete.Click += new EventHandler(delete_Click);
                    delete.Text = "מחיקה";
                    delete.Name = existDataTest[i].testName;
                    delete.Location = new Point(350, y);
                    delete.AutoSize = true;
                    this.Controls.Add(delete);
                    y += 48;
                }
            }
            else
            {
                MessageBox.Show("no tests exists");
                this.Hide();
                TeachersForm t1 = new TeachersForm();
                t1.Closed += (s, args) => this.Close();
                t1.Show();
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_ListOfQuestion t1 = new Edit_ListOfQuestion(((Button)sender).Text);
            t1.Closed += (s, args) => this.Close();
            t1.Show();

        }
        public void EditCurrTest(object sender, EventArgs e)
        {

            MessageBox.Show("EditCurrTest");

        }
        void delete_Click(object sender, EventArgs e)
        {
            Test tmp = existDataTest.Find(t => t.testName == ((Button)sender).Name);
            existDataTest.Remove(tmp);
            string updatedJsonTest = JsonConvert.SerializeObject(existDataTest);
            File.WriteAllText("tests.json", updatedJsonTest);
            Button tName = (Button)Controls["b" + ((Button)sender).Name];
            tName.Visible = false;
            Button del = (Button)Controls[((Button)sender).Name];
            del.Visible = false;
            List<Question> existDataQuestion;
            existDataQuestion = j.GetFromQuestionJson();
            existDataQuestion.RemoveAll(t => t.id == ((Button)sender).Name);
            string updatedJsonQuestion = JsonConvert.SerializeObject(existDataQuestion);
            File.WriteAllText("question.json", updatedJsonQuestion);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersForm t1 = new TeachersForm();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }
    }

}
