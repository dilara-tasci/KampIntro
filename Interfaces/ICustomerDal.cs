﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Dal -> data access layer
    interface ICustomerDal
    {
        //unimplemented operation
        void Add();
        void Update();
        void Delete();
    }
    //inherits - class ----------- implements - interface
    //java'nın aksine c#'da ikisi için de ":" kullanılır.
    class SqlServerCustomerDal : ICustomerDal
    {
        //Implemented operation
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
