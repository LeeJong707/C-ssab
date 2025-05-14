using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class CAT
    {
        private string _name;
        private int _level;
        private COLOR _color;


        public string Name { get { return _name; } }
        public COLOR color { get { return _color; } }
        public int Level { get { return _level; } }

        public CAT(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        public string Meow(int count)
        {
            string retValue = "";
            for (int i = 0; i < count; i++)
            {
                retValue += "냥!";
            }
            return retValue;
        }

        public void Eat() { AddLevel(3); }

        public void Play() { AddLevel(2); }

        private bool AddLevel(int level)
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
            return $"Cat:{_name}";
        }

    }
}
