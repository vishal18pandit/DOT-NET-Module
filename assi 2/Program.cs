﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmemt2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Manager("amit", 3, "tech manager", 2000);
            Employee e2 = new GeneralManager("vijay", 3, "CEO", "bhaiya ji", 5000);
            Employee e3 = new CEO("karan", 5, 100000);
            Console.WriteLine(e3.CalacNetSalary());
            Console.WriteLine(e2.CalacNetSalary());

            Console.WriteLine(e1.CalacNetSalary());

            Console.ReadLine();

        }
    }

    public abstract class Employee
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private static int lastEmpNo = 0;

        private int empNo;

        public int Empno
        {
            get { return empNo; }
            private set
            {
                empNo = value;
            }
        }

        private short deptNo;

        public short DeptNo
        {
            get
            {
                return deptNo;
            }

            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("department number should be greater than 0");
                }
            }
        }

        public Employee(string name = "noname", short deptNo = 1, decimal basic = 0)
        {
            empNo = ++lastEmpNo;
            this.name = name;
            this.deptNo = deptNo;
            this.basic = basic;
        }


        private decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }

        public abstract decimal CalacNetSalary();


    }

    public class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }

        private decimal basic;
        public override decimal Basic
        {
            get
            {

                return basic;
            }
            set
            {

                basic = value;
            }
        }

        public Manager(string name, short deptNo, string designation = "manager", decimal basic = 0) : base(name, deptNo)
        {

            this.basic = basic;
            this.designation = designation;

        }



        public override decimal CalacNetSalary()
        {

            return Basic;
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;

        public string Perks
        {
            get
            {
                return perks;
            }
            set
            {
                perks = value;
            }
        }
        private decimal basic;

        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        public GeneralManager(string name, short deptNo, string designation, string perks, decimal basic) : base(name, deptNo, designation)
        {
            this.basic = basic;
            this.perks = perks;
        }

        public override decimal CalacNetSalary()
        {
            return Basic;
        }


    }

    public class CEO : Employee
    {

        private decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        public override sealed decimal CalacNetSalary()
        {
            return basic;
        }

        public CEO(string name, short deptNo, decimal basic) : base(name, deptNo)
        {
            this.basic = basic;
        }
    }
}
