using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.建造者模式
{
    public abstract class Activity
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// 进行活动
        /// </summary>
        public abstract void Play();
    }
}
