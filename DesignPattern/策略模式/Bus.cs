using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式
{
    public class Bus : ITransportation
    {
        public void Transport()
        {
            Console.WriteLine("公交回家");
        }
    }
}
