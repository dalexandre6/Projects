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
            //Rate and Investment:
            double wacc = 0.35f;
            double inv1 = 30000f;
            double inv2 = 20000f;
            //NPV Project A:
            double[] projectA = new double[] { 25000f, 25000f, 30000f };
            double total1 = Financial.NPV(wacc, ref projectA);
            double NPVA = -inv1 + total1;
            
            //IRR ProjectB:
            double[] projectIRRA = new double[] { -30000f, 25000f, 25000f, 30000f };
            double irrA = Financial.IRR(ref projectIRRA);
            Console.WriteLine("This is the IRR for project a : {0} ", irrA);

            Console.WriteLine("******************************************************");
            //IRR B:
            double[] projectIRRB = new double[] { -20000F, 26000f, 28000f, 48000f };
            double irrB = Financial.IRR(ref projectIRRB);
            Console.WriteLine("This is the IRR for project a : {0} ", irrB);

            Console.WriteLine("******************************************************");

            //NPV Project B:
            double[] projectB = new double[] { 26000f, 28000f, 48000f };
            double total2 = Financial.NPV(wacc, ref projectB);
            double NPVB = -inv2 + total2;
            
            Console.WriteLine("This is the NPV for project A {0} : ", NPVA);
            Console.WriteLine("This is the NPV for project B {0} : ", NPVB);

            
        }
    }
}
