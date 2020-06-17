using System;
namespace AulaDojo2
{
    public class IngressoVip : Ingresso
    {
        public float valorAdicional = 50.0f;

        public void AdicionarValor(){
            float newValor = IngressoPreco + valorAdicional;

            System.Console.WriteLine("O valor VIP é: {0:c}", newValor);
            System.Console.ResetColor();
        }
    }
}