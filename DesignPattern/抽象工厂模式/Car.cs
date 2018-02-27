using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public abstract class Car
    {
        public Car(string carType, string supplier)
        {
            this.CarType = carType;
            this.Supplier = supplier;
        }

        /// <summary>
        /// 车类型（越野、轿车、卡车等）
        /// </summary>
        public string CarType { get; set; }

        /// <summary>
        /// 生产单位
        /// </summary>
        public string Supplier { get; set; }

        public void Run()
        {
            Console.WriteLine("{0}{1}在行驶...", this.Supplier, this.CarType);
        }
    }
}
