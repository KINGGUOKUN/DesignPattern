using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public abstract class Truck : Car
    {
        public Truck(string supplier)
            : base("卡车", supplier)
        {

        }
    }
}
