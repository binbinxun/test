using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse
{
    public partial class plane : Form
    {
        Graphics graphics;
        //车每车一个，吊具一共九个
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        private Timer timer4;
        private Timer timer5;
        private Timer timer6;
        private Timer timer7;
        private Timer timer8;
        private Timer timer9;
        private Timer timer11;
        private Timer timer12;
        private Timer timer13;
        private Timer timer111;
        private Timer timer112;
        private Timer timer113;
        private Brush brushes1 = Brushes.Orange;
        private Brush brushes2 = Brushes.Green;
        private Brush brushes3 = Brushes.Green;
        private Brush brushes4 = Brushes.Green;
        bool t1 = false;//判断是否有货
        //吊具信息
        private int m1 = 230; // 吊具的初始X坐标
        private int n1 = 283; // 吊具的初始Y坐标
        //吊具目标
        private int m11 = 230;
        private int n11 = 259;
        //保留原始位置用于判断
        private int m111 = 230; // 吊具的初始X坐标
        private int n111 = 283; // 吊具的初始Y坐标
        //初始位置
        private int x1 = 230; // 车1的初始X坐标
        private int y1 = 259; // 车1的初始Y坐标
        private int x3 = 278; // 车3的初始X坐标
        private int y3 = 259; // 车3的初始Y坐标
        private int x2 = 254; // 车2的初始X坐标
        private int y2 = 235; // 车2的初始Y坐标
        //保存位置用于判断
        private int x111 = 230; // 车1的初始X坐标
        private int y111 = 259; // 车1的初始Y坐标
        private int x333 = 278; // 车3的初始X坐标
        private int y333 = 259; // 车3的初始Y坐标
        private int x222 = 254; // 车2的初始X坐标
        private int y222 = 235; // 车2的初始Y坐标
        //目标位置
        private int x11 = 254;
        private int y11 = 385;
        private int x33 = 254;
        private int y33 = 385;
        private int x22 = 254;
        private int y22 = 385;
        //存储已经不在这一位置的货物坐标
        List<(int x, int y)> disappear = new List<(int x, int y)>();
        List<(int x, int y)> again = new List<(int x, int y)>();

        private void InitializeTimer(int a)
        {
            switch (a)
                {
                    case 2:
                        timer2 = new Timer();
                        timer2.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字,这个数字固定位置是可以算出来的)
                        timer2.Tick += Timer2_Tick;
                        timer2.Start(); // 启动定时器
                        break;
                    case 3:
                        timer3 = new Timer();
                        timer3.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                        timer3.Tick += Timer3_Tick;
                        timer3.Start(); // 启动定时器
                        break;
                    case 4:
                        timer4 = new Timer();
                        timer4.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                        timer4.Tick += Timer4_Tick;
                        timer4.Start(); // 启动定时器
                        break;
                    case 5:
                        timer5 = new Timer();
                        timer5.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                        timer5.Tick += Timer5_Tick;
                        timer5.Start(); // 启动定时器
                        break;
                    case 6:
                        timer6 = new Timer();
                        timer6.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                        timer6.Tick += Timer6_Tick;
                        timer6.Start(); // 启动定时器
                        break;
                    case 7:
                        timer7 = new Timer();
                        timer7.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                        timer7.Tick += Timer7_Tick;
                        timer7.Start(); // 启动定时器
                        break;
                case 8:
                    timer8 = new Timer();
                    timer8.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                    timer8.Tick += Timer8_Tick;
                    timer8.Start(); // 启动定时器
                    break;
                case 9:
                    timer9 = new Timer();
                    timer9.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                    timer9.Tick += Timer9_Tick;
                    timer9.Start(); // 启动定时器
                    break;
            }
        }

        private void InitializeTimerCar(int b)
        {
            switch (b)
            {
                case 1:
                    timer11 = new Timer();
                    timer11.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字,这个数字固定位置是可以算出来的)
                    timer11.Tick += Timer11_Tick;
                    timer11.Start(); // 启动定时器
                    break;
                case 2:
                    timer12 = new Timer();
                    timer12.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                    timer12.Tick += Timer12_Tick;
                    timer12.Start(); // 启动定时器
                    break;
                case 3:
                    timer13 = new Timer();
                    timer13.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                    timer13.Tick += Timer13_Tick;
                    timer13.Start(); // 启动定时器
                    break;
                case 4:
                    timer111 = new Timer();
                    timer111.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字,这个数字固定位置是可以算出来的)
                    timer111.Tick += Timer111_Tick;
                    timer111.Start(); // 启动定时器
                    break;
                case 5:
                    timer112 = new Timer();
                    timer112.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                    timer112.Tick += Timer112_Tick;
                    timer112.Start(); // 启动定时器
                    break;
                case 6:
                    timer113 = new Timer();
                    timer113.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
                    timer113.Tick += Timer113_Tick;
                    timer113.Start(); // 启动定时器
                    break;
            }
        }
        //为了简化逻辑，我们可以只在 plane 和 count 窗体中存储对 input 的引用。
        public plane() // 正确的构造函数名为 plane
        {
            InitializeComponent();
            this.ii = input.Instance;
            pictureBox1.Paint += pictureBox1_Paint;
            this.DoubleBuffered = true; // 启用双缓冲以减少闪烁
            timer1 = new Timer();
            timer1.Interval = 200; // 设置定时器间隔（200毫秒）(应该可以在上面设变量，把定时器间隔修改成与时间有关的数字)
            timer1.Tick += Timer1_Tick;
            t1 = true;
            disappear.Add((230, 283));
            timer1.Start(); // 启动定时器
            //InitializeTimer();

        }

        //第一辆车
        private async void Timer1_Tick(object sender, EventArgs e)
        {
            int targetY=0 ;

            if (n1 > n11)
            {
                targetY = n11;
            }
            else
            {
                timer1.Stop(); // 停止定时器，停止移动
                n11 = 235;//修改目标位置
                brushes1 = Brushes.Blue;
                brushes2 = Brushes.Red;
                InitializeTimer(2);
                // 使用异步等待5秒
                await Task.Delay(5000);
                // 在等待结束后启动timer11
                InitializeTimerCar(1);
                return;
            }
            if (n1 >targetY)
            {
                n1 -= 4; // 每个Tick移动矩形5个像素
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int targetY = 0;

            if (n1 > n11)
            {
                targetY = n11;
            }
            else
            {
                timer2.Stop(); // 停止定时器，停止移动
                m11 = 254;
                brushes1 = Brushes.Orange;
                disappear.Add((230, 235));
                InitializeTimer(3);
                return;
            }
            if (n1 >targetY)
            {
                n1 -= 4; // 每个Tick移动矩形5个像素
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            
        }
        private async void Timer3_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            if (m1 < m11)
            {
                targetX = m11;
            }
            else
            {
                timer3.Stop(); // 停止定时器，停止移动
                m11 = 278;//修改目标位置
                brushes1 = Brushes.Blue;
                brushes3 = Brushes.Red;
                InitializeTimer(4);
                // 使用异步等待5秒
                await Task.Delay(18000);
                // 在等待结束后启动timer12
                InitializeTimerCar(2);
                return;
            }

            if (m1 < targetX)
            {
                m1 += 4; // 每个Tick移动矩形5个像素
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            if (m1 < m11)
            {
                targetX = m11;
            }
            else
            {
                timer4.Stop(); // 停止定时器，停止移动
                n11 = 259;//修改目标位置
                brushes1 = Brushes.Orange;
                disappear.Add((278, 235));
                InitializeTimer(5);
                return;
            }

            if (m1 < targetX)
            {
                m1 += 4; // 每个Tick移动矩形5个像素
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private async void Timer5_Tick(object sender, EventArgs e)
        {
            int targetY = 0;
            if (n1 < n11)
            {
                targetY = m11;
            }
            else
            {
                timer5.Stop(); // 停止定时器，停止移动
                brushes1 = Brushes.Blue;
                brushes4 = Brushes.Red;
                m11 = 590;
                n11 = 355;
                InitializeTimer(6);
                // 使用异步等待5秒
                await Task.Delay(30000);
                // 在等待结束后启动timer13
                InitializeTimerCar(3);
                return;
            }

            if (n1 < targetY)
            {
                n1 += 4; // 每个Tick移动矩形5个像素
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private async void Timer6_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (m1 < m11)
            {
                targetX = m11;
                if (m1 < targetX)
                {
                    m1 += 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (n1<n11)
            {
                targetY = n11;
                if (n1 < targetY)
                {
                    n1 += 4; // 每个Tick移动矩形5个像素
                }
            }
            else
            {
                timer6.Stop(); // 停止定时器，停止移动
                brushes1 = Brushes.Orange;
                disappear.Add((590, 355));
                m11 = 230;
                n11 = 235;
                InitializeTimer(7);
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private async void Timer7_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (m1 > m11)
            {
                targetX = m11;
                if (m1 > targetX)
                {
                    m1 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (n1 > n11)
            {
                targetY = n11;
                if (n1 > targetY)
                {
                    n1 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else
            {
                timer7.Stop(); // 停止定时器，停止移动
                brushes1 = Brushes.Blue;
                //2号存储点重新画出
                again.Add((230, 235));
                m11 = 38;
                n11 = 43;
                InitializeTimer(8);
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private async void Timer8_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (m1 > m11)
            {
                targetX = m11;
                if (m1 > targetX)
                {
                    m1 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (n1 > n11)
            {
                targetY = n11;
                if (n1 > targetY)
                {
                    n1 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else
            {
                timer8.Stop(); // 停止定时器，停止移动
                brushes1 = Brushes.Orange;
                disappear.Add((38, 43));
                m11 = 278;
                n11 = 235;
                InitializeTimer(9);
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private async void Timer9_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (m1 < m11)
            {
                targetX = m11;
                if (m1 < targetX)
                {
                    m1 += 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (n1 < n11)
            {
                targetY = n11;
                if (n1 < targetY)
                {
                    n1 += 4; // 每个Tick移动矩形5个像素
                }
            }
            else
            {
                timer9.Stop(); // 停止定时器，停止移动
                brushes1 = Brushes.Blue;
                again.Add((278, 235));
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer11_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (x1 < x11)
            {
                targetX = x11;
            }
            else if (y1 < y11)
            {
                targetY = y11;
            }
            else
            {
                timer11.Stop(); // 停止定时器，停止移动
                x11 = 230;
                y11 = 259;
                brushes2 = Brushes.Green;
                InitializeTimerCar(4);
                return;
            }

            if (x1 < targetX)
            {
                x1 += 4; // 每个Tick移动矩形5个像素
            }

            if (y1 < targetY)
            {
                y1 += 4; // 每个Tick移动矩形5个像素
            }

            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer12_Tick(object sender, EventArgs e)
        {
            int targetY = 0;

           if (y2 < y22)
            {
                targetY = y22;
            }
            else
            {
                timer12.Stop(); // 停止定时器，停止移动
                y22 = 235;
                brushes3 = Brushes.Green;
                InitializeTimerCar(5);
                return;
            }

            if (y2 < targetY)
            {
                y2 += 4; // 每个Tick移动矩形5个像素
            }

            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer13_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (x3 >x33)
            {
                targetX = x33;
                if (x3 > targetX)
                {
                    x3 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (y3 < y33)
            {
                targetY = y33;
                if (y3 < targetY)
                {
                    y3 += 4; // 每个Tick移动矩形5个像素
                }
            }
            else
            {
                timer13.Stop(); // 停止定时器，停止移动
                x33 = 278;
                y33 = 259;
                brushes4 = Brushes.Green;
                InitializeTimerCar(6);
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer111_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;

            if (y1 > y11)
            {
                targetY = y11;
                if (y1 > targetY)
                {
                    y1 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (x1 > x11)
            {
                targetX = x11;
                if (x1 > targetX)
                {
                    x1 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else
            {
                timer111.Stop(); // 停止定时器，停止移动
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer112_Tick(object sender, EventArgs e)
        {
            int targetY = 0;

            if (y2 > y22)
            {
                targetY = y22;
            }
            else
            {
                timer112.Stop(); // 停止定时器，停止移动
                return;
            }

            if (y2 > targetY)
            {
                y2 -= 4; // 每个Tick移动矩形5个像素
            }

            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }
        private void Timer113_Tick(object sender, EventArgs e)
        {
            int targetX = 0;
            int targetY = 0;
            if (y3 > y33)
            {
                targetY = y33;
                if (y3 > targetY)
                {
                    y3 -= 4; // 每个Tick移动矩形5个像素
                }
            }
            else if (x3 < x33)
            {
                targetX = x33;
                if (x3 < targetX)
                {
                    x3 += 4; // 每个Tick移动矩形5个像素
                }
            }
           
            else
            {
                timer113.Stop(); // 停止定时器，停止移动
                return;
            }
            pictureBox1.Invalidate(); // 请求重绘pictureBox1
            //InitializeTimer();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //e.Graphics.FillRectangle(Brushes.Blue, x1, y1, 12, 12); // 在当前X坐标位置绘制一个蓝色的矩形
        }

        private static plane instance;
        
        private input ii;
        private count cc;
        public plane(input ii, count cc)
        {
           
            InitializeComponent();
            this.ii = ii;
            this.cc = cc;
            //InitializeTimer();


        }
        private plane(input ii)
        {
            InitializeComponent();
            this.ii = ii;
            //InitializeTimer();

        }
        public static plane GetInstance(input ii)
        {
            if (instance == null)
                instance = new plane(ii);
            return instance;
        }

        private void plane_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ii.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ii.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ii.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count cc = new count();
            cc.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ii.Show();
            this.Hide();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            count cc = new count();
            cc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ii.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ii.Show();
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            ii.Show();
        }
       
      
        public class WareHouseCalculator
        {
            public double a = 100.0; // 仓库长度
            public double b = 60.0; // 仓库宽度
            public double c = 40.0; //左侧宽
            public double d = 38.0; // 下册宽
            public double e = 2.0; //路宽
            public double f = 2.0; //与墙面间隔
            public double g = 2.0; //货物间隔
            public double fi = 2.0;//货物宽度
            public double h = 2.0; //货物高度

            public int car_num = 3;//车辆数量
            public int dyzj_num = 1;//

            public double v1 = 5 / 3.6;//吊运速度
            public double v2 = 10 / 3.6;//车运速度

            public double t1 = 20 * 60;//20分钟
            public double t2 = 5 * 60;

            public double car_len = 2;//车长不大于3米
            public WareHouseCalculator()
            {
                /*暂时不考虑修改参数的问题
                 input ii = new input();
                 this.a = double.Parse(ii.InputtxtaContent);
                 this.b = double.Parse(ii.InputtxtbContent);
                 this.c = double.Parse(ii.InputtxtcContent);
                 this.d = double.Parse(ii.InputtxtdContent);
                 this.e = double.Parse(ii.InputtxteContent);
                 this.f = double.Parse(ii.InputtxtfContent);
                 this.g = double.Parse(ii.InputtxtgContent); 
                 this.fi = double.Parse(ii.InputtxtfiContent);
                 this.h = double.Parse(ii.InputtxthContent);
                 this.car_num = int.Parse(ii.InputtxtcarnContent);
                 this.dyzj_num = 1;
                 this.car_len = double.Parse(ii.InputtxtcarLContent);*/
            }

            public WareHouseCalculator(double a, double b, double c, double d, double e, double f, double g, double fi, double h, int car_num, int dyzj_num, double c_len)
            {
                // 使用默认参数，与前端页面连接后可修改为前端输入值
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
                this.e = e;
                this.f = f;
                this.g = g;
                this.fi = fi;
                this.h = h;
                this.car_num = car_num;
                this.dyzj_num = dyzj_num;
                this.car_len = c_len;
            }
            public List<(double x, double y)> CalculateCoordinates()
            {
                // 创建一个空的列表来存储坐标
                List<(double x, double y)> coordinates = new List<(double x, double y)>();

                // 确定货物的布局或分布方式
                // 这可能会根据具体的仓库布局和货物尺寸来决定
                // 在这个示例中，我们假设所有的货物都以一定的间隔平均分布在仓库中
                
                //修改更新：//1234
                int rows = (int)((c - 2 * f - e / 2) / (fi + g) + (a - c - 2 * f - e / 2) / (fi + g));
                int columns = (int)((d - 2 * f - e / 2) / (fi + g) + (b - d - 2 * f - e / 2) / (fi + g));
                // 计算每行和每列的货物的x和y坐标
               
                bool a2 = true, b2 = true;
                int aa = 0, bb = 0;
                for (int i = 0; ; i++)
                {
                    double x = i * (fi + g) + fi / 2 + f;
                    if (x > c - f - fi / 2 && x < c + f + fi / 2)
                    {
                        continue;
                    }
                    if (x >= c)
                    {
                        if (a2)
                        {
                            a2 = !a2;
                            aa = i;
                        }
                        x = c + e + fi / 2 + f + (i - aa) * (fi + g);
                    }
                    if (x < c)
                    {
                        x += (c - f) % (fi + g);
                    }
                    if (x > a - f - fi / 2)
                    {
                        break;
                    }
                    for (int j = 0; ; j++)
                    {
                        // 计算x和y坐标

                        double y = j * (fi + g) + fi / 2 + f;
                        if (y > d - f - fi / 2 && y < d + f + fi / 2)
                        {
                            continue;
                        }
                        if (y >= d)
                        {
                            if (b2)
                            {
                                b2 = !b2;
                                bb = j;
                            }
                            y = d + e + f + fi / 2 + (j - bb) * (fi + g);
                        }
                        if (y < d)
                        {
                            y += (d - f) % (fi + g);
                        }
                        if (y > b - f - fi / 2 && y < b + f + fi / 2)
                        {
                            break;
                        }
                        // 将坐标添加到列表中
                        coordinates.Add((x-1, y+1));
                    }

                }

                // 返回坐标列表
                return coordinates;
            }
            public List<(double x, double y)> CalculateCCC()
            {
                int rows = (int)((c - 2 * f - e / 2) / (fi + g) + (a - c - 2 * f - e / 2) / (fi + g));
                int columns = (int)((d - 2 * f - e / 2) / (fi + g) + (b - d - 2 * f - e / 2) / (fi + g));
                List<(double x, double y)> o = new List<(double x, double y)>();
                for (int i = 0; ; i++)
                {
                    double x = i * (fi + g) + fi / 2 + f;
                    if (x >= c)
                    {
                        x += e;
                    }
                    if (x >= a - f)
                    {
                        break;
                    }
                    o.Add((x, d + e / 2));
                }
                for (int j = 0; ; j++)
                {
                    // 计算x和y坐标

                    double y = j * (fi + g) + fi / 2 + f;

                    if (y >= d)
                    {
                        y += e;
                    }
                    if (y >= b - f)
                    {
                        break;
                    }
                    o.Add((c + e / 2, y));
                }
                return o;
            }
        }

            private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //现在所有的画图数据全部用的都是缺省值！！！
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black, 2.0f);
            //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);//画刷

            //获取仓库内货物点的坐标用于画图
            WareHouseCalculator w = new WareHouseCalculator();
            List<(double, double)> points = new List<(double, double)>();
            points = w.CalculateCoordinates();
            foreach ((double x, double y) point in points)
            {
                float heng = (float)(point.x - 1) * 6 + 20;
                float zong = (float)(point.y - 1) * 6 + 25;
                graphics.FillEllipse(Brushes.Gray, heng, zong, 12, 12);//来实心圆
             
            }
            //画出车和吊具的原始位置
            //graphics.FillRectangle(Brushes.Green, 230, 259, 12, 12);//左侧车
            //graphics.FillRectangle(Brushes.Green, 278, 259, 12, 12);//右侧车
            //graphics.FillRectangle(Brushes.Green, 254, 235, 12, 12);//上方车
            /*
            //吊具
            // 创建颜色对象
            Color color = Color.FromArgb(80, 255, 0, 0); // 透明度为30%
            // 创建画刷对象
            SolidBrush brush = new SolidBrush(color);
            // 定义三角形的顶点坐标
            Point[] trianglePoints =
            {
                new Point(230, 235),
                new Point(242, 235),
                new Point(236, 247)
            };
            // 绘制三角形
            graphics.FillPolygon(brush, trianglePoints);
            */


            // 在当前X坐标位置绘制一个蓝色的矩形
            for (int i = 0; i < disappear.Count; i++)
            {
                int aa = disappear[i].x;
                int bb = disappear[i].y;
                graphics.FillEllipse(Brushes.White, aa, bb, 12, 12);//来实心圆
            }
            for (int i = 0; i < again.Count; i++)
            {
                int cc = again[i].x;
                int dd = again[i].y;
                graphics.FillEllipse(Brushes.Gray, cc, dd, 12, 12);//来实心圆
            }
            e.Graphics.FillRectangle(brushes1, m1, n1, 12, 12);
            e.Graphics.FillRectangle(brushes2, x1, y1, 12, 12);
            e.Graphics.FillRectangle(brushes3, x2, y2, 12, 12);
            e.Graphics.FillRectangle(brushes4, x3, y3, 12, 12);
            

            //原位置遮挡
            //e.Graphics.FillRectangle(Brushes.White, 230, 259, 12, 12);
            //划出仓库边界线
            graphics.DrawRectangle(pen, 20, 25, 600, 360);
            //画出两条路，目前以缺省值为例，缺省值是100,60；现在以6为单位，改为600,360；
            //横着的左侧两线
            graphics.DrawLine(pen, 20, 259, 254, 259);
            graphics.DrawLine(pen, 20, 271, 254, 271);
            //竖着的上方两线
            graphics.DrawLine(pen, 254, 25, 254, 259);
            graphics.DrawLine(pen, 266, 25, 266, 259);
            //竖着的下方两线
            graphics.DrawLine(pen, 254, 271, 254, 385);
            graphics.DrawLine(pen, 266, 271, 266, 385);
            //横着的右侧两线
            graphics.DrawLine(pen, 266, 259, 620, 259);
            graphics.DrawLine(pen, 266, 271, 620, 271);

        }
    }
}
