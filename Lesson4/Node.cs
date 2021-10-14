using System;

public class Node
{
    int node;//поле узел n-e количество узлов;
    Node lnode;//левый узел;
    Node rnode;//правый узел;
    Node parent;
    Node target;
    public int Nnode { get { return node; } set { node = value; } }
    public Node Llnode { get { return lnode; } set { lnode = value; } }
    public Node Rrnode { get { return rnode; } set { rnode = value; } }
    public Node Parent { get { return parent; } set { parent = value; } }
    public Node Target { get { return target; } set { target = value; } }

    public Node()
    {

    }
    public static Node Tree(int n)
    {
        Node newNode = null;
        if (n == 0)
            return null;
        else
        {
            var lnode = n / 2;
            var rnode = n - lnode - 1;
            newNode = new Node();
            newNode.Nnode = new Random().Next(10);
            newNode.Llnode = Tree(lnode);
            newNode.Rrnode = Tree(rnode);
        }
        return newNode;
    }



    public static void PreOrderTravers(Node node)
    {
        if (node != null)

        {
            Console.WriteLine("{0}", node.Nnode);
            PreOrderTravers(node.Llnode);
            PreOrderTravers(node.Rrnode);

        }

    }
}
