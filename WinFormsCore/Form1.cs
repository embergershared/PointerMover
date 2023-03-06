using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}