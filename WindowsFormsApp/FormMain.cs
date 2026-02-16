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
    public partial class FormMain : Form
    {
        private string security_LVL;
        public FormMain(string security_levelOUT)
        {
            InitializeComponent();
            security_LVL = security_levelOUT;
            button_makeRequest.Hide();
            button_checkRequestStatus.Hide();
            button_checkAllRequests.Hide();
            button_editRequest.Hide();
            button_editUser.Hide();
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_makeRequest_Click(object sender, EventArgs e)
        {
            FormRequestMaker formRequestMaker = new FormRequestMaker();
            formRequestMaker.FormClosing += (s, args) =>
            {
                this.Show();
            };
            formRequestMaker.Show();
            this.Hide();
        }

        private void button_checkRequestStatus_Click(object sender, EventArgs e)
        {
            FormStatusChecker formStatusChecker = new FormStatusChecker();
            formStatusChecker.FormClosing += (s, args) =>
            {
                this.Show();
            };
            formStatusChecker.Show();
            this.Hide();
        }

        private void button_checkAllRequests_Click(object sender, EventArgs e)
        {
            FormAllRequests formAllRequests = new FormAllRequests();
            formAllRequests.FormClosing += (s, args) =>
            {
                this.Show();
            };
            formAllRequests.Show();
            this.Hide();
        }

        private void button_editRequest_Click(object sender, EventArgs e)
        {
            FormRequestEditor formRequestEditor = new FormRequestEditor();
            formRequestEditor.FormClosing += (s, args) =>
            {
                this.Show();
            };
            formRequestEditor.Show();
            this.Hide();
        }

        private void button_editUser_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser();
            formEditUser.FormClosing += (s, args) =>
            {
                this.Show();
            };
            formEditUser.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
