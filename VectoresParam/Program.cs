using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int Max = 10;
        static void Main(string[] args)
        {
            int[] x = new int[Max];
            leer(x);
            imprimir(x);

            if (metodo(5, x))
            Console.WriteLine("\nel numero 5 si existe");
            else
            Console.WriteLine("\nel valor NO existe");
            if (metodo1(10, x))
            Console.WriteLine("\nel numero 10 si existe");
            else
            Console.WriteLine("\nel valor no existe");
            Console.ReadKey();

        }
        
        public static void leer(int[] x)
        {
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine("\nIngresa el Elemento {0}", (i + 1));
                x[i] = Int32.Parse(Console.ReadLine());
             }

        }
        
    public static void imprimir(int[] x)
    {
        foreach (int num in x)
        {
            Console.WriteLine("\nElemento {0}", num);
        }
    }
        public static bool metodo(int numero, int[]x)
        {
            bool sw=false;
            foreach (int num in x)
            {
                if (numero == num)
                {
                    sw = true;
                    break;
                }
                
            }
            return sw;

        }
        public static bool metodo1(int numero, int[] x)
        {
            bool sw = false;
            int i = 0;
            while ( i<Max && sw==false)
            {
                if (x[i] == numero)
                {
                    sw = true;
                    
                }
                i++;
            }
            return sw;

        }

    }
}

