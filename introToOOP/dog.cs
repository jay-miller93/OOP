using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class dog
    {
        //create a dog class
        //your dog class should have fields for hair lenght, height, running speed,and weight
        //your class should have the following behaviors:run, bark, potty, cuddle

        private string hairLength;
        private int height;
        private int runningSpeed;
        private string weight;
        private bool crap = true;

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public string Weight
        {
            get { return this.weight; }
        }
        //cunstructor
        public dog()
        {
            //this is my default cunstructor
            
        }
        public dog(string hairLength, int height, int runningSpeed, string weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        } 

        public int Run()
        {
            Console.WriteLine("Dog runs fast");
            RunningSpeed -= 1;
            return RunningSpeed;
        }

        public void Bark()
        {
            Console.WriteLine("Ruff Ruff Ruff!!");
        }

        public void Potty()
        {
            if (crap = true)
            {
                Console.WriteLine("Your dog just ruined your rug!");
            }
            else
            {
                Console.WriteLine("Your dog has to go!");
            }
        }

        public void Cuddle()
        {
            Console.WriteLine("Doggo is so sweet!");
        }
        

        
    }
}


