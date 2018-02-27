using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public abstract class Suv : Car
    {
        public Suv(string supplier)
            : base("小轿车", supplier)
        {

        }
    }
}
