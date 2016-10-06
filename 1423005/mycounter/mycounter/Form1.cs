/*
    Form1 cs
    C#プログラミング
    カウンター
    Created at 2016/10/4
    Created by hibiki hashiguchi
 */
using System;
using System.Windows.Forms;

namespace mycounter
{
    public partial class Form1 : Form
    {
        // int counter;
        // プロパティ記法
        int Counter { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter++;
            label1.Text = Counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter = 0;
            label1.Text = Counter.ToString();
        }
    }
}
