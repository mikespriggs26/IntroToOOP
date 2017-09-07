using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private int hairLength;
        private int height;
        private int runningSpeed;
        private double weight;

        public int HairLength { get; set; }
        public int Height { get; set; }
        public int RunningSpeed { get; set; }
        public double Weight { get; set; }

        public Dog()
        {
            this.weight = 220d;
            this.height = 3;
            this.runningSpeed = 80;
            this.hairLength = 3;
        }
        public Dog(double weight, int height, int runningSpeed, int hairLength)
        {
            this.weight = weight;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.hairLength = hairLength;
        }

        public void Run()
        {
            Console.WriteLine("Let's go for a run.");
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
        public void Potty()
        {
            Console.WriteLine("Let me out");
        }
        public void Cuddle(string name)
        {
            Console.WriteLine("{0} and the dog are cuddling...the dog is the big spoon.", name);
        }
    }
}
