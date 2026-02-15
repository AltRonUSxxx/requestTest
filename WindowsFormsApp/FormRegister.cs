using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private async void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password1 = textBox_password1.Text;
            string password2 = textBox_password2.Text;
            string email = textBox_email.Text;
            if (password1 != password2)
            {
                MessageBox.Show("The password should same");
                return;
            }
            foreach (char k in password1)
            {
                if (!Char.IsLetterOrDigit(k))
                {
                    MessageBox.Show("Use only letter and digit");
                    return;
                }
            }
            foreach (char k in username)
            {
                if (!Char.IsLetterOrDigit(k))
                {
                    MessageBox.Show("Use only letter and digit");
                    return;
                }
            }
            if (!email.Contains('@'))
            {
                MessageBox.Show("Are u sure that u have email without @");
                return;
            }
            if (email.Contains('|'))
            {
                MessageBox.Show("Don't use '|'");
                return;
            }
            string request = $"REG|{username}|{password1}|{email}";
            string answer = await Program.client.SendAsync(request);
            if (!answer.Contains("SUCCESS"))
            {
                MessageBox.Show(answer);
            }
            else
            {

            }
        }
    }
}
