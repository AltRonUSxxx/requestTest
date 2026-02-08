namespace WindowsFormsApp
{
    partial class FormRegistration
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
            this.textBox_password1 = new System.Windows.Forms.TextBox();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_registration = new System.Windows.Forms.Button();
            this.linkLabel_cancel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_username.Location = new System.Drawing.Point(84, 74);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(255, 31);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password1
            // 
            this.textBox_password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password1.Location = new System.Drawing.Point(84, 134);
            this.textBox_password1.Name = "textBox_password1";
            this.textBox_password1.Size = new System.Drawing.Size(255, 31);
            this.textBox_password1.TabIndex = 1;
            // 
            // textBox_password2
            // 
            this.textBox_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password2.Location = new System.Drawing.Point(84, 192);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(255, 31);
            this.textBox_password2.TabIndex = 2;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_email.Location = new System.Drawing.Point(84, 258);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(255, 31);
            this.textBox_email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paswrd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paswrd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // button_registration
            // 
            this.button_registration.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registration.Location = new System.Drawing.Point(110, 332);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(139, 49);
            this.button_registration.TabIndex = 8;
            this.button_registration.Text = "Register";
            this.button_registration.UseVisualStyleBackColor = true;
            // 
            // linkLabel_cancel
            // 
            this.linkLabel_cancel.AutoSize = true;
            this.linkLabel_cancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_cancel.Location = new System.Drawing.Point(156, 384);
            this.linkLabel_cancel.Name = "linkLabel_cancel";
            this.linkLabel_cancel.Size = new System.Drawing.Size(49, 19);
            this.linkLabel_cancel.TabIndex = 9;
            this.linkLabel_cancel.TabStop = true;
            this.linkLabel_cancel.Text = "Cancel";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 428);
            this.Controls.Add(this.linkLabel_cancel);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.textBox_password1);
            this.Controls.Add(this.textBox_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRegistration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password1;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.LinkLabel linkLabel_cancel;
    }
}