using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂模式
{
    public class SqlServerDatabase : Database
    {
        public override void ExecuteSql()
        {
            Console.WriteLine("SQLServer数据库执行SQL语句");
        }
    }
}
