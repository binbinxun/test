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
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 清空之前的选项控件
            panel1.Controls.Clear();

            // 根据用户选择的区域创建相应的选项控件
            for(int j = 1; j <= 9; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = $"货物 {i*j}";
                    checkbox.Top = i * 30;  // 设置选项的垂直位置
                    checkbox.Left = (j-1) * 105;
                    panel1.Controls.Add(checkbox);  // 将选项控件添加到容器控件中
                }
            }
            
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // 清空之前的选项控件
            panel1.Controls.Clear();

            // 根据用户选择的区域创建相应的选项控件
            for (int j = 1; j <= 4; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = $"货物 {i * j}";
                    checkbox.Top = i * 30;  // 设置选项的垂直位置
                    checkbox.Left = (j - 1) * 105;
                    panel1.Controls.Add(checkbox);  // 将选项控件添加到容器控件中
                }
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // 清空之前的选项控件
            panel1.Controls.Clear();

            // 根据用户选择的区域创建相应的选项控件
            for (int j = 1; j <= 9; j++)
            {
                for (int i = 1; i <= 14; i++)
                {
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = $"货物 {i * j}";
                    checkbox.Top = i * 30;  // 设置选项的垂直位置
                    checkbox.Left = (j - 1) * 105;
                    panel1.Controls.Add(checkbox);  // 将选项控件添加到容器控件中
                }
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // 清空之前的选项控件
            panel1.Controls.Clear();

            // 根据用户选择的区域创建相应的选项控件
            for (int j = 1; j <= 4; j++)
            {
                for (int i = 1; i <= 14; i++)
                {
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = $"货物 {i * j}";
                    checkbox.Top = i * 30;  // 设置选项的垂直位置
                    checkbox.Left = (j - 1) * 105;
                    panel1.Controls.Add(checkbox);  // 将选项控件添加到容器控件中
                }
            }
        }
    }
}
