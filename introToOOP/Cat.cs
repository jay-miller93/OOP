using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class Cat
    {
        //inside of class we create a blueprint for our object
        //classes are tmplates in OOP that we use to create objects
        //always named in pascal case

        //on OOP there are 2 types of states:
        //Fields:variables that belong to a class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties:a mix between firld and method that allow controlled access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }
        //also have behaviors
        //methods:repeatable or reusable sections of code - actions
        //constructors:specialized methods that are used when instantiating an object
        //- allow us to contol a state of an object upon creation
        //-alows us to form any actions the object might need upon creation
        //-always share the name of the class
        public Cat()
        {
            //this is an example of a default cunstructor-takes no arguments or parameters
        }
        //can have as many sonstructors as you need as long as they each have a unique signature
        //by signature, i mean the parameters in the parentheses after cunstructor name
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        
        public void Eat()
        {
            if (isHungry)
                {
                isHungry = false;
                }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}

