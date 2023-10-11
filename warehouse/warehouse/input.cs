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
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            // 创建一个名为countsForm的count窗体对象-李圣贤
            count countsForm = new count();

            // 显示countsForm窗体
            countsForm.Show();

            // 隐藏当前窗体
            this.Hide();

            // 可选：关闭当前窗体
            // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建一个名为countsForm2的plane窗体对象-李圣贤
            plane countsForm2 = new plane();

            // 显示countsForm2窗体
            countsForm2.Show();

            // 隐藏当前窗体
            this.Hide();
        }

    }
}
