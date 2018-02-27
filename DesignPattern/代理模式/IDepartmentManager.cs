using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    public interface IDepartmentManager
    {
        void Appove();

        void Apply();

        void Loan();
    }
}
