using Projeto1;
using System.Text.Json;

Console.WriteLine("Digite um valor pro cálculo fibonacci:");
int num = int.Parse(Console.ReadLine());
if (Fibonacci.CalculoFibonacci(num))
{
    Console.WriteLine("O número está presente na sequência Fibonacci");
}
else
{
    Console.WriteLine("O número não está presente na sequência Fibonacci");
}

Console.WriteLine("Digite algo a ser invertido:");
string palavra = Console.ReadLine();
string inv = Inverter.inversao(palavra);
Console.WriteLine("Aqui está a inversão do que você digitou: " + inv);

FaturamentoMensal.RetornaFaturamento();

FaturamentoDiario.RetornaFaturamento();