namespace final_project
{
    partial class MarkForm
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
            mark = new Label();
            markl = new Label();
            back = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // mark
            // 
            mark.AutoSize = true;
            mark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mark.Location = new Point(313, 71);
            mark.Name = "mark";
            mark.Size = new Size(228, 21);
            mark.TabIndex = 0;
            mark.Text = ":סך הנקודות שצברת למבחן זה";
            // 
            // markl
            // 
            markl.AutoSize = true;
            markl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            markl.Location = new Point(242, 71);
            markl.Name = "markl";
            markl.Size = new Size(65, 25);
            markl.TabIndex = 1;
            markl.Text = "label1";
            // 
            // back
            // 
            back.Location = new Point(58, 316);
            back.Name = "back";
            back.Size = new Size(143, 23);
            back.TabIndex = 2;
            back.Text = "חזור לרשימת הבחינות";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // exit
            // 
            exit.Location = new Point(58, 356);
            exit.Name = "exit";
            exit.Size = new Size(143, 23);
            exit.TabIndex = 3;
            exit.Text = "ליציאה";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(742, 415);
            Controls.Add(exit);
            Controls.Add(back);
            Controls.Add(markl);
            Controls.Add(mark);
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mark;
        private Label markl;
        private Button back;
        private Button exit;
    }
}