using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ////when we initialize a new objet its called instantiating(creating a new instance)
            ////an object needs to be instantiated before it can be used
            ////all objects of a specific type are created in the same template, this is called a class
            ////all objects from a class will have the same number and type of states but ...
            ////...each instance can have its own unique values.

            //// the format we use to instantiate an object looks like this:
            ////ClassName objectName = new ClassName();
            //Cat firstCat = new Cat();

            //firstCat.Name = "Mittens";
            ////Console.WriteLine(firstCat.Age);

            //Cat secondCat = new Cat("OZ", 3, "Orange and white");
            //secondCat.Name = "Ozzy";
            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat();
            //to create new object we use special method called constructor

            //thinking about objects in real life, create (either hand-write or type)..
            //..three examples of objects. your objects should have five states and five behaviors


            //superhero stuff

            Superhero firstHero = new Superhero();
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemises();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel); 

            //firstHero.BattleNemises();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            Superhero secondHero = new Superhero("The Origin Master");
            //Console.WriteLine(secondHero.StrengthLevel);

            //secondHero.AllyGained();
            //Console.WriteLine(secondHero.StrengthLevel);

            Superhero thirdHero = new Superhero("Black kevlar body armor", "The best ever", 1000, "Being the best", false);

            thirdHero.BattleNemises();
            Console.WriteLine("Oh no! Now my costume is " + thirdHero.Costume);
            Console.WriteLine("And my strength has deminished to " + thirdHero.StrengthLevel); 






        }
    }
}
