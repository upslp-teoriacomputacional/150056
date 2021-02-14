/*****************************************************************************************
                        Universidad Politecnica de San Luis Potosí
                        Ingeniería en Tecnologías de Información

                        Materia:    Teoría Computacional
                        Profesor:   Juan Carlos González Ibarra
                        Nombre:     Guevara Silva Isaí Abimael
                        Matricula:  150056

                        C# program for validation of a graph
*****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos {
    class Program {
        static void Main(string[] args) {
            int nodo = 0;
            //Definición de grafo de 5 nodos
            CGrafo miGrafo = new CGrafo(5);

            //declaración del grafo cómo diccionario
            miGrafo.AdicionaArista('a', 'c');
            miGrafo.AdicionaArista('b', 'c');
            miGrafo.AdicionaArista('b', 'e');
            miGrafo.AdicionaArista('c', 'd');
            miGrafo.AdicionaArista('c', 'e');
            miGrafo.AdicionaArista('c', 'a');
            miGrafo.AdicionaArista('c', 'b');
            miGrafo.AdicionaArista('e', 'b');
            miGrafo.AdicionaArista('d', 'c');
            miGrafo.AdicionaArista('e', 'c');

            //Cambiar color de letra
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Impresión Grafo");
        }
    }
}