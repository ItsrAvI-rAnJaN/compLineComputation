﻿using System;

namespace LineCompComputation
{
     public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Line Comparision Computation");
           // LineCompComputation objLine = new LineCompComputation();
          //objLine.CalLineLength();
          //objLine.ChkLIneLEnEqorNot();
          CompareLineComp objCompLine =new CompareLineComp();
          objCompLine.CompareLine();
           Console.ReadKey();
        }
    }
}

