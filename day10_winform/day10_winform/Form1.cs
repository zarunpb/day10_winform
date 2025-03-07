using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day10_winform
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gettext = question_text.Text;
            DataTable table = new DataTable();
            var c = table.Compute(gettext, null);
            solution_textbox.Text = c.ToString();
            solution_label.Text = c.ToString();
        }
    }
}
