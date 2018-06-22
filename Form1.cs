using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SWF_in_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axShockwaveFlash1.Movie = Application.StartupPath + @"\ttt";
            axShockwaveFlash1.Playing = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:er.dhruvmishra@gmail.com");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.aiosolution.org");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.instamojo.com/@er_dhruvmishra");
        }

    }
}
