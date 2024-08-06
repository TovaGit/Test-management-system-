namespace final_project
{
    partial class TeachersForm
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
            addNewTest_btn = new Button();
            editTest_btn = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // addNewTest_btn
            // 
            addNewTest_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addNewTest_btn.ForeColor = Color.RosyBrown;
            addNewTest_btn.Location = new Point(317, 99);
            addNewTest_btn.Margin = new Padding(3, 2, 3, 2);
            addNewTest_btn.Name = "addNewTest_btn";
            addNewTest_btn.Size = new Size(147, 82);
            addNewTest_btn.TabIndex = 0;
            addNewTest_btn.Text = "יצירת מבחן חדש";
            addNewTest_btn.UseVisualStyleBackColor = true;
            addNewTest_btn.Click += addNewTest_btn_Click;
            // 
            // editTest_btn
            // 
            editTest_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            editTest_btn.ForeColor = Color.RosyBrown;
            editTest_btn.Location = new Point(317, 206);
            editTest_btn.Margin = new Padding(3, 2, 3, 2);
            editTest_btn.Name = "editTest_btn";
            editTest_btn.Size = new Size(147, 82);
            editTest_btn.TabIndex = 1;
            editTest_btn.Text = "עריכת מבחן";
            editTest_btn.UseVisualStyleBackColor = true;
            editTest_btn.Click += editTest_btn_Click;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.RosyBrown;
            back.Location = new Point(42, 341);
            back.Name = "back";
            back.Size = new Size(75, 63);
            back.TabIndex = 2;
            back.Text = "🔙";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // TeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(781, 441);
            Controls.Add(back);
            Controls.Add(editTest_btn);
            Controls.Add(addNewTest_btn);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeachersForm";
            Text = "TeachersForm";
            ResumeLayout(false);
        }

        #endregion

        private Button addNewTest_btn;
        private Button editTest_btn;
        private Button back;
    }
}