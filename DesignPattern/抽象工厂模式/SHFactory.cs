using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public class SHFactory : CarFactory
    {
        public override Car CreateGeep()
        {
            return new SHGeep();
        }

        public override Car CreateSuv()
        {
            return new SHSuv();
        }

        public override Car CreateTruck()
        {
            return new SHTruck();
        }
    }
}
