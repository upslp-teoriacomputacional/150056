/*****************************************************************************
                  Universidad Politecnica de San Luis Potosí
                  Ingeniería en Tecnologías de Información

                  Materia:    Teoría Computacional
                  Profesor:   Juan Carlos González Ibarra
                  Nombre:     Guevara Silva Isaí Abimael
                  Matricula:  150056

                     C# - Operaciones con Cadenas
*****************************************************************************/
using System;
using System.Globalization;

namespace lenguajes {
    class Program {
        static void Main(string[] args) {
            string singQuotes = "'C# in single quotes'";
            Console.WriteLine(singQuotes);

            string doubQuotes = "C# in double quotes";
            Console.WriteLine(doubQuotes);

            string message = "Hello, Python!";
            Console.WriteLine(message[7]);

            string Text = "PYTHON";
            //Imprimir 3er caracter
            Console.WriteLine(Text.Substring(3,1));

            //Imprimir 4to caracter comezando por el final
            Console.WriteLine(Text.Substring(Text.Length-4,1));

            //Imprimir 3 carateres a partir del 7mo
            Console.WriteLine(message.Substring(7, 3));

            //Quitar Espacios
            string message1 = "    Welcome C#.  ";
            Console.WriteLine(message1.TrimStart());

            //ToLower Method
            string message2 = "Welcome C#!";
            Console.WriteLine(message2.ToLower());

            //ToUpper Method
            string message3 = "C# tutorial with dotnettechpoint.com";
            Console.WriteLine(message3.ToUpper());
            //Length Method
            string message4 = "Welcome C#!    ";
            Console.WriteLine(Convert.ToString(message4.Length));

            //Replace Method
            string message5 = "C# with dotnettechpoint.com";
            Console.WriteLine(message5.Replace("C#","Learn C#"));

            //Split Method
            string message6 = "C#, tutorials, with, dotnettechpoint.com";
            char[] separator = {','};
            string[] words = message6.Split(separator);
            Console.Write("[ ");
            foreach (string word in words) {
                Console.Write("'{0}' ", word);
            }
            Console.WriteLine("]");

            //Title Method
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(message3.ToLower()));

            //Capitalize Method
            string message7 = "c# tutorial with dotnettechpoint.com";
            Console.WriteLine(char.ToUpper(message7[0]) + message7.Substring(1));

            //Count Method
            int ct = 0;
            for(int i=0; i<message7.Length; i++) {
                if (message7[i].Equals('t')) {
                    ct++;
                }
            }
            Console.WriteLine(ct);

            //Find Method
            Console.WriteLine(message7.IndexOf("with"));

            //Join Method
            string message8 = "C# Tutorials";
            for(int i=0; i<message8.Length; i++) {
                Console.Write(message7[i]+ " ");
            }

            string fString = "C#";
            string lString = "Tutorial";
            Console.WriteLine("\n"+fString + " " + lString);

            string first_string = "Python ";
            string middle_string = "3 ";
            string last_string = "Tutorial";
            Console.WriteLine(first_string + middle_string + last_string);

            string f_string = "Python ";
            int m_string = 3;
            string l_string = "Tutorial";
            Console.WriteLine(f_string + m_string + " " + l_string);

            Console.ReadKey();
        }
    }
}