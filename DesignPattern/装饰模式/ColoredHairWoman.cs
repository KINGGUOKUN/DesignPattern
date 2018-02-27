using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰模式
{
    public class ColoredHairWoman : WomanDecorator
    {
        public ColoredHairWoman(Woman woman)
            : base(woman)
        {

        }

        public override void Describe()
        {
            Console.WriteLine("染了红色的头发");
            base.Describe();
        }
    }
}
