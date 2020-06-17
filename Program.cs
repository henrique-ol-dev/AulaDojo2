using System;

namespace AulaDojo2
{
    class Program
    {
        static void Main(string[] args)
        {
           IngressoVip seila = new IngressoVip();
           seila.IngressoPreco = 23.90f;
            seila.ImprimirValor();
            seila.AdicionarValor();

            System.Console.WriteLine("A diferença de valores é:" + seila.valorAdicional);
            
        }
    }
}
