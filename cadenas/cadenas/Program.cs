/*****************************************************************************************
                        Universidad Politecnica de San Luis Potosí
                        Ingeniería en Tecnologías de la Información

                        Materia:    Teoría Computacional
                        Profesor:   Juan Carlos González Ibarra
                        Nombre:     Guevara Silva Isaí Abimael
                        Matricula:  150056

               C# program that validate chars to alphabet {a-z} and digits {0-9}
*****************************************************************************************/
using System;
using System.Text.RegularExpressions;

namespace cadenas {
    class Program {
        static void Main(string[] args) {
            ConsoleKeyInfo cki;
            //Comienza ciclo para pedir caracteres
            do {
                //Limpia la consola
                Console.Clear();
                //Declaración del patrón de expresion regular
                string pattern = "[0-9a-z]";
                //instanciamos clase Regex incluida en librería
                Regex reg = new Regex(pattern);
                //Leer caracer por teclado
                Console.Write("Ingresa un caracter: ");
                //guarda el valor el la varible result
                bool result = reg.IsMatch(Console.ReadLine());
                //Si es true imprime Verdadero, de lo contrario escribe Falso
                if (result)
                    Console.WriteLine("Verdadero");
                else
                    Console.WriteLine("Falso");
                //Leer condiciona de ciclo
                Console.Write("\n\nPresiona Enter para repetir o Esc para terminar");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}