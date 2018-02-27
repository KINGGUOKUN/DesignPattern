using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂模式
{
    public class MySqlDatabase : Database
    {
        public override void ExecuteSql()
        {
            Console.WriteLine("MySql数据库执行SQL语句");
        }
    }
}
