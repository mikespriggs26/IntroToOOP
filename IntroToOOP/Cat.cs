using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }
        public Cat()
        {
            this.Name = "Mittens";
        }

        public Cat(string name, string furColor, int furLength, int age, bool isMale)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            
        }


    }
}
