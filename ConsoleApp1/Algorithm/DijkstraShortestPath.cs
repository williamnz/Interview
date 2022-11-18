using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithm
{
    public class DijkstraShortestPath
    {
        /// <summary>
        /// 顶点数量
        /// </summary>
        public int Vertice { get; set; }
        public DijkstraShortestPath(int vertice)
        {
            this.Vertice = vertice;
        }
        /// <summary>
        /// A utility function to find the
        /// vertex with minimum distance
        /// value, from the set of vertices
        /// not yet included in shortest
        /// path tree
        /// </summary>
        /// <param name="dist">the distance of the source to destination</param>
        /// <param name="sptSet">a set sptSet (shortest path tree set) that keeps track of vertices included in shortest path tree</param>
        /// <returns></returns>
        private int MinDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;
            for (int v = 0; v < Vertice; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        /// <summary>
        /// A utility function to print
        /// </summary>
        /// <param name="dist"></param>
        public void printSolution(int[] dist)
        {
            Console.Write("Vertex Distance "
                          + "from Source\n");
            for (int i = 0; i < Vertice; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }
        /// <summary>
        /// Function that implements Dijkstra's
        /// single source shortest path algorithm
        /// for a graph represented using adjacency
        /// matrix representation
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="src"></param>
        public void Dijkstra(int[,] graph, int src)
        {
            // The output array. dist[i]
            // will hold the shortest
            // distance from src to i
            int[] dist = new int[Vertice]; 

            // sptSet[i] will true if vertex
            // i is included in shortest path
            // tree or shortest distance from
            // src to i is finalized
            bool[] sptSet = new bool[Vertice];

            // Initialize all distances as
            // INFINITE and stpSet[] as false
            for (int i = 0; i < Vertice; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            // Distance of source vertex
            // from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < Vertice - 1; count++)
            {
                // Pick the minimum distance vertex
                // from the set of vertices not yet
                // processed. u is always equal to
                // src in first iteration.
                int u = MinDistance(dist, sptSet);

                // Mark the picked vertex as processed
                sptSet[u] = true;

                // Update dist value of the adjacent
                // vertices of the picked vertex.
                for (int v = 0; v < Vertice; v++)

                    // Update dist[v] only if is not in
                    // sptSet, there is an edge from u
                    // to v, and total weight of path
                    // from src to v through u is smaller
                    // than current value of dist[v]
                    if (!sptSet[v] && graph[u, v] != 0 &&
                         dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }

            // print the constructed distance array
            printSolution(dist);
        }

        // Driver Code
        public static void Main1()
        {
            /* Let us create the example 
            graph discussed above */
            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            DijkstraShortestPath t = new DijkstraShortestPath(graph.GetUpperBound(0));
            t.Dijkstra(graph, 0);
        }
    }
}
