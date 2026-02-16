namespace WindowsFormsApp
{
    partial class FormMain
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
            this.button_makeRequest = new System.Windows.Forms.Button();
            this.button_checkRequestStatus = new System.Windows.Forms.Button();
            this.button_checkAllRequests = new System.Windows.Forms.Button();
            this.button_editRequest = new System.Windows.Forms.Button();
            this.button_editUser = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_makeRequest
            // 
            this.button_makeRequest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_makeRequest.Location = new System.Drawing.Point(30, 23);
            this.button_makeRequest.Name = "button_makeRequest";
            this.button_makeRequest.Size = new System.Drawing.Size(191, 51);
            this.button_makeRequest.TabIndex = 0;
            this.button_makeRequest.Text = "make request";
            this.button_makeRequest.UseVisualStyleBackColor = true;
            this.button_makeRequest.Click += new System.EventHandler(this.button_makeRequest_Click);
            // 
            // button_checkRequestStatus
            // 
            this.button_checkRequestStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_checkRequestStatus.Location = new System.Drawing.Point(30, 80);
            this.button_checkRequestStatus.Name = "button_checkRequestStatus";
            this.button_checkRequestStatus.Size = new System.Drawing.Size(191, 51);
            this.button_checkRequestStatus.TabIndex = 1;
            this.button_checkRequestStatus.Text = "check request status";
            this.button_checkRequestStatus.UseVisualStyleBackColor = true;
            this.button_checkRequestStatus.Click += new System.EventHandler(this.button_checkRequestStatus_Click);
            // 
            // button_checkAllRequests
            // 
            this.button_checkAllRequests.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_checkAllRequests.Location = new System.Drawing.Point(30, 137);
            this.button_checkAllRequests.Name = "button_checkAllRequests";
            this.button_checkAllRequests.Size = new System.Drawing.Size(191, 51);
            this.button_checkAllRequests.TabIndex = 2;
            this.button_checkAllRequests.Text = "check all requests";
            this.button_checkAllRequests.UseVisualStyleBackColor = true;
            this.button_checkAllRequests.Click += new System.EventHandler(this.button_checkAllRequests_Click);
            // 
            // button_editRequest
            // 
            this.button_editRequest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editRequest.Location = new System.Drawing.Point(30, 194);
            this.button_editRequest.Name = "button_editRequest";
            this.button_editRequest.Size = new System.Drawing.Size(191, 51);
            this.button_editRequest.TabIndex = 3;
            this.button_editRequest.Text = "edit request";
            this.button_editRequest.UseVisualStyleBackColor = true;
            this.button_editRequest.Click += new System.EventHandler(this.button_editRequest_Click);
            // 
            // button_editUser
            // 
            this.button_editUser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editUser.Location = new System.Drawing.Point(30, 251);
            this.button_editUser.Name = "button_editUser";
            this.button_editUser.Size = new System.Drawing.Size(191, 51);
            this.button_editUser.TabIndex = 4;
            this.button_editUser.Text = "edit user";
            this.button_editUser.UseVisualStyleBackColor = true;
            this.button_editUser.Click += new System.EventHandler(this.button_editUser_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logOut.Location = new System.Drawing.Point(87, 327);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(75, 44);
            this.button_logOut.TabIndex = 5;
            this.button_logOut.Text = "log out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.button_editUser);
            this.Controls.Add(this.button_editRequest);
            this.Controls.Add(this.button_checkAllRequests);
            this.Controls.Add(this.button_checkRequestStatus);
            this.Controls.Add(this.button_makeRequest);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_makeRequest;
        private System.Windows.Forms.Button button_checkRequestStatus;
        private System.Windows.Forms.Button button_checkAllRequests;
        private System.Windows.Forms.Button button_editRequest;
        private System.Windows.Forms.Button button_editUser;
        private System.Windows.Forms.Button button_logOut;
    }
}