using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Tarea
{
    class milestone3
    {

        public void LetrasRepetidas()
        {
            int horas = 0;
            int minutos = 0;
            int segundos = 0;

            for (horas = 0; horas <= 23; horas++)
            {
                for (minutos = 0; minutos <= 59; minutos++)
                {
                    for (segundos = 0; segundos <= 59; segundos++)
                    {
                        Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
                        Thread.Sleep(1000);
                    }
                }
            }

        }
    }
}
