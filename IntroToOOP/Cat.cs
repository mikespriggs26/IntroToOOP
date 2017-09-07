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
        public int FurLength { get; set; }
        public string FurColor { get; set; }


        public Cat()
        {
            this.Name = "Mittens";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        

        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
         }

        public void Eat()
        {
            if(isHungry)
            {
                this.isHungry = false;
                Console.WriteLine("I'm stuffed.");

            }
            else if(!isHungry)
            {
                Console.WriteLine("I'm good. No food for me.");
            }
        }

        public void Run()
        {
            Console.WriteLine("I am running really fast!!");
            this.isHungry = true;
        }
        public void Meow()
        {
            Console.WriteLine("Meow, meow!");
        }
        public void LitterBox()
        {
            Console.WriteLine("I'll be in the litter box.");
        }
        public void Sleep()
        {
            Console.WriteLine("I'm sleeping.");
        }
        public void Talk()
        {
            Console.WriteLine("My name is {0}.", this.name);
        }


    }
}
