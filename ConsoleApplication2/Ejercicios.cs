using System;

namespace ConsoleApplication2
{
    public class Ejercicios
    {
        public  void ejercicio2()
        {
            Console.WriteLine("Ingrese un numero para hallar el area de un cuadrado");
            double numero =Convert.ToDouble(Console.ReadLine());
            double numeroAlCuadrado;
            numeroAlCuadrado=Math.Pow(numero,2);
            Console.WriteLine("El area del cuadrado con longitud {0} en cada lado es de {1} ",numero,numeroAlCuadrado);
        }
    }
}