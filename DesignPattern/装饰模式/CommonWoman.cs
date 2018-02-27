using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰模式
{
    public class CommonWoman : Woman
    {
        public override void Describe()
        {
            Console.WriteLine("长得普通");
        }
    }
}
