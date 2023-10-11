//标1234的地方有问题
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System;
//using static WareHouseCalculator;
using static Program;
using System.IO;

public class Program
{
    public static void Main()
    {
        /*WareHouseCalculator calculator = new WareHouseCalculator();

        // 创建或获取DYZJ实例
        DYZJ dyzjInstance = new DYZJ(calculator);

        // 计算所有货物的坐标、、、记号<-◑✔▃✘◐☚▆▌☞☛㏘未完成   货物位置坐标，每行每列存货点数量，输入的参数怎么处理 （作为全局变量或者xx)
        List<(double x, double y)> coordinates = calculator.CalculateCoordinates();

        // 定义连接字符串
        string connectionString = "server=127.0.0.1;database=data;user=uuuroot;password=123456";

        // 创建连接
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {

            // 打开连接

            connection.Open();

            // 定义 SQL 查询

            string sql = "INSERT INTO data1 (X1, Y1, A1, B1) VALUES (@x1, @y1, @a1, @b1)";

            // 对于每个货物

            foreach (var coordinate in coordinates)
            {
                // 计算吊车到货物的最短距离
                //double a1 = calculator.CalculateCraneToCargoDistance(coordinate);
                // 计算吊车到货物的最短距离
                double a1 = calculator.CalculateCraneToCargoDistance(dyzjInstance, coordinate);



                // 计算货物到主路的最短距离
                double b1 = calculator.CalculateCargoToMainRoadDistance(coordinate);

                // 创建命令
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    // 添加参数
                    command.Parameters.AddWithValue("@x1", coordinate.x);
                    command.Parameters.AddWithValue("@y1", coordinate.y);
                    command.Parameters.AddWithValue("@a1", a1);
                    command.Parameters.AddWithValue("@b1", b1);

                    // 执行命令
                    command.ExecuteNonQuery();

                }
            }

        }*/
        init();
    }

    public class WareHouseCalculator
    {
        public double a = 100.0; // 仓库长度
        public double b = 60.0; // 仓库宽度
        public double c = 40.0; //左侧宽
        public double d = 20.0; // 下册宽
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
        public WareHouseCalculator() { }
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
            /*原计算：

            double c;//主路位置
            double d;//二路位置
            double e;//路宽

            int rows = (int)(a / (d + g));
            int columns = (int)(b / (d + g));
            */

            //修改更新：//1234
            int rows = (int)((c - 2 * f - e / 2) / (fi + g) + (a - c - 2 * f - e / 2) / (fi + g));
            int columns = (int)((d - 2 * f - e / 2) / (fi + g) + (b - d - 2 * f - e / 2) / (fi + g));
            // 计算每行和每列的货物的x和y坐标
            /*for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // 计算x和y坐标
                    double x = i * (fi + g) + fi / 2+f;
                    double y = j * (fi + g) + fi / 2 + f;

                    // 将坐标添加到列表中
                    coordinates.Add((x, y));
                }
            }*/
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
                    if (y > b - f - fi / 2 && y < b + f + fi / 2)
                    {
                        break;
                    }
                    // 将坐标添加到列表中
                    coordinates.Add((x, y));
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

        public Cargo_point[] initCP()
        {
            List<(double x, double y)> coordinate = CalculateCoordinates();
            Cargo_point[] cargo_points = new Cargo_point[coordinate.Count];
            for (int i = 0; i < coordinate.Count; i++)
            {
                cargo_points[i] = new Cargo_point(coordinate[i].x, coordinate[i].y);
            }
            return cargo_points;
        }

        public double CalculateCraneToCargoDistance(DYZJ dyzj, (double x, double y) cargoCoordinate)
        {


            // 在这里实现计算吊车到货物的最短距离的逻辑
            // 返回计算得到的距离
            //实质还是x坐标的差的绝对值加上y坐标的差的绝对值——王淳
            // 获取吊车当前的位置

            //首先要传入一个实例DYZJ dyzj
            // 使用吊车的坐标和货物的坐标计算距离
            // 距离 = |吊车的x坐标 - 货物的x坐标| + |吊车的y坐标 - 货物的y坐标|-李圣贤

            return Math.Abs(dyzj.x - cargoCoordinate.x) + Math.Abs(dyzj.y - cargoCoordinate.y);
        }


        public double CalculateCargoToMainRoadDistance((double x, double y) coordinate)
        {
            // 在这里实现计算货物到主路的最短距离的逻辑
            // 返回计算得到的距
            double i = Math.Abs(b - coordinate.y);
            double j = Math.Abs(coordinate.x - c);
            return Math.Max(i, j);
        }
    }



    public class Cargo_point
    {
        public double x;
        public double y;
        public bool cargo_existed = true;
        public bool cargo_ready = false;
        public Cargo_point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    //定义车
    //car类定义重新定义一下，加了Time方法
    //这里把car类的内容替换掉就可以
    public class car
    {
        public double x;//横坐标
        public double y;//纵坐标 这俩坐标记录车那一头，就离出口更远那一头，当然近的也行，然后，用不用具体到哪个点呢
        public double length;//车长
        public double v;//速度
        public bool OR;//有货吗
        public double t;//装车呢吗？装车的话还得多长时间啊？没装就1e20
        public bool or2;//在库里吗？

        public car(WareHouseCalculator wc)
        {
            x = wc.c + wc.e / 2;
            y = 0;
            length = wc.car_len;
            v = wc.v2;
            OR = false;
            t = 1e20;
            or2 = false;
        }

        // 定义 Time 方法，计算到目标坐标的时间
        public double Time(double targetX, double targetY)//有毛病
        {
            // 计算曼哈顿距离
            double distance = Math.Abs(targetX - x) + Math.Abs(targetY - y);

            // 返回到目标位置所需的时间，假设速度为 v
            return distance / v;

        }

        public void GetOut()
        {
            this.or2 = false;
        }
        public void TimeFlow(double t)
        {
            if (this.OR)
            {
                this.t -= t;
            }

        }
        public int OnRoad(WareHouseCalculator wc)
        {
            //在哪条路上
            if (x > wc.c + wc.e / 2)
            {
                return 4;
            }
            else if (x < wc.c + wc.e / 2)
            {
                return 3;
            }
            else if (y > wc.d + wc.e / 2)
            {
                return 2;
            }
            else if (y < wc.d + wc.e / 2)
            {
                return 1;
            }
            return 0;
        }
    }




    //定义类 车们
    public class Cars
    {
        WareHouseCalculator wc = new WareHouseCalculator();
        public car[] cars;
        public int num;//车的最大数量
        public Cars()
        {
            int num = wc.car_num;
            cars = new car[num];
            for (int i = 0; i < num; i++)
            {
                cars[i] = new car(wc);
            }

            this.num = num;

        }
        public Cars(WareHouseCalculator wc)
        {
            this.wc = wc;
            int num = wc.car_num;
            cars = new car[num];
            for (int i = 0; i < num; i++)
            {
                cars[i] = new car(wc);
            }

            this.num = num;
        }
        public int HowManyCarsIn()
        {
            return cars.Count(t => t.or2 == true);//返回仓库里车的数量。代码没测试过，可能有问题
        }
        //第一个要出去的车的位置和出去需要的时间
        public double[] FirstToGO()
        {
            double min = 999999;
            int j = 0;
            for (int i = 0; i < num; i++)
            {
                if (min > cars[i].t)
                {
                    min = cars[i].t;
                    j = i;
                }
            }
            double[] rst = { j, min };
            return rst;
        }
        public bool CheckOtherCarsOnTarget(double x, double y)
        {
            for (int i = 0; i < num; i++)
            {
                if (cars[i].x == x && cars[i].y == y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckCarsOnPath(double startX, double startY, double targetX, double targetY)
        {
            //这个函数还不完善

            // 在这里实现检查路径上是否有其他车辆的逻辑
            // 这个函数的实现可能需要用到更复杂的算法，如线段与矩形的交点检测
            // 为了简化问题，这里我们假设如果任何车辆的位置在起点和终点之间，那么就认为它在路径上
            foreach (car otherCar in cars)
            {
                if ((otherCar.x >= Math.Min(startX, targetX) && otherCar.x <= Math.Max(startX, targetX)) &&
                    (otherCar.y >= Math.Min(startY, targetY) && otherCar.y <= Math.Max(startY, targetY)))
                {
                    // 如果有车辆在起点和终点之间，返回 true
                    return true;
                }
            }
            // 如果没有车辆在起点和终点之间，返回 false
            return false;
        }
        //某车到指定位置就位所需时间、、、记号<-◑✔▃✘◐☚▆▌☞☛㏘未完成
        public double[] Time(double targetX, double targetY, int j)//传入j目标车辆下标
        {
            //思路：
            //查在库里所有车的位置，计算各条路哪些地方可以直接通行哪里不行
            //可以直接走，就直接走，(需要考虑计算仓库内其他车辆的出库是否会受影响，不一定要整合在这一个函数),情况1
            //不能直接走，将阻拦的车辆纳入考虑范围,情况2,3,4
            //这个函数可以再拆分出4个函数，通过调用那四个函数来简化这个函数的代码，同时条理相对更清晰
            //返回时间和方案序号
            //double[] result = { 99999.0, 0 };
            //以下写策略的选择并且更新result
            //return result;



            double[] result = { double.MaxValue, 0, -1, 0, 0 };//总时间 case编号  堵路车下标  堵路车装车时间 堵路车出库时间

            // 计算车辆到达指定位置所需的最短时间
            double minTime = CalculateMinTime(targetX, targetY, j);

            // 检查目标位置上是否有其他车辆
            bool isOtherCarsOnTarget = CheckOtherCarsOnTarget(targetX, targetY);//可能不需要

            // 检查路径上是否有其他车辆
            bool isOtherCarsOnPath = CheckCarsOnPath(cars[j].x, cars[j].y, targetX, targetY, j);

            //int isimpedecar=findimpedecar(targetX, targetY,j);

            if (!isOtherCarsOnTarget && !isOtherCarsOnPath)
            {
                // 如果目标位置上没有其他车辆，并且路径上也没有其他车辆，选择策略1
                result[0] = minTime;
                result[1] = 1;
            }
            else
            {
                // 如果目标位置上有其他车辆，或者路径上有其他车辆，选择其他策略
                double[] otherStrategiesResult = CalculateOtherStrategies(targetX, targetY, j);
                if (otherStrategiesResult[0] <= result[0])
                {
                    result = otherStrategiesResult;
                }
            }

            return result;
        }

        public double CalculateMinTime(double targetX, double targetY, int j)
        {
            // 在这里实现计算车辆到达指定位置所需的最短时间的逻辑
            // 我们假设车辆的速度是恒定的，所以最短时间就是距离除以速度
            if (j != -1)
            {
                double distance = CalculateDistance(cars[j].x, cars[j].y, targetX, targetY);
                return distance / cars[j].v;
            }
            return -1;

        }

        public double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            // 使用曼哈顿距离公式计算两点之间的距离
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
        public bool CheckCarsOnPath(double startX, double startY, double targetX, double targetY, int j)
        {
            //这个函数还不完善

            // 在这里实现检查路径上是否有其他车辆的逻辑
            // 这个函数的实现可能需要用到更复杂的算法，如线段与矩形的交点检测
            // 为了简化问题，这里我们假设如果任何车辆的位置在起点和终点之间，那么就认为它在路径上
            for (int i = 0; i < num; i++)
            {
                if (i == j || !cars[i].or2)
                {
                    continue;
                }
                else
                {
                    if ((cars[i].x >= Math.Min(startX, targetX) && cars[i].x <= Math.Max(startX, targetX)) &&
                   (cars[i].y >= Math.Min(startY, targetY) && cars[i].y <= Math.Max(startY, targetY)))
                    {
                        // 如果有车辆在起点和终点之间，返回 true
                        return true;
                    }
                }
            }
            // 如果没有车辆在起点和终点之间，返回 false
            return false;
        }


        public double[] CalculateOtherStrategies(double targetX, double targetY, int j)
        {
            // 在这里实现选择其他策略的逻辑
            // 我们需要计算每种策略的时间，并选择最短的那个
            double[] result = { double.MaxValue, 0, -1, 0, 0 };//策略所需总时间  方案序号  堵路车下标   堵路车装车时间  堵路车直接出库时间
            double[] time = { double.MaxValue, -1, 0, 0 }; ;
            for (int i = 2; i <= 4; i++)
            {
                switch (i)
                {
                    /*   case 2:
                           time = Case2(targetX, targetY, j);
                           break;
                       case 3:
                           time = Case3(targetX, targetY, j);
                           break;*/
                    case 4:
                        time = case4(targetX, targetY, j);
                        break;
                }
                if (time[0] < result[0])
                {
                    result[0] = time[0];
                    result[1] = i;
                    result[2] = time[1];
                    result[3] = time[2];
                    result[4] = time[3];
                }
            }
            return result;
        }
        public double Case1(double targetX, double targetY, int j)
        {
            return CalculateMinTime(targetX, targetY, j);

        }
        public double Case2(double targetX, double targetY, int j)
        {
            //不直接走，挡路车去空道路给目标车辆让路，时间包括等待时间和行驶时间（在挡路车运行的时候其实目标车可以向路口靠近）
            int impedecar = findimpedecar(targetX, targetY, j);//找到挡路车辆
            if (impedecar == 1)
            {
                return double.MaxValue;
            }
            bool[] road = findemptyroad();//找到空路
            double distance, waitTime2 = 0, waitTime1 = 0;
            //计算各种情况所需等待时间
            /*if (road[0])
            {
                distance = CalculateDistance(impedecar.x, impedecar.y, wc.c + wc.e / 2, wc.d - impedecar.length);
                waitTime2 = distance / impedecar.v+(Math.Abs(impedecar.x-wc.c)+ Math.Abs(impedecar.y - wc.d))/impedecar.v;
            }*/
            if (road[1])
            {
                distance = CalculateDistance(cars[impedecar].x, cars[impedecar].y, wc.c + wc.e / 2, wc.d + cars[impedecar].length + wc.e);
                waitTime2 = distance / cars[impedecar].v + (Math.Abs(cars[impedecar].x - wc.c) + Math.Abs(cars[impedecar].y - wc.d)) / cars[impedecar].v;
            }
            if (road[2])
            {
                distance = CalculateDistance(cars[impedecar].x, cars[impedecar].y, wc.c - cars[impedecar].length, wc.d + wc.e / 2);
                waitTime2 = distance / cars[impedecar].v + (Math.Abs(cars[impedecar].x - wc.c) + Math.Abs(cars[impedecar].y - wc.d)) / cars[impedecar].v;
            }
            if (road[3])
            {
                distance = CalculateDistance(cars[impedecar].x, cars[impedecar].y, wc.c + wc.e + cars[impedecar].length, wc.d + wc.e / 2);
                waitTime2 = distance / cars[impedecar].v + (Math.Abs(cars[impedecar].x - wc.c) + Math.Abs(cars[impedecar].y - wc.d)) / cars[impedecar].v;
            }
            if (cars[impedecar].OR)
            {
                waitTime1 = cars[impedecar].t;
            }
            // 计算行驶时间
            //double waitTime = CalculateWaitTime(targetX, targetY);
            double driveTime = CalculateMinTime(targetX, targetY, j);
            return waitTime2 + waitTime1 + driveTime;
        }

        public double Case3(double targetX, double targetY, int j)
        {
            //不直接走，目标车辆让挡路车，时间包括目标车辆去空道路的时间+挡路车到1号路口时间+目标车到目标点时间
            //等待时间固定且为挡路车完全进入道路1的时间
            double driveTime1 = 0, driveTime2 = 0, waitTime1 = 0, distance, extraDriveTime, waitTime2;
            int impedecar = findimpedecar(targetX, targetY, j);
            if (impedecar == -1)
            {
                return double.MaxValue;
            }
            bool[] road = findemptyroad();
            distance = CalculateDistance(cars[impedecar].x, cars[impedecar].y, wc.c + wc.e / 2, wc.d - cars[impedecar].length);
            waitTime2 = distance / cars[impedecar].v;
            if (road[0])
            {
                distance = CalculateDistance(wc.c + wc.e / 2, wc.d - cars[impedecar].length, targetX, targetY);
                driveTime1 = CalculateMinTime(wc.c + wc.e / 2, wc.d - cars[impedecar].length, j);
                driveTime2 = distance / cars[impedecar].v;
            }
            else
            {
                double maxIT = double.MaxValue;
                double TFO = 0;
                foreach (car c in cars)
                {
                    int i = 0;
                    if (c.OnRoad(wc) == 0)
                    {
                        if (c.OR)
                            maxIT = Math.Min(maxIT, c.t);
                        TFO = CalculateMinTime(wc.c, 0, i);
                    }
                    i++;
                }
            }
            if (road[1])
            {
                distance = CalculateDistance(wc.c + wc.e / 2, wc.d + cars[impedecar].length + wc.e, targetX, targetY);
                driveTime1 = CalculateMinTime(wc.c + wc.e / 2, wc.d + cars[impedecar].length + wc.e, j);
                driveTime2 = distance / cars[impedecar].v;
            }
            if (road[2])
            {
                distance = CalculateDistance(wc.c - cars[impedecar].length, wc.d + wc.e / 2, targetX, targetY);
                driveTime1 = CalculateMinTime(wc.c - cars[impedecar].length, wc.d + wc.e / 2, j);
                driveTime2 = distance / cars[impedecar].v;
            }
            if (road[3])
            {
                distance = CalculateDistance(wc.c + wc.e + cars[impedecar].length, wc.d + wc.e / 2, targetX, targetY);
                driveTime1 = CalculateMinTime(wc.c + wc.e + cars[impedecar].length, wc.d + wc.e / 2, j);
                driveTime2 = distance / cars[impedecar].v;
            }
            if (cars[impedecar].OR)
            {
                waitTime1 = cars[impedecar].t;
            }
            extraDriveTime = driveTime1 + driveTime2 + waitTime2 + waitTime1;
            return extraDriveTime;
        }
        public double[] case4(double targetX, double targetY, int j)
        {
            //哈—哈！ 爷不进啦！！
            double[] rst = { double.MaxValue, -1, 0, 0, };//总时间   堵路车下标  堵路车装车时间  堵路车直接出库时间
            int impedecar = findimpedecar(targetX, targetY, j);
            if (impedecar == -1)
            {
                return rst;
            }
            else
            {
                rst[1] = impedecar;
                rst[2] = cars[impedecar].t;
                rst[3] = CalculateMinTime(wc.c + wc.e / 2, 0, impedecar);
                rst[0] = rst[2] + rst[3] + CalculateMinTime(targetX, targetY, impedecar);
                return rst;
            }

        }
        public double useACarT(int j)
        {
            double t = cars[j].t;
            cars[j].t = 0;
            cars[j].OR = false;
            return t;
        }
        public double ECGO()
        {
            for (int i = 0; i < num; i++)
            {
                if (cars[i].t == 0 && cars[i].OR && cars[i].or2)
                {
                    return ECIGO(i);
                }
            }
            return 0;
        }
        public double ECIGO(int i)
        {
            if (cars[i].OR && cars[i].or2)
            {
                int ic = findimpedecar(wc.c + wc.e / 2, 0, i);
                if (ic != -1)
                {
                    TimeFlow(cars[ic].t);
                    return CalculateMinTime(wc.c + wc.e / 2, 0, i) - CalculateMinTime(wc.c + wc.e / 2, 0, ic) + ECIGO(ic);
                }
                else
                {
                    double t = cars[i].t;
                    cars[i].x = wc.c + wc.e / 2;
                    cars[i].y = 0;
                    cars[i].OR = false;
                    cars[i].or2 = false;
                    cars[i].t = 0;
                    TimeFlow(CalculateMinTime(wc.c + wc.e / 2, 0, i));
                    return CalculateMinTime(wc.c + wc.e / 2, 0, i) + t;
                }
            }
            else
                return 0;
        }


        public int findimpedecar(double targetX, double targetY, int j)//j目标车辆下标
        {
            for (int i = 0; i < num; i++)
            {
                if (i == j || !cars[i].or2)
                {
                    continue;
                }
                if ((cars[i].x >= Math.Min(cars[j].x, targetX) && cars[i].x <= Math.Max(cars[j].x, targetX)) &&
                   (cars[i].y >= Math.Min(cars[j].y, targetY) && cars[i].y <= Math.Max(cars[j].y, targetY)))
                {
                    // 如果有车辆在起点和终点之间，返回 true
                    return i;
                }
            }
            return -1;
            // 如果没有车辆在起点和终点之间，返回 false
        }

        public bool[] findemptyroad()//可能有毛病
        {
            bool[] rst = { true, true, true, true };
            bool one = true, two = true, three = true, four = true;
            for (int i = 0; i < num; i++)
            {
                if (cars[i].x == wc.c + wc.e / 2 && cars[i].y < wc.d)
                {
                    one = false;
                }
                if (cars[i].x == wc.c + wc.e / 2 && cars[i].y >= wc.d + wc.e)
                {
                    two = false;
                }
                if (cars[i].x <= wc.c && cars[i].y == wc.d + wc.e / 2)
                {
                    three = false;
                }
                if (cars[i].x >= wc.c + wc.e && cars[i].y == wc.d + wc.e / 2)
                {
                    four = false;
                }
            }

            if (two)
                rst[1] = true;
            if (three)
                rst[2] = true;
            if (four)
                rst[3] = true;
            if (one)
                rst[0] = true;
            return rst;
        }

        public int FCar()//找空车
        {
            for (int i = 0; i < num; i++)
            {
                if (!cars[i].or2)
                {
                    return i;
                }
            }
            return -1;
        }
        public int FCar(double x, double y)//找指定位置的车
        {
            for (int i = 0; i < num; i++)
            {
                if (cars[i].x == x && cars[i].y == y)
                {
                    return i;
                }
            }
            return -1;
        }
        public double TimeFlow()
        {
            //检测到所有车都在装车使用，让最先要出去的那个出去
            double t = cars[0].t;

            int i;
            int l = 0;
            double t2 = CalculateMinTime(wc.c + wc.e / 2, 0, l);
            double t3 = 0;
            for (i = 1; i < this.num; i++)
            {
                if (t > cars[i].t && cars[i].OR && cars[i].or2)
                {
                    t = cars[i].t;//找到最短时间
                    l = i;
                }
            }
            int ic = findimpedecar(wc.c + wc.e / 2, 0, l);
            if (ic == -1)
            {
                cars[l].t = 1e20;
                cars[l].OR = false;
                cars[l].or2 = false;
                cars[l].x = wc.c + wc.e / 2;
                cars[l].y = 0;
                for (i = 0; i < num; i++)
                {
                    if (cars[i].OR && cars[i].or2)//只考虑库里装车的车
                    {
                        if (cars[i].t > t + t2)//时间很长的就减去就行
                        {
                            cars[i].t -= (t + t2);
                        }
                        else//不够就也得开始出;先算了；得改；待优化；
                        {
                            cars[i].t = 0;
                        }
                    }
                }
            }
            else
            {
                t = cars[ic].t;
                cars[l].t = 1e20;
                cars[l].OR = false;
                cars[l].or2 = false;
                cars[l].x = wc.c + wc.e / 2;
                cars[l].y = 0;
                cars[ic].t = 1e20;
                cars[ic].OR = false;
                cars[ic].or2 = false;
                cars[ic].x = wc.c + wc.e / 2;
                cars[ic].y = 0;
                for (i = 0; i < num; i++)
                {
                    if (cars[i].OR && cars[i].or2)//只考虑库里装车的车
                    {
                        if (cars[i].t > t + t2)//时间很长的就减去就行
                        {
                            cars[i].t -= (t + t2);
                        }
                        else//不够就也得开始出;先算了；得改；待优化；
                        {
                            cars[i].t = 0;
                            t3 = CalculateMinTime(wc.c + wc.e / 2, 0, i);
                        }
                    }
                }

            }


            return t + t2 + t3;
        }
        public void TimeFlow(double t, int n, WareHouseCalculator wc)
        {
            //传入最小的装车时间
            //计算出库所需时间
            double t2 = CalculateMinTime(wc.c, 0, n);
            //减去该减去的
            for (int i = 0; i < num; i++)
            {
                if (i != n && cars[i].t > t + t2 && cars[i].OR)
                {
                    cars[i].t -= (t + t2);
                }
            }
            cars[n].GetOut();
        }
        public void TimeFlow(double t, int n)
        {
            //传入就位所需的时间
            //减去该减去的
            for (int i = 0; i < num; i++)
            {
                if (i != n && cars[i].t > t && cars[i].OR && cars[i].or2)//如果其他车在装车并且时间多于就位
                {
                    cars[i].t -= t;
                }
                else if (i != n && cars[i].t < t && cars[i].OR && cars[i].or2)//如果装车时间少于就位时间
                {
                    double t2 = CalculateMinTime(wc.c, 0, n);
                    if (cars[i].t + t2 <= t)
                    {
                        cars[i].t = 0;
                        cars[i].OR = false;
                        cars[i].or2 = false;
                    }
                }
            }
        }
        public void TimeFlow(double t)
        {
            for (int i = 0; i < num; i++)
            {
                if (cars[i].t > t && cars[i].OR && cars[i].or2)
                {
                    cars[i].t -= t;
                }
            }
        }


    }

    //定义吊运
    public class DYZJ
    {
        WareHouseCalculator wc;
        public double x;
        public double y;//坐标，很熟悉了
        public bool OR;//有货没？
        public double v;//速度
        public DYZJ(WareHouseCalculator wc, double x, double y, bool oR)
        {
            this.wc = wc;
            this.x = x;
            this.y = y;
            OR = oR;
            this.v = wc.v1;
        }
        public DYZJ()
        {
            wc = new WareHouseCalculator();
            x = 0; y = 0;
            OR = false;
            v = wc.v1;
        }
        public DYZJ(WareHouseCalculator w)
        {
            wc = w;
            x = 0; y = 0;
            OR = false;
            v = wc.v1;
        }
        public double Time(double x, double y)
        {

            return (Math.Abs(this.x - x) + Math.Abs(this.y - y)) / v;//移动到目标位置所需时间
        }
        public double CalculateCraneToCargoDistance((double x, double y) coordinate)
        {
            // 在这里实现计算吊车到货物的最短距离的逻辑
            // 返回计算得到的距离
            //实质还是x坐标的差的绝对值加上y坐标的差的绝对值——王淳

            return Math.Abs(this.x - coordinate.x) + Math.Abs(this.y - y);
        }
        //吊运似乎没什么花里胡哨的了
    }

    public static double[] TimeInNeed(Cars cs, DYZJ dyzj, double x1, double y1, double x2, double y2)
    {
        //两个坐标，前一个为货物坐标，后一个为目标点（装车点）坐标
        //时间为车就位时间与货物就位时间

        //调用 TINFC 函数计算车辆就位所需的时间

        //double[] TFC = TINFC(cs, x2, y2);
        int tCar = cs.FCar();

        double[] TFC = cs.Time(x2, y2, tCar);



        //调用 TINFD 函数计算货物就位所需的时间

        double TFD = TINFD(dyzj, x1, y1, x2, y2);
        //返回方案序号，两个时间
        double[] result = { TFC[1], TFC[0], TFD, TFC[2], TFC[3], TFC[4], tCar };//case号  车时间 吊运时间  堵路车下标  堵路车装车时间 堵路车出库时间
        return result;


    }
    public static double TINFD(DYZJ d, double x1, double y1, double x2, double y2)
    {
        //吊运使货物就位需要的时间
        return d.Time(x1, y1) + (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) / d.v;
    }

    public static double[] TINFC(Cars cs, double x2, double y2)//1234
    {
        // 车就位需要的时间以及策略
        double[] result = new double[2];
        double minTime = double.MaxValue;
        int strategy = 0;

        // 遍历仓库中的其他车辆，计算车辆就位的时间
        for (int i = 0; i < cs.cars.Length; i++)
        {
            if (!cs.cars[i].or2 || cs.cars[i] == cs.cars[cs.FCar()])//1234
            {
                // 跳过车辆不在仓库里或是当前车辆本身
                continue;
            }

            // 计算当前车辆到目标位置 (x2, y2) 所需的时间
            double time = cs.cars[cs.FCar()].Time(x2, y2);

            // 检查是否有车辆阻拦了当前车辆的路径
            if (CheckCarsOnPath(cs, cs.cars[cs.FCar()].x, cs.cars[cs.FCar()].y, x2, y2))
            {
                // 在路径上有其他车辆阻拦，选择策略2或策略3
                double strategy2Time = cs.Case2(x2, y2, cs.FCar(cs.cars[cs.FCar()].x, cs.cars[cs.FCar()].y));
                double strategy3Time = cs.Case3(x2, y2, cs.FCar(cs.cars[cs.FCar()].x, cs.cars[cs.FCar()].y));

                if (strategy2Time < strategy3Time && strategy2Time < time)
                {
                    time = strategy2Time;
                    strategy = 2;
                }
                else if (strategy3Time < time)
                {
                    time = strategy3Time;
                    strategy = 3;
                }
            }

            if (time < minTime)
            {
                minTime = time;
            }
        }

        // 如果没有车辆阻拦当前车辆的路径，选择策略1
        if (minTime == double.MaxValue)
        {
            minTime = cs.Case1(x2, y2, cs.FCar());
            strategy = 1;
        }

        // 将计算得到的车就位时间和策略序号存储在结果数组中
        result[0] = minTime;
        result[1] = strategy;

        return result;
    }


    public static double[] FindTheFastest(double[] x2, double[] y2, Cars cs, DYZJ dyzj, Cargo_point[] cps)
    {
        //找到最快的那个方案，返回长度为7的一维数组，0 1表示货物坐标，2 3表示装车位置坐标，4表示车的具体方案序号，5表示车所需时间,6表示吊运所需时间  堵路车下标 堵路车装车时间 堵路车出库时间
        double[] TIN;
        double[] result = new double[10];
        result[5] = double.MaxValue;
        result[6] = double.MaxValue;
        for (int i = 0; i < cps.Length; i++)
        {
            if (cps[i].cargo_existed)
            {
                for (int j = 0; j < x2.Length; j++)
                {
                    //门口不许堵
                    if (y2[j] < 21)
                    {
                        continue;
                    }

                    //对于每一对货物坐标和装车位置坐标，计算总就位时间


                    TIN = TimeInNeed(cs, dyzj, cps[i].x, cps[i].y, x2[j], y2[j]);

                    //如果当前的总就位时间小于已知的最短时间，更新最短时间和对应的方案
                    if (Math.Max(result[5], result[6]) > Math.Max(TIN[1], TIN[2]))
                    {
                        result[0] = cps[i].x;
                        result[1] = cps[i].y;
                        result[2] = x2[j];
                        result[3] = y2[j];
                        result[4] = TIN[0];
                        result[5] = TIN[1];
                        result[6] = TIN[2];
                        result[7] = TIN[3];
                        result[8] = TIN[4];
                        result[9] = TIN[5];
                    }
                }
            }


        }
        return result;
    }
    public static bool CheckCarsOnPath(Cars cars, double startX, double startY, double targetX, double targetY)
    {
        // 假设 Cars 是一个包含所有车辆信息的类，并且包含所有车辆的数组 cars.cars

        // 遍历仓库中的其他车辆，检查是否有其他车辆阻挡了当前车辆的路径
        for (int i = 0; i < cars.cars.Length; i++)
        {
            // 跳过当前车辆本身
            if (cars.cars[i].x == startX && cars.cars[i].y == startY)
            {
                continue;
            }

            //这里Time函数没有办法正常调用，暂时没查出原因，之后看看改改
            // 计算当前车辆到目标位置的最短时间
            double timeToTarget = cars.cars[i].Time(targetX, targetY);

            // 计算当前车辆到目标位置所经过的路径/
            double pathDistance = CalculateDistance(cars.cars[i].x, cars.cars[i].y, targetX, targetY);

            // 假设车辆占据一个点的位置，所以只需要检查车辆的坐标是否在路径上
            if (pathDistance <= cars.cars[i].length / 2)
            {
                return true; // 车辆阻挡了路径
            }
        }

        return false; // 没有车辆阻挡路径//1234
    }


    //检查是不是所有该出的货物都已经出库
    public static bool c_check(Cargo_point[] cps)
    {
        for (int i = 0; i < cps.Length; i++)
        {
            if (cps[i].cargo_existed)
                return false;
        }
        return true;
    }
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        // 使用曼哈顿距离公式计算两点之间的距离
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
    }


    public static int FindTheCargo(Cargo_point[] cps, double x, double y)
    {
        for (int i = 0; i < cps.Length; i++)
        {
            if (cps[i].x == x && cps[i].y == y)
            {
                return i;
            }
        }
        return -1;
    }
    public static void init()
    {
        //初始化基本的东西
        WareHouseCalculator wc = new WareHouseCalculator();
        Cars cars = new Cars(wc);
        DYZJ dyzj = new DYZJ(wc);
        List<(double x, double y)> list_cargo = wc.CalculateCoordinates();
        Cargo_point[] cargo_points = wc.initCP();
        List<(double x, double y)> ccc = wc.CalculateCCC();

        double t = 0;


        double[] x1 = new double[list_cargo.Count];
        double[] y1 = new double[list_cargo.Count];
        List<double> x2 = new List<double>();
        List<double> y2 = new List<double>();
        for (int i = 0; i < ccc.Count; i++)
        {
            x2.Add(ccc[i].x);
            y2.Add(ccc[i].y);
        }

        /*for (int i = 0; i < list_cargo.Count; i++)
        {
            x1[i] = (list_cargo[i].x);
            y1[i] = (list_cargo[i].y);
            //c,d,e改为初始化后的.e、.c和.d

            y2.Add(wc.d + wc.e / 2); // 插入对应的 y2 值
            x2.Add(list_cargo[i].x);
            x2.Add(wc.c + wc.e / 2); // 插入对应的 x2 值
            y2.Add(list_cargo[i].y);

        }*/

        //开始运货
        double[] rst = FindTheFastest(x2.ToArray(), y2.ToArray(), cars, dyzj, cargo_points);
        update1(rst, ref cargo_points, ref cars, ref dyzj, ref wc, ref t);

        while (!c_check(cargo_points))//一个检查该出的货有没有出的TRUE or FALSE。目前只考虑全部出库的话，直接检查所有货物。未来替换。
        {

            rst = FindTheFastest(x2.ToArray(), y2.ToArray(), cars, dyzj, cargo_points);
            EXETF(rst, ref cargo_points, ref cars, ref dyzj, ref wc, ref t);

        }
        Console.WriteLine("完事了,总用时为" + t + "s");


    }
    public static void update1(double[] TF, ref Cargo_point[] cps, ref Cars cs, ref DYZJ dyzj, ref WareHouseCalculator wc, ref double t)
    {

        //货物不在了
        int m = FindTheCargo(cps, TF[0], TF[1]);
        cps[m].cargo_existed = false;
        //堵路车离开
        if (TF[7] != -1)
        {
            cs.cars[(int)TF[7]].t = 0;
            cs.cars[(int)TF[7]].or2 = false;
            cs.cars[(int)TF[7]].OR = false;
            cs.cars[(int)TF[7]].x = wc.c + wc.e / 2;
            cs.cars[(int)TF[7]].y = 0;

            t += TF[8] + TF[9];
        }

        //那个车去装车了,其他车装车所需时间（有的话）减去那个车的就位所需时间
        m = cs.FCar();//找到那个车
        if (m != -1)
        {
            //其他空车可以再利用这个时间去就位，暂时空置
        }
        else//没有空车
        {
            t += cs.TimeFlow();//所有车辆 装车所需时间 减去 最小的 装车所需时间.总时间加上这个时间
        }
        //方案得出了，车去，货去

        //更新车的信息  放到一个函数里比较好
        cs.cars[m].x = TF[2];
        cs.cars[m].y = TF[3];//坐标
        cs.cars[m].t = wc.t2;//装车时间
        cs.cars[m].OR = true;//装车中
        cs.cars[m].or2 = true;//在库里

        t += TF[5];
        cs.TimeFlow(TF[5], m);
        t += Math.Max(0, TF[6] - TF[5]);
        cs.TimeFlow(Math.Max(0, TF[6] - TF[5]));

        //吊运装具
        dyzj.x = TF[2];
        dyzj.y = TF[3];
        dyzj.OR = false;
        //
        //Console.Write("当前总时间" + t);
        int tCar = cs.FCar();
        if (tCar == -1)
        {

            t += cs.TimeFlow();
        }
        t += cs.ECGO();
    }



    public static void update(double[] TF, ref Cargo_point[] cps, ref Cars cs, ref DYZJ dyzj, ref WareHouseCalculator wc, ref double t)
    {
        //更新,每次车与吊运均就位的时候更新
        //更新车，存放货物点，吊运装具的相关属性 、、、记号<-◑✔▃✘◐☚▆▌☞☛㏘未完成
        //需要计算各个属性的值并且拿来用
        //需要车就位时间，吊运就位时间，全局变量时间……
        //得先算

        //货物不在了
        int m = FindTheCargo(cps, TF[0], TF[1]);
        cps[m].cargo_existed = false;
        //那个车去装车了,其他车装车所需时间（有的话）减去那个车的就位所需时间
        cs.TimeFlow(TF[5], cs.FCar(TF[2], TF[3]), wc);
        //cs.TimeFlow(Math.Max(0, TF[6] - TF[5]));

        t += Math.Max(0, TF[6] - TF[5]);

        //吊运装具
        dyzj.x = TF[2];
        dyzj.y = TF[3];
        dyzj.OR = false;

        //
    }
    public static void writeFile(string tf, string fname)
    {
        try
        {
            if (!File.Exists(fname))
            {
                FileStream fs1 = new FileStream(fname, FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(tf);//开始写入值
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(fname, FileMode.Append, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(tf);//开始写入值
                sr.Close();
                fs.Close();
                Console.WriteLine(tf);

            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            //Console.WriteLine("搞定一次");
        }
    }

    public static void EXETF(double[] TF, ref Cargo_point[] cps, ref Cars cs, ref DYZJ dyzj, ref WareHouseCalculator wc, ref double t)
    {
        //执行方案
        update1(TF, ref cps, ref cs, ref dyzj, ref wc, ref t);
        //将本次出货的相关信息写入文件
        string tf = "";
        for (int i = 0; i < TF.Length; i++)
        {
            tf = tf + TF[i] + " ";
        }
        writeFile(tf, "方案.txt");
        //Console.Write(t+"\n");
        //……

    }

}
