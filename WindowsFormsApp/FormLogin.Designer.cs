namespace WindowsFormsApp
{
    partial class FormLogin
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_registration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_username.Location = new System.Drawing.Point(74, 66);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(298, 37);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(74, 124);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(298, 37);
            this.textBox_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "paswrd";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(128, 167);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(132, 51);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // linkLabel_registration
            // 
            this.linkLabel_registration.AutoSize = true;
            this.linkLabel_registration.Location = new System.Drawing.Point(149, 231);
            this.linkLabel_registration.Name = "linkLabel_registration";
            this.linkLabel_registration.Size = new System.Drawing.Size(132, 19);
            this.linkLabel_registration.TabIndex = 5;
            this.linkLabel_registration.TabStop = true;
            this.linkLabel_registration.Text = "Don\'t have acount?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 260);
            this.Controls.Add(this.linkLabel_registration);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_registration;
    }
}

