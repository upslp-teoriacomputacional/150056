using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos {
    class CGrafo {
        char[,] mAdyacencia;
        char[] indegree;
        int nodos;

        public CGrafo(int pNodos) {
            nodos = pNodos;

            //Instanciar matriz de adyacencia
            mAdyacencia = new char[nodos, nodos];

            //Instanciar arrelo indegree
            indegree = new char[nodos];
        }

        public void AdicionaArista(char pNodoInicio, char pNodoFinal) {
            mAdyacencia[pNodoInicio, pNodoFinal] = '1';
        }
    }
}