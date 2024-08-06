namespace final_project
{
    partial class CheckFinish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            yes = new Button();
            no = new Button();
            wanna = new Label();
            label1 = new Label();
            num = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // yes
            // 
            yes.BackColor = Color.RosyBrown;
            yes.Location = new Point(256, 58);
            yes.Name = "yes";
            yes.Size = new Size(38, 35);
            yes.TabIndex = 0;
            yes.Text = "✔️";
            yes.UseVisualStyleBackColor = false;
            yes.Click += yes_Click_1;
            // 
            // no
            // 
            no.BackColor = Color.RosyBrown;
            no.Location = new Point(191, 58);
            no.Name = "no";
            no.Size = new Size(38, 35);
            no.TabIndex = 1;
            no.Text = "❌";
            no.UseVisualStyleBackColor = false;
            no.Click += no_Click_1;
            // 
            // wanna
            // 
            wanna.AutoSize = true;
            wanna.Location = new Point(155, 32);
            wanna.Name = "wanna";
            wanna.Size = new Size(139, 15);
            wanna.TabIndex = 2;
            wanna.Text = "???אתה בטוח רוצה להגיש";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 52);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = ":לא ענית על";
            // 
            // num
            // 
            num.AutoSize = true;
            num.Location = new Point(45, 67);
            num.Name = "num";
            num.Size = new Size(0, 15);
            num.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 79);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "שאלות";
            label3.Click += label3_Click;
            // 
            // CheckFinish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(339, 113);
            Controls.Add(label3);
            Controls.Add(num);
            Controls.Add(label1);
            Controls.Add(wanna);
            Controls.Add(no);
            Controls.Add(yes);
            Name = "CheckFinish";
            Text = "CheckFinish";
            Load += CheckFinish_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yes;
        private Button no;
        private Label wanna;
        private Label label1;
        private Label num;
        private Label label3;
    }
}