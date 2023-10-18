using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse
{
    public partial class plane : Form
    {
        public plane()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 创建一个名为countsForm的count窗体对象-李圣贤
            count countsForm = new count();

            // 显示countsForm窗体
            countsForm.Show();

            // 隐藏当前窗体
            //this.Hide();

            // 可选：关闭当前窗体
            // this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 创建一个名为input的input窗体对象-李圣贤
            input inputForm = new input();

            // 显示input窗体
            inputForm.Show();

            // 可选：关闭当前窗体
            // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 创建一个名为input的input窗体对象-李圣贤
            input inputForm = new input();

            // 显示input窗体
            inputForm.Show();

            // 可选：关闭当前窗体
            // this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 创建一个名为countsForm的count窗体对象-李圣贤
            count countsForm = new count();

            // 显示countsForm窗体
            countsForm.Show();

            // 隐藏当前窗体
            //this.Hide();

            // 可选：关闭当前窗体
            // this.Close();
        }
    }
}
