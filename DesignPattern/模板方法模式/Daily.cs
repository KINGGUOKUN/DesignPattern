using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.模板方法模式
{
    public abstract class Daily
    {
        protected abstract void ComeToWork();

        protected abstract void DoWork();

        protected abstract void GoHome();

        protected abstract void HaveBreakfest();

        protected abstract void EveningActivies();

        public void Routine()
        {
            this.ComeToWork();
            this.DoWork();
            this.GoHome();
            this.HaveBreakfest();
            this.EveningActivies();
        }
    }
}
