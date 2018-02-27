using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    public class Minister : IDepartmentManager
    {
        public void Appove()
        {
            Console.WriteLine("请求审批");
        }

        public void Apply()
        {
            Console.WriteLine("请假");
        }

        public void Loan()
        {
            Console.WriteLine("申请借款");
        }
    }
}
