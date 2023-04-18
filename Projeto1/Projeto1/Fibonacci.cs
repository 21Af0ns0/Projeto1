using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Fibonacci
    {
        public static bool CalculoFibonacci(int num)
        {
            int n1 = 0, n2 = 1, n0;
            if (num == 0) { return true; }
            for (int i = 0; i​​​​​​​ < 100; i++)
            {
                n0 = n1;
                n1 = n2;
                n2 = n1 + n0;
                //Console.WriteLine("{0}", n2);
                if (num == n2) { return true; }
                else if (n2 > num) { return false; }
            }

            return false;

        }
    }
}
