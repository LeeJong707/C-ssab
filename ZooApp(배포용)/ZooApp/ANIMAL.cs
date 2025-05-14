using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class ANIMAL
    {
        private string _name;
        protected int _level;
        protected COLOR _color;


        public string Name { get { return _name; } }
        public COLOR color { get { return _color; } }
        public int Level { get { return _level; } }

        public ANIMAL(string name, COLOR color)
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

        public virtual void Eat() { AddLevel(3); }

        public void Play() { AddLevel(2); }

        abstract protected bool AddLevel(int level);
            

        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }

    }
}
