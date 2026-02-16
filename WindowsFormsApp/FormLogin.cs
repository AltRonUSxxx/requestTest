using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private async void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            foreach (char k in username)
            {
                if (!Char.IsLetterOrDigit(k))
                {
                    MessageBox.Show("Use only lettor or digit for username");
                    return;
                }
            }
            foreach (char k in password)
            {
                if (!Char.IsLetterOrDigit(k))
                {
                    MessageBox.Show("Use only lettor or digit for password");
                    return;
                }
            }
            string answer = await Program.client.SendAsync($"LOGIN|{username}|{password}");
            if (answer.Contains("SUCCESS"))
            {
                FormMain formMain = new FormMain(answer.Split('|')[1]);
                formMain.FormClosing += (s, args) =>
                {
                    this.Show();
                    textBox_password.Text = "";
                };
                formMain.Show();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.client.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel_registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister registration = new FormRegister();
            registration.FormClosing += (s, args) =>
            {
                this.Show();
            };
            registration.Show();
            this.Hide();
        }

    }
}
