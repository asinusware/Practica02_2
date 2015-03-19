/*
 * PRACTICA 02-2 CRONOMETRO
 * DANIEL CEDILLO GUEVARA
 * PROGRAMACION III
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;

namespace Practica02_2
{
    public class AppCronometro
    {

        public static void Main()
        {
            DateTime tiempo = new DateTime(0);
            DateTime tiempo3;
            DateTime tiempo2 = DateTime.Now;
            do
            {
                Console.Clear();
                Console.WriteLine(tiempo.Minute.ToString() + ":" + tiempo.Second + "." + tiempo.Millisecond);
                Thread.Sleep(100);
                tiempo = tiempo.AddMilliseconds(100);
            }
            while (tiempo.Second < 30);
            tiempo3 = DateTime.Now;
            Console.WriteLine(tiempo2.ToLongTimeString() + " " + tiempo3.ToLongTimeString() );
            Console.ReadLine();
        }

        /*private static void avanzar(object source, ElapsedEventArgs e)
        {
            tiempo.AddMilliseconds(10);
            Console.WriteLine(tiempo.ToLongTimeString());
        }
        */
    }
}
