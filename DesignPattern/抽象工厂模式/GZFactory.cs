using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public class GZFactory : CarFactory
    {
        public override Car CreateGeep()
        {
            return new GZGeep();
        }

        public override Car CreateSuv()
        {
            return new GZSuv();
        }

        public override Car CreateTruck()
        {
            return new GZTruck();
        }
    }
}
