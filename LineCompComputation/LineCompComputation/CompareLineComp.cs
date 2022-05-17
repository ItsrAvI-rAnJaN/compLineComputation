using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompComputation
{
    internal class CompareLineComp
    {

    
        double Linelength1;
        double LineLength2;
    
        public void CompareLine()
        {
            Console.Write(" Please Enter The Point 1 Coordinate X1:- ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X2:- ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y1:- ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y2:- ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X3:- ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X4:- ");
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y3:- ");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y4:- ");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            double LengthLine1 = Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            Linelength1 = Math.Sqrt(LengthLine1);
            double LengthLine2 = Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2);
            LineLength2 = Math.Sqrt(LengthLine2);
            Console.WriteLine("length of Line1 is {0} & Length of line is {1} ", Linelength1, LineLength2);
            if (Linelength1.Equals(LengthLine2) == true)
            {
                Console.WriteLine("Both Lines having Equal Length");
            }
            else if (Linelength1.CompareTo(LineLength2) == 1)
            {
                Console.WriteLine("First Line of Length is Greater Than Second Line");
            }
            else if (Linelength1.CompareTo(LineLength2) == -1)
            {
                Console.WriteLine("Second Line of Length is Greater Than First Line");
            }
        }

    }
}
