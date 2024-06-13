    using System;

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Inheritance and Method Overriding:");
            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
            Console.WriteLine();
        }
    }
