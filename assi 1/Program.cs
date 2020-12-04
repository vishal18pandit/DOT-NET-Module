﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp("vipul", 14000, 20);
            Emp e1 = new Emp("vipul", 14000);
            Emp e2 = new Emp("vipul");
            Emp e3 = new Emp();


            Console.WriteLine(e.PEmpno);
            Console.WriteLine(e1.PEmpno);
            Console.WriteLine(e2.PEmpno);
            Console.WriteLine(e3.PEmpno);
            Console.ReadLine();
        }
    }

    public class Emp
    {
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
                    Console.WriteLine("Invalid name");
                    Console.ReadLine();
                }
            }
            get
            {
                return name;
            }
        }

        private static int count = 0;
        private int EmpNo = 0;
        public int PEmpno
        {
            set
            {
                EmpNo = value;
            }
            get
            {
                return EmpNo;
            }
        }


        private decimal Basic;
        public decimal Pbasic
        {
            set
            {
                if (value > 10000 && value < 25000)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid Basic");
                    Console.ReadLine();
                }
            }
            get
            {
                return Basic;
            }
        }
        private short deptNo;
        public short Pdept
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Dept Number");
                    Console.ReadLine();
                }
            }
            get
            {
                return deptNo;
            }
        }

        public Emp(string name = null, decimal basic = 11000, short deptId = 1)
        {
            Emp.count++;
            EmpNo = Emp.count;
            Pname = name;
            Pbasic = basic;
            Pdept = deptId;
        }
    }
}
