namespace WindowsFormsApp
{
    partial class FormRequestEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_requestNumber = new System.Windows.Forms.TextBox();
            this.comboBox_editor = new System.Windows.Forms.ComboBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "number:";
            // 
            // textBox_requestNumber
            // 
            this.textBox_requestNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_requestNumber.Location = new System.Drawing.Point(78, 12);
            this.textBox_requestNumber.Name = "textBox_requestNumber";
            this.textBox_requestNumber.Size = new System.Drawing.Size(68, 26);
            this.textBox_requestNumber.TabIndex = 1;
            // 
            // comboBox_editor
            // 
            this.comboBox_editor.FormattingEnabled = true;
            this.comboBox_editor.Location = new System.Drawing.Point(22, 44);
            this.comboBox_editor.Name = "comboBox_editor";
            this.comboBox_editor.Size = new System.Drawing.Size(124, 21);
            this.comboBox_editor.TabIndex = 2;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send.Location = new System.Drawing.Point(87, 71);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(59, 25);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(22, 71);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(59, 25);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // FormRequestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 107);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.comboBox_editor);
            this.Controls.Add(this.textBox_requestNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormRequestEditor";
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRequestEditor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_requestNumber;
        private System.Windows.Forms.ComboBox comboBox_editor;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_cancel;
    }
}