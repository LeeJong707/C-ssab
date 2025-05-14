using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Dog : ANIMAL
    {
        //private string _name;
        //private int _level;
        //private new COLOR _color;
        private int _year;

        //private new COLOR _color;

        //public string Name { get { return _name; } }
        //public new COLOR color { get { return _color; } }
        //public int Level { get { return _level; } }
        public int Year { get { return _year; } }

        public Dog(string name, COLOR color, int year)
            //: base()//기본 base() 생성자
            :base(name, color)
        {
            //_name = name;
            //_color = color;
            _year = year;
        }
        protected override bool AddLevel(int level)
        {
            if (_level + level <= 100)
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 100;
                return false;
            }
        }


        public override string ToString()
        {
            return $"DOG:{base.Name}";
        }
        public string Bark(int count)
        {
            string retValue = "";
            for (int i = 0; i < count; i++)
            {
                retValue += "왈!";
            }
            return retValue;
        }

        //오버라이딩(재정의): 메소드
        public override void Eat() { AddLevel(30); }

        //하이딩: 변수, 프로퍼티, 메소드
        public new void Play() { AddLevel(20); }
    }
}
