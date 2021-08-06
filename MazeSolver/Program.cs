using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
            int numJunctions;
            int End;
            int connectingJunctions;

            Console.WriteLine("How many Junctions are in the maze?");
            numJunctions = Convert.ToInt32(Console.ReadLine());
            End = numJunctions - 1;

            for (int i = 0; i < numJunctions; i++)
            {
                adj.Add(i, null);
            }

            for (int i = 0; i < numJunctions; i++)
            {
                Console.WriteLine("How many Junctions is Node "+ i+ " Connected to?");
                connectingJunctions = Convert.ToInt32(Console.ReadLine());
                List<int> temp = new List<int>();
                int next;
                for (int j = 0; j < connectingJunctions; j++)
                {
                    Console.WriteLine("Enter the junction being connected to: ");
                    next = Convert.ToInt32(Console.ReadLine());
                    temp.Add(next);
                }
                adj[i] = temp;
            }
            DFS(adj);

        }

        static List<int> DFS(Dictionary<int, List<int>> graph)
        {
            int toFind = graph.Count - 1;
            List<int> visited = new List<int>();
            MyStack<int> stackyStackStack= new MyStack<int>(graph.Count);
            bool found = false;
            int[] keys = graph.Keys.ToArray();

            visited.Add(keys[0]);
            stackyStackStack.Push(keys[0]);

            
            while(stackyStackStack.getTop() > 0 && !found)
            {
                
                int currentNode = stackyStackStack.Pop();
                if (currentNode == toFind)
                {
                    found = true;
                    
                }

                if (!visited.Contains(currentNode))
                {
                    visited.Add(currentNode);
                }

                for (int i = 0; i < graph[currentNode].Count; i++)
                {
                    if (!visited.Contains(graph[currentNode][i]))
                    {
                        stackyStackStack.Push(graph[currentNode][i]);
                        
                    }
                }
            }

            //return stackyStackStack;
            return visited;



        }


    }
}
