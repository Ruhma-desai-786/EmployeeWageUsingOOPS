﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageUsingOOPS
{
    public class RefactorClassMethod
    {
        public const int parttime = 1;
        public const int fulltime = 2;
        public const int absent = 0;
        public const int wageperhr = 20;
        public const int maxworkingdays = 20;
        public const int maxworkinghrs = 100;

        public int EmployeeWage()
        {
            int empwage = 0;
            int emphrs = 0;
            int totalwage = 0;
            int totalworkingdays = 0;
            int totalhrs = 0;
            while(totalhrs<=maxworkinghrs && totalworkingdays<maxworkingdays)
            {
                totalworkingdays++;
                Random random=new Random();
                int option= random.Next(1,3);
                switch(option)
                {
                    case parttime:
                        emphrs = 8;
                        break;
                    case fulltime:
                        emphrs = 16;
                        break;
                    case absent:
                        emphrs = 0;
                        break;
                }
                totalhrs += emphrs;
                Console.WriteLine("Day"+totalworkingdays+"--"+"Employee Hours"+emphrs);
                empwage=wageperhr*emphrs;
                totalwage += empwage;

            }
            Console.WriteLine("Total Employee Wage is--"+totalwage);
            return totalwage;
        }
    }
}
