using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class FaturamentoMensal
    {
        public static void RetornaFaturamento()
        {

            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double OUTROS = 19849.53;

            double TOTAL = SP + RJ + MG + ES + OUTROS;

            double P_SP = (SP / TOTAL) * 100;
            double P_RJ = (RJ / TOTAL) * 100;
            double P_MG = (MG / TOTAL) * 100;
            double P_ES = (ES / TOTAL) * 100;
            double P_OUTROS = (OUTROS / TOTAL) * 100;


            Console.WriteLine("Percentual de representação de cada estado no faturamento mensal da distribuidora:");
            Console.WriteLine("SP: {0:f2}%", P_SP);
            Console.WriteLine("RJ: {0:f2}%", P_RJ);
            Console.WriteLine("MG: {0:f2}%", P_MG);
            Console.WriteLine("ES: {0:f2}%", P_ES);
            Console.WriteLine("Outros: {0:f2}%", P_OUTROS);
        }

    }
}
