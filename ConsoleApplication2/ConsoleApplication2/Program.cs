﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            InputInt(array);
        }
        public static void InputInt(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++) 
            {
                Console.Write("A[{0}]= " , 1);
                string str = Console.ReadLine();
                Arr[i] = int.Parse(str);
            }
        }
    }
}
