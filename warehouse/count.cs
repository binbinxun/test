using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static warehouse.count;
using ProgressBar = System.Windows.Forms.ProgressBar;
//using static WareHouseCalculator;


namespace warehouse
{



    public partial class count : Form
    {

        public input ii;



        public count() // 不再需要参数
        {
            InitializeComponent();
            this.ii = input.Instance;


        }





        public void btninput_Click(object sender, EventArgs e)
        {
            input ii = new input();
            ii.Show();
            this.Hide();
        }



        public void btnplane_Click(object sender, EventArgs e)
        {
            plane pp = new plane();
            pp.Show();
            this.Hide();

        }

        public void btnAll_Click(object sender, EventArgs e)
        {
            input ii2 = new input();
        }

        private void btnappoint_Click(object sender, EventArgs e)
        {
            input ss = new input();
            ss.Show();
            this.Hide();
        }
    }
}
        



       
       




        

       


       
        



       
