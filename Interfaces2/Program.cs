using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager
    {
        //başına public yazılmaz çünkü zaten default olarak public
        //unimplemented operation
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
    class ProjectManager
    {
        /*
        Bu şekilde iki ayrı fonksiyon yerine interface türünden parametre verilebilir
        public void AddCustomer(CustomerManager customerManager)
        {
            customerManager.Add();
        }
        public void AddEmployee(EmployeeManager employeeManager)
        {
            employeeManager.Add();
        }
        */
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
