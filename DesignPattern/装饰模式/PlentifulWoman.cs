using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰模式
{
    public class PlentifulWoman : WomanDecorator
    {
        public PlentifulWoman(Woman woman)
            : base(woman)
        {

        }

        public override void Describe()
        {
            Console.WriteLine("丰满");
            base.Describe();
        }
    }
}
