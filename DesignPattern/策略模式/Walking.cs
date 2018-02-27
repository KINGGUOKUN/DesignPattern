using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式
{
    public class Walking : ITransportation
    {
        public void Transport()
        {
            Console.WriteLine("步行回家");
        }
    }
}
