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
    //Se utiliza matriz de adyacencia para definición de grafo
    class CGrafo {
        int[,] mAdyacencia;
        int[] indegree;
        int nodos;

        public CGrafo(int pNodos) {
            nodos = pNodos;

            //Instanciar matriz de adyacencia
            mAdyacencia = new int[nodos, nodos];

            //Instanciar arrelo indegree
            indegree = new int[nodos];
        }

        public void AdicionaArista(int pNodoInicio, int pNodoFinal) {
            mAdyacencia[pNodoInicio, pNodoFinal] = 1;
        }
    }

    class Program {
        static void Main(string[] args) {
            int nodo = 0;

            CGrafo miGrafo = new CGrafo(10);

            miGrafo.AdicionaArista('a', 'c');
        }
    }
}