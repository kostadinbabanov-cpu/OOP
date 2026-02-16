//test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        public  void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Cat : Animal
    {
        public  void AnimalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }
    }

    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Animal();
            Animal myCat = new Cat();
            Animal myDog = new Dog();

            myAnimal.AnimalSound();
            myCat.AnimalSound();
            myDog.AnimalSound();
        }
    }
}

