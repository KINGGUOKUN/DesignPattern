using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    public class DepartAssistant : IDepartmentManager
    {
        private readonly IDepartmentManager _minister;

        public DepartAssistant(IDepartmentManager minister)
        {
            _minister = minister;
        }

        public void Appove()
        {
            _minister.Appove();
        }

        public void Apply()
        {
            _minister.Apply();
        }

        public void Loan()
        {
            _minister.Loan();
        }
    }
}
