namespace final_project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            teacher_btn = new Button();
            student_btn = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // teacher_btn
            // 
            teacher_btn.BackColor = Color.White;
            teacher_btn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            teacher_btn.ForeColor = Color.RosyBrown;
            teacher_btn.Location = new Point(241, 60);
            teacher_btn.Margin = new Padding(3, 2, 3, 2);
            teacher_btn.Name = "teacher_btn";
            teacher_btn.Size = new Size(216, 92);
            teacher_btn.TabIndex = 0;
            teacher_btn.Text = "מורה";
            teacher_btn.UseVisualStyleBackColor = false;
            teacher_btn.Click += teacher_btn_Click;
            // 
            // student_btn
            // 
            student_btn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            student_btn.ForeColor = Color.RosyBrown;
            student_btn.Location = new Point(241, 170);
            student_btn.Margin = new Padding(3, 2, 3, 2);
            student_btn.Name = "student_btn";
            student_btn.Size = new Size(216, 91);
            student_btn.TabIndex = 1;
            student_btn.Text = "תלמידים";
            student_btn.UseVisualStyleBackColor = true;
            student_btn.Click += student_btn_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            exit.ForeColor = Color.RosyBrown;
            exit.Location = new Point(53, 241);
            exit.Name = "exit";
            exit.Size = new Size(74, 67);
            exit.TabIndex = 2;
            exit.Text = "🔚";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(700, 338);
            Controls.Add(exit);
            Controls.Add(student_btn);
            Controls.Add(teacher_btn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button teacher_btn;
        private Button student_btn;
        private Button exit;
    }
}