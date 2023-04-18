using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projeto1
{
    public class FaturamentoDiario
    {
        public static void RetornaFaturamento()
        {

            // Lê o arquivo JSON com os dados do faturamento mensal
            string caminho = @"dados.json";
            string json = File.ReadAllText(caminho);
            //dados faturamento = JsonConvert.DeserializeObject<dados>(json);
            List<dados> faturamento = JsonConvert.DeserializeObject<List<dados>>(json);
            double MaiorValor = 0;
            double MenorValor = double.MaxValue;
            double media = 0;
            int count = 0;

            foreach (var valores in faturamento) 
            {
                if (valores.valor != 0)
                {
                    if (valores.valor > MaiorValor)
                    {
                        MaiorValor = valores.valor;
                    }
                    if (MenorValor > valores.valor)
                    {
                        MenorValor = valores.valor;
                    }
                    if (valores.valor > 0)
                    {
                        media += valores.valor;
                        count++;
                    }
                }
            }

            media = media / count;
            count = 0;

            foreach (var valores in faturamento)
            {
                if (valores.valor > media)
                {
                    count++;
                }
            }

            // Imprime os resultados
              Console.WriteLine($"Menor faturamento: {Math.Round(MenorValor, 2)}");
              Console.WriteLine($"Maior faturamento: {Math.Round(MaiorValor, 2)}");
              Console.WriteLine($"Média de faturamento:{Math.Round(media, 2)}");
              Console.WriteLine($"Dias acima da média: {count}");
        }
        public class dados
        {
            public int dia { get; set; }
            public double valor { get; set; }

        }    
    }

}
