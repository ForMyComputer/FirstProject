using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem
{
    public class Hello
    {
        List<IAnimal> animals = new List<IAnimal> { new Dog() };
        public void Run()
        {
            foreach (var animal in animals)
            {
                AnimalService test = new AnimalService(animal);
                test.ShowSkills();
            }
        }
    }
    public interface IAnimal
    {
        void Move();
        void Voice();
    }
    public class AnimalService
    {
        private readonly IAnimal _animal;
        public AnimalService(IAnimal animal)
        {
            _animal = animal;
        }
        public void ShowSkills()
        {
            _animal.Move();
            _animal.Voice();
        }
    }
    public class Dog : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Dog is running..");
        }
        public void Voice()
        {
            Console.WriteLine("Dog is running..");
        }
    }
}
