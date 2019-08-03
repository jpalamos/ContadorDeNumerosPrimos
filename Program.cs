using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorDeNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cPrimos;
            int divisor;
            int salirWhile;
            int contador = 0;
            int num = 1;

            Console.WriteLine("Cuantos números primos quiere contar");
            cPrimos = Convert.ToInt32(Console.ReadLine());
            while(contador < cPrimos){
                salirWhile = 0;
                divisor = 2;
                while ((divisor < num) && (salirWhile == 0)){
                    if((num % divisor) == 0) salirWhile = 1;
                    else divisor++;
                }
                if (salirWhile == 0) contador++;
                num++;
            }
            Console.WriteLine("\nEl primo número " + cPrimos + " está en la posición " + num);
            Console.ReadLine();
        }
    }
}
