using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockWork
{
    public partial class ClockWork : Form
    {
        int n;
        Button Add;
       MonthCalendar month;
        public ClockWork()
        {
            InitializeComponent();
            month = monthCalendar1;
            textBox1.Enabled = false;//使text不可以输入
            textBox1.WordWrap = true;//文本显示多行，自动换行
            textBox1.AcceptsReturn = true;//可以使用回车换行
            textBox1.Visible = false;
            month = monthCalendar1;//初始化日期为今天
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClockWork_Load(object sender, EventArgs e)
        {

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void 添加任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            textBox1.Visible = true;
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            textBox1.Visible = true;
            textBox1.Enabled = true;
        }
    }
}
