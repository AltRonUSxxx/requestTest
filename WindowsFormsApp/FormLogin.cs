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

        private void button_login_Click(object sender, EventArgs e)
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
            MessageBox.Show("DS");
            string answer = Program.client.send($"LOGIN|{username}|{password}");
            if (!answer.Equals("SUCCESS"))
            {
                MessageBox.Show(answer);
                return;
            }
            else
            {
                MessageBox.Show("Workds");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.client.Close();
        }
    }
}
