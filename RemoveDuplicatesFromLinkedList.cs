using System.Collections.Generic;
using System.Linq;

// O(n) time and O(1) space
public class RemoveDuplicatesFromLinkedList {
  // This is an input class. Do not edit.
  public class LinkedList {
    public int value;
    public LinkedList? next;

    public LinkedList(int value) {
      this.value = value;
      this.next = null;
    }
  }
  public LinkedList RemoveDuplicatesFromLinkedListMethod(LinkedList linkedList) {
    var current = linkedList;
    LinkedList? previous = null;
    while(current.next!=null)
    {
        if(previous==null||current.value!=previous.value)
            previous = current;
        else
            previous.next = current.next;
        current = current.next;
    }
    if(previous!=null&&current.value==previous.value)
        previous.next = null;
    return linkedList;
  }
}

// Problem statement

//   You're given the head of a Singly Linked List whose nodes are in sorted order
//   with respect to their values. Write a function that returns a modified version
//   of the Linked List that doesn't contain any nodes with duplicate values. The
//   Linked List should be modified in place (i.e., you shouldn't create a brand
//   new list), and the modified Linked List should still have its nodes sorted
//   with respect to their values.

//   Each LinkedList  node has an integer value  as well as a next  node pointing to the next node in the list or to
//   None if it's the tail of the list.

//   Test cases

//   Yay, your code passed all the test cases!

// 7 / 7 test cases passed.

// Test Case 1 passed!
// Expected Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "3", "value": 1},
//     {"id": "3", "next": "4", "value": 3},
//     {"id": "4", "next": "5", "value": 4},
//     {"id": "5", "next": "6", "value": 5},
//     {"id": "6", "next": null, "value": 6}
//   ]
// }
// Your Code's Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "3", "value": 1},
//     {"id": "3", "next": "4", "value": 3},
//     {"id": "4", "next": "5", "value": 4},
//     {"id": "5", "next": "6", "value": 5},
//     {"id": "6", "next": null, "value": 6}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "1",
//     "nodes": [
//       {"id": "1", "next": "1-2", "value": 1},
//       {"id": "1-2", "next": "1-3", "value": 1},
//       {"id": "1-3", "next": "2", "value": 1},
//       {"id": "2", "next": "3", "value": 3},
//       {"id": "3", "next": "3-2", "value": 4},
//       {"id": "3-2", "next": "3-3", "value": 4},
//       {"id": "3-3", "next": "4", "value": 4},
//       {"id": "4", "next": "5", "value": 5},
//       {"id": "5", "next": "5-2", "value": 6},
//       {"id": "5-2", "next": null, "value": 6}
//     ]
//   }
// }
// Test Case 2 passed!
// Expected Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "4", "value": 1},
//     {"id": "4", "next": "5", "value": 4},
//     {"id": "5", "next": "6", "value": 5},
//     {"id": "6", "next": null, "value": 6}
//   ]
// }
// Your Code's Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "4", "value": 1},
//     {"id": "4", "next": "5", "value": 4},
//     {"id": "5", "next": "6", "value": 5},
//     {"id": "6", "next": null, "value": 6}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "1",
//     "nodes": [
//       {"id": "1", "next": "1-2", "value": 1},
//       {"id": "1-2", "next": "1-3", "value": 1},
//       {"id": "1-3", "next": "1-4", "value": 1},
//       {"id": "1-4", "next": "1-5", "value": 1},
//       {"id": "1-5", "next": "4", "value": 1},
//       {"id": "4", "next": "4-2", "value": 4},
//       {"id": "4-2", "next": "5", "value": 4},
//       {"id": "5", "next": "6", "value": 5},
//       {"id": "6", "next": "6-2", "value": 6},
//       {"id": "6-2", "next": null, "value": 6}
//     ]
//   }
// }
// Test Case 3 passed!
// Expected Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": null, "value": 1}
//   ]
// }
// Your Code's Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": null, "value": 1}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "1",
//     "nodes": [
//       {"id": "1", "next": "1-2", "value": 1},
//       {"id": "1-2", "next": "1-3", "value": 1},
//       {"id": "1-3", "next": "1-4", "value": 1},
//       {"id": "1-4", "next": "1-5", "value": 1},
//       {"id": "1-5", "next": "1-6", "value": 1},
//       {"id": "1-6", "next": "1-7", "value": 1},
//       {"id": "1-7", "next": null, "value": 1}
//     ]
//   }
// }
// Test Case 4 passed!
// Expected Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "9", "value": 1},
//     {"id": "9", "next": "11", "value": 9},
//     {"id": "11", "next": "15", "value": 11},
//     {"id": "15", "next": "16", "value": 15},
//     {"id": "16", "next": "17", "value": 16},
//     {"id": "17", "next": null, "value": 17}
//   ]
// }
// Your Code's Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "9", "value": 1},
//     {"id": "9", "next": "11", "value": 9},
//     {"id": "11", "next": "15", "value": 11},
//     {"id": "15", "next": "16", "value": 15},
//     {"id": "16", "next": "17", "value": 16},
//     {"id": "17", "next": null, "value": 17}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "1",
//     "nodes": [
//       {"id": "1", "next": "9", "value": 1},
//       {"id": "9", "next": "11", "value": 9},
//       {"id": "11", "next": "15", "value": 11},
//       {"id": "15", "next": "15-2", "value": 15},
//       {"id": "15-2", "next": "16", "value": 15},
//       {"id": "16", "next": "17", "value": 16},
//       {"id": "17", "next": null, "value": 17}
//     ]
//   }
// }
// Test Case 5 passed!
// Expected Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": null, "value": 1}
//   ]
// }
// Your Code's Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": null, "value": 1}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "1",
//     "nodes": [
//       {"id": "1", "next": null, "value": 1}
//     ]
//   }
// }
// Test Case 6 passed!
// Expected Output
// {
//   "head": "-5",
//   "nodes": [
//     {"id": "-5", "next": "-1", "value": -5},
//     {"id": "-1", "next": "5", "value": -1},
//     {"id": "5", "next": "8", "value": 5},
//     {"id": "8", "next": "9", "value": 8},
//     {"id": "9", "next": "10", "value": 9},
//     {"id": "10", "next": "11", "value": 10},
//     {"id": "11", "next": null, "value": 11}
//   ]
// }
// Your Code's Output
// {
//   "head": "-5",
//   "nodes": [
//     {"id": "-5", "next": "-1", "value": -5},
//     {"id": "-1", "next": "5", "value": -1},
//     {"id": "5", "next": "8", "value": 5},
//     {"id": "8", "next": "9", "value": 8},
//     {"id": "9", "next": "10", "value": 9},
//     {"id": "10", "next": "11", "value": 10},
//     {"id": "11", "next": null, "value": 11}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "-5",
//     "nodes": [
//       {"id": "-5", "next": "-1", "value": -5},
//       {"id": "-1", "next": "-1-2", "value": -1},
//       {"id": "-1-2", "next": "-1-3", "value": -1},
//       {"id": "-1-3", "next": "5", "value": -1},
//       {"id": "5", "next": "5-2", "value": 5},
//       {"id": "5-2", "next": "5-3", "value": 5},
//       {"id": "5-3", "next": "8", "value": 5},
//       {"id": "8", "next": "8-2", "value": 8},
//       {"id": "8-2", "next": "9", "value": 8},
//       {"id": "9", "next": "10", "value": 9},
//       {"id": "10", "next": "11", "value": 10},
//       {"id": "11", "next": "11-2", "value": 11},
//       {"id": "11-2", "next": null, "value": 11}
//     ]
//   }
// }
// Test Case 7 passed!
// Expected Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "2", "value": 1},
//     {"id": "2", "next": "3", "value": 2},
//     {"id": "3", "next": "4", "value": 3},
//     {"id": "4", "next": "5", "value": 4},
//     {"id": "5", "next": "6", "value": 5},
//     {"id": "6", "next": "7", "value": 6},
//     {"id": "7", "next": "8", "value": 7},
//     {"id": "8", "next": "9", "value": 8},
//     {"id": "9", "next": "10", "value": 9},
//     {"id": "10", "next": "11", "value": 10},
//     {"id": "11", "next": "12", "value": 11},
//     {"id": "12", "next": null, "value": 12}
//   ]
// }
// Your Code's Output
// {
//   "head": "1",
//   "nodes": [
//     {"id": "1", "next": "2", "value": 1},
//     {"id": "2", "next": "3", "value": 2},
//     {"id": "3", "next": "4", "value": 3},
//     {"id": "4", "next": "5", "value": 4},
//     {"id": "5", "next": "6", "value": 5},
//     {"id": "6", "next": "7", "value": 6},
//     {"id": "7", "next": "8", "value": 7},
//     {"id": "8", "next": "9", "value": 8},
//     {"id": "9", "next": "10", "value": 9},
//     {"id": "10", "next": "11", "value": 10},
//     {"id": "11", "next": "12", "value": 11},
//     {"id": "12", "next": null, "value": 12}
//   ]
// }
// View Outputs Side By Side
// Input(s)
// {
//   "linkedList": {
//     "head": "1",
//     "nodes": [
//       {"id": "1", "next": "2", "value": 1},
//       {"id": "2", "next": "3", "value": 2},
//       {"id": "3", "next": "4", "value": 3},
//       {"id": "4", "next": "5", "value": 4},
//       {"id": "5", "next": "6", "value": 5},
//       {"id": "6", "next": "7", "value": 6},
//       {"id": "7", "next": "8", "value": 7},
//       {"id": "8", "next": "9", "value": 8},
//       {"id": "9", "next": "10", "value": 9},
//       {"id": "10", "next": "11", "value": 10},
//       {"id": "11", "next": "12", "value": 11},
//       {"id": "12", "next": "12-2", "value": 12},
//       {"id": "12-2", "next": null, "value": 12}
//     ]
//   }
// }