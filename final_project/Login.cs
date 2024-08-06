namespace final_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void teacher_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersForm t1 = new TeachersForm();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestListForStudent t1 = new TestListForStudent();
            t1.Closed += (s, args) => this.Close();
            t1.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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