namespace WinFormsApp1
{
    partial class UserInteractiveForm
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
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_enter_username = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(12, 30);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(63, 15);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(81, 28);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(200, 23);
            this.textBox_username.TabIndex = 0;
            // 
            // button_enter_username
            // 
            this.button_enter_username.Location = new System.Drawing.Point(287, 27);
            this.button_enter_username.Name = "button_enter_username";
            this.button_enter_username.Size = new System.Drawing.Size(75, 23);
            this.button_enter_username.TabIndex = 1;
            this.button_enter_username.Text = "Enter";
            this.button_enter_username.UseVisualStyleBackColor = true;
            this.button_enter_username.Click += new System.EventHandler(this.button_enter_username_Click);
            // 
            // UserInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 86);
            this.Controls.Add(this.button_enter_username);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInteractiveForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_username;
        private TextBox textBox_username;
        private Button button_enter_username;
    }
}