using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class milestone1
    {
        public void LetrasRepetidas()
        {
            //FASE 1
            char[] Taula = {'G', 'e', 'r', 'a', 'r', '7', 'o' };

            for(int i = 0; i <= Taula.Length - 1; i++)
            {
                Console.Write(Taula[i]);
            }

            //FASE 2
            System.Collections.Generic.List<char> Lista = new System.Collections.Generic.List<char>();
            for (int i = 0; i <= Taula.Length - 1; i++)
            {
                Lista.Add(Taula[i]);
            }

            Console.WriteLine();

            for(int i = 0; i <= Lista.Count - 1; i++)
            {
                Console.Write(Lista[i]);
                if (char.IsDigit(Lista[i]))
                {
                    Console.WriteLine(". Los nombres de personas no contienen números.");
                }
                else { 
                    if ((Lista[i] == 'a') || (Lista[i] == 'e') || (Lista[i] == 'i') || (Lista[i] == 'o') || (Lista[i] == 'u'))
                    {
                        Console.WriteLine(". VOCAL.");
                    }
                    else
                    {
                        Console.WriteLine(". CONSONANTE.");
                    }

                }
            }

            //FASE3. No me acaba de salir. El próximo día te pregunto en clase

            Dictionary<char, int> Mapa = new Dictionary<char, int>();
            int busqueda;

            for (int i = 0; i <= Taula.Length - 1; i++)
            {
                char carac = Taula[i];
                

                try
                {
                    busqueda = Mapa[carac];

                    if (busqueda > 0)
                    {
                        Mapa[carac] = busqueda + 1;
                    }
                    else
                    {
                        Mapa.Add(carac, 1);
                    }
                }
                catch (KeyNotFoundException)
                {
                    
                }

                                
            }

            for(int i = 0; i <= Mapa.Count - 1; i++)
            {
                //Console.WriteLine(Mapa[1]);
                
            }

            //FASE 4

            char[] TaulaApellido = { 'A', 'g', 'u', 'i', 'l', 'a', 'r' };

            ArrayList TaulaFinal = new ArrayList();

            for(int i = 0; i <= Taula.Length - 1; i++)
            {
                TaulaFinal.Add(Taula[i]);
            }

            TaulaFinal.Add(" ");

            for (int i = 0; i <= TaulaApellido.Length - 1; i++)
            {
                TaulaFinal.Add(TaulaApellido[i]);
            }

            for(int i = 0; i <= TaulaFinal.Count - 1; i++)
            {
                Console.Write(TaulaFinal[i]);
            }
        }
    }
}
