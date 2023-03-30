//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            //int length = 100;
            int length = 100000;
            for (int i = 0; i <= length; i++)
            {
                Train train1 = new Train(i.ToString());
            }
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);
            /*
            tren en creacion: Last Train To London
            tren en creacion: Last Train To London
            tren en creacion: Runaway Train
            False
            False
            este console.writeline preguntando la igualdad retorna false ya que cada instancia es unica aunque tengan el mismo identificador.
            */
        }
    }
}