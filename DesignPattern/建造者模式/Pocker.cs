using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.建造者模式
{
    public class Pocker : Activity
    {
        public override string Name
        {
            get { return "扎金花"; }
        }

        public override void Play()
        {
            Console.WriteLine("兄弟们，扎金花搞起！！！");
        }
    }
}
