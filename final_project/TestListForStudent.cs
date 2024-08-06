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
    public partial class TestListForStudent : Form
    {
        GetFromJson j = new GetFromJson();
        public TestListForStudent()
        {

            InitializeComponent();
        }

        private void TestListForStudent_Load(object sender, EventArgs e)
        {
            List<Test> existDataTest;
            List<Test> DataTest_StatusTrue;


            existDataTest = j.GetFromTestJson();
            DataTest_StatusTrue = existDataTest.FindAll(t => t.status == true);
            int y = 50;
            if (DataTest_StatusTrue != null)
            {
                for (int i = 0; i < DataTest_StatusTrue.Count; i++)
                {
                    Button b = new Button();
                    b.Click += new EventHandler(b_Click);
                    b.Location = new Point(350, y);
                    b.Text = DataTest_StatusTrue[i].testName;
                    b.Name = "b" + DataTest_StatusTrue[i].testName;
                    b.AutoSize = true;
                    this.Controls.Add(b);
                    y += 48;
                }
            }
            else
            {
                MessageBox.Show("no tests exists");
                this.Hide();
                Login t1 = new Login();
                t1.Closed += (s, args) => this.Close();
                t1.Show();
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students t1 = new Students(((Button)sender).Text, true);
            t1.Closed += (s, args) => this.Close();
            t1.Show();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login t1 = new Login();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }
    }
}

