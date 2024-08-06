namespace final_project
{
    partial class TestListForStudent
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
            back = new Button();
            SuspendLayout();
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.RosyBrown;
            back.Location = new Point(77, 340);
            back.Name = "back";
            back.Size = new Size(75, 60);
            back.TabIndex = 0;
            back.Text = "🔙";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // TestListForStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Name = "TestListForStudent";
            Text = "TestListForStudent";
            Load += TestListForStudent_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button back;
    }
}