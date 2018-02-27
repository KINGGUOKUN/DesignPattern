using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.建造者模式
{
    public class MaJiang : Activity
    {
        public override string Name
        {
            get { return "麻将"; }
        }

        public override void Play()
        {
            Console.WriteLine("开始打麻将...");
        }
    }
}
