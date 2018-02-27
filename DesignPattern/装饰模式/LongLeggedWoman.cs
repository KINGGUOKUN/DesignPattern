using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰模式
{
    public class LongLeggedWoman : WomanDecorator
    {
        public LongLeggedWoman(Woman woman)
            : base(woman)
        {

        }

        public override void Describe()
        {
            Console.WriteLine("大长腿");
            base.Describe();
        }
    }
}
