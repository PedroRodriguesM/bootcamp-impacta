using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            bool isAdulto = true;
            decimal valor = 10.55m;
            double valor2 = 10.55;
            char sigla = 'C';
            string estado = "Sao Paulo";

            var teste = "Teste";

            if (idade >= 18)
            {
                teste = "Maior de Idade";
            }
            else if(estado == "Sao Paulo")
            {
                teste = "Menor de idade";
            }

            Console.WriteLine(teste);

            switch (idade)
            {
                case 2:
                    teste = "Nenem";
                    break;
                case 18:
                    teste = "Crianca";
                    break;
                case 65:
                    teste = "Adulto";
                    break;
                default: 
                    teste = "Melhor idade";
                    break;

            }

        }
    }
}
