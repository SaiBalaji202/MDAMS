using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MDAMS
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private List<int> i;
        private List<string> str;

        private void Sample_Load(object sender, EventArgs e)
        {
            i = new List<int>();
            str = new List<string>();
            i.Add(1); str.Add("a");
            i.Add(2); str.Add("b");
            i.Add(1); str.Add("a");
            i.Add(1); str.Add("a");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = (textBox1.Text);
            int index = -1;
            while ((index = str.IndexOf(x, index + 1)) > -1)
            {
                textBox2.Text = index.ToString() + " " + str[index] + "  ";
                //i.RemoveAt(index); str.RemoveAt(index);
            }

        }
    }
}
