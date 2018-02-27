using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂模式
{
    /// <summary>
    /// 单工厂
    /// </summary>
    public class DatabaseFactory
    {
        public static T CreateDatabase<T>()
            where T : Database, new()
        {
            return new T();
        }
    }
}
