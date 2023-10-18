using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace warehouse
{
    public partial class input : Form
    {
        //在 input 窗体中，我们可以添加一个静态实例，确保整个应用程序中只有一个 input 实例存在。
        public static input Instance { get; private set; }

        public input()
        {
            InitializeComponent();
            Instance = this;
        }
        
        public string InputtxtaContent
        {
            get { return txta.Text;}
        }
        public string InputtxtbContent
        {
            get { return txtb.Text; }
        }
        public string InputtxtcContent
        {
            get { return txtc.Text; }
        }
        public string InputtxtdContent
        {
            get { return txtd.Text; }
        }
        public string InputtxteContent
        {
            get { return txte.Text; }
        }
        public string InputtxtfContent
        {
            get { return txtf.Text; }
        }
        public string InputtxtgContent
        {
            get { return txtg.Text; }
        }
        public string InputtxtfiContent
        {
            get { return txtfai.Text; }
        }
        public string InputtxthContent
        {
            get { return txth.Text; }
        }
        public string InputtxtcarnContent
        {
            get { return txtN.Text; }
        }
        public string InputtxtcarLContent
        {
            get { return txtD4.Text; }
        }
        /*
        public input()
        {
            InitializeComponent();
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            
            //当点击按钮从 input 跳转到 plane 或 count 时，不再需要创建新的实例，而是使用已有的实例。-李圣贤
            plane pp = new plane();
            pp.Show();
            this.Hide();
            /*plane pp = new plane(this);
            pp.Show();
            this.Hide();*/
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            /*
            count cc = new count(this);
            cc.Show();
            this.Hide();*/
            count cc = new count();
            cc.Show();
            this.Hide();
        }
    }
}
