using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.模板方法模式
{
    public class MyDaily : Daily
    {
        protected override void ComeToWork()
        {
            Console.WriteLine("乘坐公交、地铁去上班");
        }

        protected override void DoWork()
        {
            Console.WriteLine("Writing fucking code...");
        }

        protected override void GoHome()
        {
            Console.WriteLine("挤他妈的公交、地铁回家");
        }

        protected override void HaveBreakfest()
        {
            Console.WriteLine("吃萝卜、白菜或者昨天的剩菜...");
        }

        protected override void EveningActivies()
        {
            Console.WriteLine("看书、学习、写代码...");
        }
    }
}
