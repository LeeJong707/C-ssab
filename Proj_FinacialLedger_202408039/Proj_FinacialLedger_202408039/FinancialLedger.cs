using Proj_FinacialLedger_202408039;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_12345678
{
    public class FinancialLedger : Financial
    {
        private int _year;
        private int _targetAmount;

        public int Year
        {
            get { return _year; }
        }

        public int TargetAmount
        {
            get { return _targetAmount; }
        }

        public bool IsBlack
        {
            get
            {
                int income = TotalIncome;
                int expend = TotalExpenditure;
                int result = income - expend;

                if (_targetAmount == 0)
                {
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (result >= _targetAmount)
                        return true;
                    else
                        return false;
                }
            }
        }

        // 생성자 1
        public FinancialLedger(int year)
        {
            _year = year;
            _targetAmount = 0;
        }

        // 생성자 2
        public FinancialLedger(int year, int targetAmount)
        {
            _year = year;
            _targetAmount = targetAmount;
        }

        // 수입 등록
        public new bool RegIncome(DateTime date, string content, int money)
        {
            if (date.Year == _year)
            {
                return base.RegIncome(date, content, money);
            }
            return false;
        }

        public new bool RegIncome(string content, int money)
        {
            if (DateTime.Now.Year == _year)
            {
                return base.RegIncome(content, money);
            }
            return false;
        }

        // 지출 등록
        public new bool RegExpenditure(DateTime date, string content, int money)
        {
            if (date.Year == _year)
            {
                return base.RegExpenditure(date, content, money);
            }
            return false;
        }

        public new bool RegExpenditure(string content, int money)
        {
            if (DateTime.Now.Year == _year)
            {
                return base.RegExpenditure(content, money);
            }
            return false;
        }
    }
}
