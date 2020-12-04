﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            emp e = new Manager("vishal", 10, 5000, "tech manager");
            Console.WriteLine(e.CalcNetSalary());
            Console.WriteLine(e.Pbasic);
            Console.WriteLine(e.Pempno);


            emp e1 = new Manager("", 1, 200);
            Console.WriteLine(e1.CalcNetSalary());
            Console.WriteLine(e1.Pempno);
            Console.ReadLine();

        }
    }
    public abstract class emp
    {
        public static int count = 0;
        private string name;
        public string Pname
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be blank");
                }
            }
            get
            {
                return name;
            }
        }

        private int empno;
        public int Pempno
        {
            get
            {
                return empno;
            }
        }

        private short deptNo;
        public short Pdeptno
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Dept no cannot be 0");
                }
            }
            get
            {
                return deptNo;
            }
        }

        public decimal basic;
        public abstract decimal Pbasic
        {
            get;
            set;
        }
        public emp(string name = "noName", short deptno = 1, decimal basic = 0)
        {
            empno = ++count;
            Pname = name;
            Pdeptno = deptno;
            Pbasic = basic;
        }

        public abstract decimal CalcNetSalary();
    }


    public class Manager : emp
    {

        private string designation;
        public string Pdes
        {
            set
            {
                if (designation != "")
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Invalid designation");
                }
            }
            get
            {
                return designation;
            }
        }

        public override decimal Pbasic
        {

            get
            {
                return basic;
            }
            set
            {
                if (basic < 1000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("invalid Basic in manager");
                }
            }
        }

        public Manager(string name = "", short deptNo = 0, decimal basic = 0, string designation = "manager") : base(name, deptNo, basic)
        {

            //this.basic = basic;
            this.designation = designation;

        }

        public override decimal CalcNetSalary()
        {
            return basic * 2;
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
        //private decimal basic;

        public override decimal Pbasic
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

        public GeneralManager(string name, short deptNo, decimal basic, string designation, string perks) : base(name, deptNo, basic, designation)
        {
           // this.basic = basic;
            this.perks = perks;
        }

        public override decimal CalcNetSalary()
        {
            return basic * 3;
        }


    }

    public class CEO : emp
    {

        //private decimal basic;
        public override decimal Pbasic
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

        public override sealed decimal CalcNetSalary()
        {
            return basic * 5;
        }

        public CEO(string name, short deptNo, decimal basic) : base(name, deptNo, basic)
        {
            //this.basic = basic;
        }
    }
}
