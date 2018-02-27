using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.模板方法模式
{
    public class BossDaily : Daily
    {
        protected override void ComeToWork()
        {
            Console.WriteLine("驾驶凯迪拉克去公司上班");
        }

        protected override void DoWork()
        {
            Console.WriteLine("开会，布置任务，喝茶，抱小蜜");
        }

        protected override void GoHome()
        {
            Console.WriteLine("驾驶凯迪拉克回家");
        }

        protected override void HaveBreakfest()
        {
            Console.WriteLine("吃人参、海鲜等山珍海味");
        }

        protected override void EveningActivies()
        {
            Console.WriteLine("健身、夜总会、无法描述之事...");
        }
    }
}
