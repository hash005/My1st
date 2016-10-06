/*
    Form1 cs
    初めてのC#プログラミング
    ボタンを押すと現在時刻が表示されます
    Created at 2016/10/4
    Created by hibiki hashiguchi
 */

using System;
using System.Windows.Forms;

namespace My1stCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
