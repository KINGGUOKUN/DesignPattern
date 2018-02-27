using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.单例模式
{
    public class Singleton
    {
        private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
        }

        public string InstanceId
        {
            get
            {
                return base.GetHashCode().ToString();
            }
        }

        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
