using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
	    int maior=0, menor, i=0, numero=0, tl=0 ;
            double n1, n2, n3, n4, soma;

             Console.Write("Digite o primeiro número: ");
             n1 = Convert.ToDouble(Console.ReadLine());
	         maior = n1;
             menor = n1;
	         i = 1;
       
             Console.Write("Digite o segundo número: ");
             n2 = Convert.ToDouble(Console.ReadLine());
	         maior = n2;
             menor = n2;
	     i = 1;

             Console.Write("Digite o terceiro número: ");
             n3 = Convert.ToDouble(Console.ReadLine());
	     maior = n3;
             menor = n3;
	     i = 1;

             Console.Write("Digite o quarto número: ");
             n4 = Convert.ToDouble(Console.ReadLine());
	     maior = n4;
             menor = n4;
	     i = 1;
	     

	     for(i = 2; i <= tl; i++)
             {
                Console.Write("Digite o "+i+" número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero < menor)
                {
                    menor = numero;
                }
                if(numero > maior)
                {
                    maior = numero;
                }
             }

	     Console.WriteLine("O maior número é:" + maior);
             Console.WriteLine("O menor número é:" + menor);
             
             soma = (n1 + n2+ n3 + n4);     

             double media = soma / 4;

             Console.WriteLine("SOMA: " + soma );
             Console.WriteLine("MEDIA: " + media);
             Console.ReadKey();
        }
    }
}