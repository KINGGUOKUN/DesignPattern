using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.建造者模式
{
    public class Entertainment
    {
        public Entertainment()
        {
            this.Activities = new List<Activity>();
        }

        public List<Activity> Activities { get; private set; }

        public void HaveFun()
        {
            foreach (var activity in this.Activities)
            {
                activity.Play();
            }
        }
    }
}
