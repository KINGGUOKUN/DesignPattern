using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.建造者模式
{
    public class Sing : Activity
    {
        public override string Name
        {
            get { return "唱歌"; }
        }

        public override void Play()
        {
            Console.WriteLine("KTV唱歌喽...");
        }
    }
}
