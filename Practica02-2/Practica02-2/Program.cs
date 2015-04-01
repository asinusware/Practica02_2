/*
 * PRACTICA 02-2 CRONOMETRO
 * DANIEL CEDILLO GUEVARA
 * PROGRAMACION III
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading;

namespace Practica02_2
{
    class Cronometro
    {
        private  DateTime tiempo;
        private const int resolucion = 10;
        private int x; //Columna en pantalla
        private int y; //Fila en pantalla
        public bool Iniciado;

        public Cronometro()
        {
            tiempo = new DateTime(0);
            Iniciado = false;
            x = 0;
            y = 0;
        }

        private void Mostrar()
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(tiempo.Minute.ToString("00") + ":" + tiempo.Second.ToString("00") + "." + (tiempo.Millisecond/resolucion).ToString("00"));
        }

        public void Iniciar()
        {
            Iniciado = true;
            x = Console.CursorLeft;
            y = Console.CursorTop;
            do
            {
                Mostrar();
                Thread.Sleep(10);
                tiempo = tiempo.AddMilliseconds(10);
            }
            while ((tiempo.Minute < 1) || Iniciado == false);
        }

    }

    public class AppCronometro
    {

        public static void Main()
        {
            Cronometro miCronometro = new Cronometro();
            DateTime sonda;

            Console.Clear();
            Console.WriteLine("Cronometro para consola. asinusware\u00a9 2015");
            Console.WriteLine("[I]niciar [D]etener [S]alir \n");
            sonda = DateTime.Now;
            Console.WriteLine("Cronometro inicia a: " + sonda.ToLongTimeString());
            Console.CursorVisible = false;
            miCronometro.Iniciar();
            sonda = DateTime.Now;
            Console.WriteLine("\nCronometro Termina a: " + sonda.ToLongTimeString() );
            Console.ReadLine();
        }
    }
}
