using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂模式
{
    public class OracleDatabase : Database
    {
        public override void ExecuteSql()
        {
            Console.WriteLine("Oracle数据库执行SQL语句");
        }
    }
}
