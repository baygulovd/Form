using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = listView1.SelectedItems;
            for (int i = 0; i < a.Count; i++)
            {
                listView1.Items.Remove(a[i]);
            }
        }
    }
}
