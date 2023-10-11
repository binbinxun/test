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
    public partial class OutputWindow : Form
    {
        public OutputWindow()
        {
            InitializeComponent();
        }

        public void SetOutput(string output)
        {
            richTextBoxOutput.Text = output;
        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
    


}



