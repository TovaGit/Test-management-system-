using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace final_project
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void addNewTest_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewTestForm t1 = new NewTestForm();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }

        private void editTest_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            EditTest t1 = new EditTest();
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
