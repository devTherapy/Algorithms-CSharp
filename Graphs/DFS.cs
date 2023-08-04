namespace Graphs;
public class Node
{
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name) {
        this.name = name;
        }

    public List<string> DepthFirstSearch(List<string> array) {
      // Write your code here.
      array.Add(name);
      foreach (var child in children)
      {
        child.DepthFirstSearch(array);
      }
      return array;
    }

    public Node AddChild(string name) {
      Node child = new Node(name);
      children.Add(child);
      return this;
    }
}
