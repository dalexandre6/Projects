using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectValuation
{
    class Program
    {
        static void Main(string[] args)

        {

            double wacc = 0.35f;
            double inv1 = 30000f;
            double inv2 = 20000f;

            double[] projectA = new double[] { 25000f, 25000f, 30000f };
            double total1 = Financial.NPV(wacc, ref projectA);
            double NPVA = -inv1 + total1;

            double[] projectB = new double[] { 26000f, 28000f, 48000f };
            double total2 = Financial.NPV(wacc, ref projectB);
            double NPVB = -inv2 + total2;
            
            Console.WriteLine("This is the NPV for project A {0} : ", NPVA);
            Console.WriteLine("This is the NPV for project B {0} : ", NPVB);

            
        }
    }
}
