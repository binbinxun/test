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
    public partial class count : Form
    {
        public count()
        {
            InitializeComponent();
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            // 创建一个名为input的input窗体对象-李圣贤
            input inputForm = new input();

            // 显示input窗体
            inputForm.Show();

            // 可选：关闭当前窗体
            // this.Close();
        }

        private void btnplane_Click(object sender, EventArgs e)
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
