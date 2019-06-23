using System;

namespace Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    //Multicast delegate
    //delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation opMax = CalculationService.Sum;
            double resultMax = opMax(a, b);
            Console.WriteLine("Max: " + resultMax);

            BinaryNumericOperation opSum = CalculationService.Sum;
            double resultSum = opSum(a, b);
            Console.WriteLine("Sum: " + resultSum);

            /*
            Com o método Square não funcionar pq a assinatura do delegate é diferente da assinatura do próprio Square. Qtde de parametros diferentes
            BinaryNumericOperation opSquare = CalculationService.Square;
            double resultSquare = opSquare(a);
            Console.WriteLine("Square: " + resultSquare);
            */

            /*Multicast Delegate guardando referência para duas funções:
            BinaryNumericOperation Op = CalculationService.ShowSum;
            Op += CalculationService.ShowMax;
            op.Invoke(a, b);
            */


            Console.ReadLine();
        }
    }
}
