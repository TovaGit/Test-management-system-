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
    public partial class OpenPage : Form
    {
        public OpenPage()
        {
            InitializeComponent();
        }

        private void OpenPage_Load(object sender, EventArgs e)
        {

        }

        private void enterLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login t2 = new Login();
            t2.Closed += (s, args) => this.Close();
            t2.Show();
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
