using System;

// O(v+e) time O(v) space
public class CycleInGraphSolution1 {
  public bool CycleInGraph(int[][] edges) {
    int numberOfNodes = edges.Length;
    bool[] visited = new bool[numberOfNodes];
    bool[] currentlyInStack = new bool[numberOfNodes];
    Array.Fill(visited,false);
    Array.Fill(currentlyInStack,false);
    for(int node=0; node < numberOfNodes; node++)
    {
        if(visited[node])
            continue;
        bool containsCycle = isNodeInCycle(node, edges, visited, currentlyInStack);
        if(containsCycle)
            return true;
    }
    return false;
  }

 public bool isNodeInCycle(int node, int[][] edges, bool[] visited,
                          bool[] currentlyInStack)
 {
     visited[node] = true;
     currentlyInStack[node] = true;
     bool containsCycle = false;
     int[] neighbors = edges[node];
     foreach (var neighbor in neighbors)
     {
         if(!visited[neighbor])
         {
             containsCycle = isNodeInCycle(neighbor, edges, visited, currentlyInStack);
         }
         if(containsCycle)
         {
             return true;
         } else if (currentlyInStack[neighbor])
         {
             return true;
         }
     }
     currentlyInStack[node] = false;
     return false;
 }
}


// Problem statement
// You're given a list of representing an unweighted, directed
//   graph with at least one node. Write a function that returns a boolean
//   representing whether the given graph contains a cycle.

// For the purpose of this question, a cycle is defined as any number of
//   vertices, including just one vertex, that are connected in a closed chain. A
//   cycle can also be defined as a chain of at least one vertex in which the first
//   vertex is the same as the last.


//   The given list is what's called an adjacency list, and it represents a graph.
//   The number of vertices in the graph is equal to the length of edges, where each index in edges  contains vertex i
//   's outbound edges, in no
//   particular order. Each individual edge is represented by a positive integer
//   that denotes an index (a destination vertex) in the list that this vertex is
//   connected to. Note that these edges are directed, meaning that you can only
//   travel from a particular vertex to its destination, not the other way around
//   (unless the destination vertex itself has an outbound edge to the original
//   vertex).

//   Also note that this graph may contain self-loops. A self-loop is an edge that
//   has the same destination and origin; in other words, it's an edge that
//   connects a vertex to itself. For the purpose of this question, a self-loop is
//   considered a cycle.

//   For a more detailed explanation, please refer to the Conceptual Overview
//   section of this question's video explanation.
// Test cases
// Yay, your code passed all the test cases!

// 12 / 12 test cases passed.

// Test Case 1 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1, 3],
//     [2, 3, 4],
//     [0],
//     [],
//     [2, 5],
//     []
//   ]
// }
// Test Case 2 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1, 2],
//     [2],
//     []
//   ]
// }
// Test Case 3 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1, 2],
//     [2],
//     [1]
//   ]
// }
// Test Case 4 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1, 2],
//     [2],
//     [1, 3],
//     [3]
//   ]
// }
// Test Case 5 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [],
//     [0, 2],
//     [0, 3],
//     [0, 4],
//     [0, 5],
//     [0]
//   ]
// }
// Test Case 6 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [0]
//   ]
// }
// Test Case 7 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [8],
//     [0, 2],
//     [0, 3],
//     [0, 4],
//     [0, 5],
//     [0],
//     [7],
//     [8],
//     [6]
//   ]
// }
// Test Case 8 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1],
//     [2, 3, 4, 5, 6, 7],
//     [],
//     [2, 7],
//     [5],
//     [],
//     [4],
//     []
//   ]
// }
// Test Case 9 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1],
//     [2, 3, 4, 5, 6, 7],
//     [],
//     [2, 7],
//     [5],
//     [],
//     [4],
//     [0]
//   ]
// }
// Test Case 10 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [0],
//     [1]
//   ]
// }
// Test Case 11 passed!
// Expected Output
// false
// Your Code's Output
// false
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [1, 2],
//     [2],
//     []
//   ]
// }
// Test Case 12 passed!
// Expected Output
// true
// Your Code's Output
// true
// View Outputs Side By Side
// Input(s)
// {
//   "edges": [
//     [],
//     [0, 3],
//     [0],
//     [1, 2]
//   ]
// }