using System;
using System.Globalization;
//makes sum and avarage of real readead numbers
namespace RealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N;
            double[] A;


            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s =  Console.ReadLine().Split(' ');//para ser lido na mesma linha
            for (int i = 0; i<N; i++)// comaçando com o zero
            {
                A[i]= double.Parse(s[i], CultureInfo.InvariantCulture); //armazenando vetor A
            }
            for (int i=0; i<N; i++) { 
            Console.Write(A[i].ToString("F1",CultureInfo.InvariantCulture) + " ");//casas decimais
            }
            Console.WriteLine();

            double soma = 0.0;//para fazer a soma dos numeros
            for (int i=0; i<N; i++)
            {
                soma = soma + A[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
