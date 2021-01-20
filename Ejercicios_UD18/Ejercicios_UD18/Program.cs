using System;

namespace Ejercicios_UD18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que ejercicio quieres ejecutar?");

            Console.WriteLine("1 = Ejercicio 1");
            Console.WriteLine("2 = Ejercicio 2");
            Console.WriteLine("3 = Ejercicio 3");
            Console.WriteLine("4 = Ejercicio 4");
            Console.WriteLine("5 = Ejercicio 5");
            Console.WriteLine("6 = Ejercicio 6");
            Console.WriteLine("7 = Ejercicio 7");
            Console.WriteLine("8 = Ejercicio 8");
            Console.WriteLine("9 = Ejercicio 9");


            string ejercicio = Console.ReadLine();

            switch (ejercicio)
            {
                case "1":
                    Ejercicio1 ej1 = new Ejercicio1();
                    ej1.Ejercicio();
                    break;
                case "2":
                    Ejercicio2 ej2 = new Ejercicio2();
                    ej2.Ejercicio();
                    break;
                case "3":
                    Ejercicio3 ej3 = new Ejercicio3();
                    ej3.Ejercicio();
                    break;
                case "4":
                    Ejercicio4 ej4 = new Ejercicio4();
                    ej4.Ejercicio();
                    break;
                case "5":
                    Ejercicio5 ej5 = new Ejercicio5();
                    ej5.Ejercicio();
                    break;
                case "6":
                    Ejercicio6 ej6 = new Ejercicio6();
                    ej6.Ejercicio();
                    break;
                case "7":
                    Ejercicio7 ej7 = new Ejercicio7();
                    ej7.Ejercicio();
                    break;
                case "8":
                    Ejercicio8 ej8 = new Ejercicio8();
                    ej8.Ejercicio();
                    break;
                case "9":
                    Ejercicio9 ej9 = new Ejercicio9();
                    ej9.Ejercicio();
                    break;
            }
        }
    }
}
