using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式
{
    public class Metro : ITransportation
    {
        public void Transport()
        {
            Console.WriteLine("地铁回家");
        }
    }
}
