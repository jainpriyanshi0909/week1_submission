namespace AnimalExercise
{
    interface IMovable
    {
        void Move();
    }
    public abstract class Animal : IMovable
    {
        protected string Name;
        protected int Age;
        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //public abstract void Move();
        public abstract void makeSound();
        public abstract void Move();
    }
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} Woof");
        }
        public override void Move()
        {
            Console.WriteLine("move Fast");
        }

    }
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} Meow");
        }
        public override void Move()
        {
            Console.WriteLine("move like cheetah");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Animal objects, add Dog and Cat instances, and call their methods Dog myPetDog = new Dog("puffy", 2);

            Dog myPetDog = new Dog("puffy", 2);
            Cat myPetCat = new Cat("lolo", 1);
            List<Animal> myPet = new List<Animal>();
            myPet.Add(myPetDog);
            myPet.Add(myPetCat);
            foreach (Animal animal in myPet)
            {   animal.makeSound();
                animal.Move();
            }

        }
    }
}