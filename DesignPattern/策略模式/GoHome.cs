using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式
{
    public class GoHome
    {
        private ITransportation _transportation;

        public GoHome(ITransportation transportation)
        {
            _transportation = transportation;
        }

        public void Transport()
        {
            _transportation.Transport();
        }
    }
}
