using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class milestone2
    {
        public void LetrasRepetidas()
        {
            Console.WriteLine("Inserta el nº de lineas: ");
            string l = Console.ReadLine();
            int lineas = Convert.ToInt32(l);

            for(int i = 1; i <= lineas; i++)
            {
                for(int x = 1; x <= i; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Inserta el nº de lineas de la piramide de asteriscos: ");
            string a = Console.ReadLine();
            int altura = Convert.ToInt32(a);

            for (int i=altura;i>=1;i--)
            {
                for (int x=i;x>=1;x--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
