using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.建造者模式
{
    public class EntertainmentBuilder
    {
        public Entertainment Build(List<Activity> activities)
        {
            var entertainment = new Entertainment();
            entertainment.Activities.AddRange(activities);

            return entertainment;
        }
    }
}
