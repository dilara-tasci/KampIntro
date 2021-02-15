using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }
    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("manager eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("manager salary");
        }

        public void Work()
        {
            Console.WriteLine("manager work");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("worker eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("worker salary");
        }

        public void Work()
        {
            Console.WriteLine("worker work");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("robot work");
        }
    }
}
