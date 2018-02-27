using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public abstract class CarFactory
    {
        public abstract Car CreateGeep();

        public abstract Car CreateSuv();

        public abstract Car CreateTruck();
    }
}
