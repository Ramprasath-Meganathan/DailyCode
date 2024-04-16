using System;
using System.Collections.Generic;

public class DepthFirstSearchPgm {
  // Do not edit the class below except
  // for the DepthFirstSearch method.
  // Feel free to add new properties
  // and methods to the class.
  public class Node {
    public string name;
    public List<Node> children = new List<Node>();

    public Node(string name) {
      this.name = name;
    }

 // space O(v+e) time O(v)
    public List<string> DepthFirstSearch(List<string> array) {
      array.Add(this.name);
      for(int i=0;i<children.Count; i++)
          children[i].DepthFirstSearch(array);
      return array;
    }

    public Node AddChild(string name) {
      Node child = new Node(name);
      children.Add(child);
      return this;
    }
  }
}
