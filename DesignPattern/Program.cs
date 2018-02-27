using DesignPattern.策略模式;
using DesignPattern.抽象工厂模式;
using DesignPattern.代理模式;
using DesignPattern.单例模式;
using DesignPattern.工厂模式;
using DesignPattern.建造者模式;
using DesignPattern.模板方法模式;
using DesignPattern.装饰模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单例测试

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("实例ID：{0}", Singleton.Instance.InstanceId);
            //}

            #endregion

            #region 工厂模式

            //Database database = DatabaseFactory.CreateDatabase<SqlServerDatabase>();
            //database.ExecuteSql();

            //database = DatabaseFactory.CreateDatabase<MySqlDatabase>();
            //database.ExecuteSql();

            //database = DatabaseFactory.CreateDatabase<OracleDatabase>();
            //database.ExecuteSql();

            #endregion

            #region 抽象工厂模式

            //CarFactory carFactory = new SHFactory();
            //Car car = carFactory.CreateGeep();
            //car.Run();
            //car = carFactory.CreateSuv();
            //car.Run();
            //car = carFactory.CreateTruck();
            //car.Run();

            //carFactory = new GZFactory();
            //car = carFactory.CreateGeep();
            //car.Run();
            //car = carFactory.CreateSuv();
            //car.Run();
            //car = carFactory.CreateTruck();
            //car.Run();

            #endregion

            #region 模板方法模式

            //Daily daily;

            //Console.WriteLine("我的日常：");
            //daily = new MyDaily();
            //daily.Routine();

            //Console.WriteLine("老板的日常：");
            //daily = new BossDaily();
            //daily.Routine();

            #endregion

            #region 代理模式

            //IDepartmentManager assistant = new DepartAssistant(new Minister());
            //assistant.Apply();
            //assistant.Appove();
            //assistant.Loan();

            #endregion

            #region 建造者模式

            //var maJiang = new MaJiang();
            //var pocker = new Pocker();
            //var sing = new Sing();

            //var entertainmentBuilder = new EntertainmentBuilder();

            //Console.WriteLine("张三娱乐：");
            //var zhangsanEntertainment = entertainmentBuilder.Build(new List<Activity> { maJiang, pocker });
            //zhangsanEntertainment.HaveFun();
            //Console.WriteLine();

            //Console.WriteLine("李四娱乐：");
            //var lisiEntertainment = entertainmentBuilder.Build(new List<Activity> { maJiang, sing });
            //lisiEntertainment.HaveFun();
            //Console.WriteLine();

            //Console.WriteLine("王五娱乐：");
            //var wangwuEntertainment = entertainmentBuilder.Build(new List<Activity> { sing });
            //wangwuEntertainment.HaveFun();
            //Console.WriteLine();

            //Console.WriteLine("赵六娱乐：");
            //var zhaoliuEntertainment = entertainmentBuilder.Build(new List<Activity> { maJiang, pocker, sing });
            //zhaoliuEntertainment.HaveFun();
            //Console.WriteLine();

            #endregion

            #region 装饰模式

            //Woman fengjie = new CommonWoman();
            //fengjie.Describe();

            //Woman liuyifei = new CommonWoman();
            //liuyifei = new ColoredHairWoman(liuyifei);
            //liuyifei = new LongLeggedWoman(liuyifei);
            //liuyifei = new PlentifulWoman(liuyifei);
            //liuyifei.Describe();

            #endregion

            #region 策略模式

            Console.WriteLine("我要回家：");

            GoHome homing = new GoHome(new Walking());
            homing.Transport();

            homing = new GoHome(new Bus());
            homing.Transport();

            homing = new GoHome(new Metro());
            homing.Transport();

            #endregion

            Console.Read();
        }
    }
}
