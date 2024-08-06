namespace final_project
{
    partial class OpenPage
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
            this.enterLogin = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterLogin
            // 
            this.enterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enterLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterLogin.Location = new System.Drawing.Point(79, 312);
            this.enterLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enterLogin.Name = "enterLogin";
            this.enterLogin.Size = new System.Drawing.Size(86, 56);
            this.enterLogin.TabIndex = 0;
            this.enterLogin.Text = "לכניסה";
            this.enterLogin.UseVisualStyleBackColor = false;
            this.enterLogin.Click += new System.EventHandler(this.enterLogin_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(79, 376);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 56);
            this.exit.TabIndex = 1;
            this.exit.Text = "ליציאה";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // OpenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final_project.Properties.Resources.open1;
            this.ClientSize = new System.Drawing.Size(710, 477);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.enterLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpenPage";
            this.Text = "OpenPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button enterLogin;
        private Button exit;
    }
}