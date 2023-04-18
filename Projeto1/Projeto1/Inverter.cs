using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Inverter
    {
       public static string inversao (string original)
        {
          
            

            string palavraInv = "";
            int qtd = original.Length;
            for (int i = qtd - 1; i >= 0; i--)
            {
                palavraInv += original[i];
            }

           return (palavraInv);
        }
    }
}
