﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            new GeneralList().Run(57);
        }


        class GeneralList
        {
            const int LEN = 100;
            public ArrayList ListQ;
            int AddUpToNumber = 0;
            public void Run(int AddUpToNumber)

            {
                Random r = new Random();
                ListQ = new ArrayList();
                for (int i = 0; i < LEN; i++)
                {
                    ListQ.Add(r.Next(100));
                }
                this.findTwoNumbersThatAddUpTo();
            }

            public void findTwoNumbersThatAddUpTo()
            {
                foreach (int num1 in ListQ)
                {
                    int x, y;
                    x = num1;
                    foreach (int num2 in ListQ)
                    {
                        y = num2;
                        if (x + y == 57)
                        {
                            Console.WriteLine(" Numbers are: " + x + " " + y);
                        }
                    }


                }
                Console.ReadLine();
            }
        }
    }
}
