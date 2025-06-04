using Proj_FinacialLedger_202408039;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202408039
{
    public abstract class Financial
    {
        protected Dictionary<DateTime, Info> _incomes = new Dictionary<DateTime, Info>();
        protected Dictionary<DateTime, Info> _expenditures = new Dictionary<DateTime, Info>();

        public int TotalIncome
        {
            get
            {
                int total = 0;
                foreach (var item in _incomes.Values)
                    total += item.Money;
                return total;
            }
        }

        public int TotalExpenditure
        {
            get
            {
                int total = 0;
                foreach (var item in _expenditures)
                {
                    total = total + item.Value.Money;
                }
                return total;
            }
        }

        public bool RegIncome(DateTime date, string content, int money)
        {
            if (money >= 0)
            {
                Info info = new Info(content, money);
                _incomes[date] = info;
                return true;
            }
            return false;
        }

        public bool RegIncome(string content, int money)
        {
            DateTime now = DateTime.Now;
            return RegIncome(now, content, money);
        }

        public bool RegExpenditure(DateTime date, string content, int money)
        {
            if (money >= 0)
            {
                Info info = new Info(content, money);
                _expenditures[date] = info;
                return true;
            }
            return false;
        }

        public bool RegExpenditure(string content, int money)
        {
            DateTime now = DateTime.Now;
            return RegExpenditure(now, content, money);
        }
    }
}
