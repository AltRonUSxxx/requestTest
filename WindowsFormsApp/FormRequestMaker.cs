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
    public partial class FormRequestMaker : Form
    {
        public FormRequestMaker()
        {
            InitializeComponent();
        }

        private void FormRequestMaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
