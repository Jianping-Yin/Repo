﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(i + 1+" ");
                    //Console.Write(' ');
                }

                Console.WriteLine();
            }
            

        }

    }
}
