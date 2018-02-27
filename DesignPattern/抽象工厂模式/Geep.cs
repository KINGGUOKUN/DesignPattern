using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.抽象工厂模式
{
    public abstract class Geep : Car
    {
        public Geep(string supplier)
            : base("吉普", supplier)
        {
        }
    }
}
