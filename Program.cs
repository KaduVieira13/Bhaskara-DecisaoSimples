using System;

namespace Bhaskara_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA, valorB, valorC;
            double x1, x2, delta;
            bool convertido;


           
            Console.WriteLine(" --- Bhaskara --- \n");
            
            Console.Write("Digite o valor de a: ");
            convertido = Double.TryParse(Console.ReadLine(), out valorA);


            if (valorA != 0)
            {
                Console.Write("Digite o valor de b: ");
                convertido = Double.TryParse(Console.ReadLine(), out valorB);
                Console.Write("Digite o valor de c: ");
                convertido = Double.TryParse(Console.ReadLine(), out valorC);
                delta = Math.Pow(valorB,2) - (4 * valorA * valorC);

                if (delta > 0)
                {
                    double raiz = Math.Sqrt(delta);
                    Console.WriteLine ($"O valor de delta é: {delta} e sua raiz quadrada é: {raiz:N1} ");
                    x1= (((valorB * (-1)) + raiz) / (2 * valorA));

                    Console.WriteLine($"O valor de X1 é: {x1:N1}");
                    x2= (((valorB * (-1)) - raiz) / (2 * valorA));

                    Console.WriteLine($"O valor de X2 é: {x2:N1}");
                }
                else
                {
                    Console.WriteLine("Essa equação não possui raízes reais");
                }
            }
            else
            {
                Console.WriteLine("Essa equação não é de segundo grau");
            }

            
        }
    }
}
