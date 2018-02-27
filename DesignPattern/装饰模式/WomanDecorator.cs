using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰模式
{
    public abstract class WomanDecorator : Woman
    {
        protected Woman _woman;

        public WomanDecorator(Woman woman)
        {
            _woman = woman;
        }

        public override void Describe()
        {
            _woman.Describe();
        }
    }
}
