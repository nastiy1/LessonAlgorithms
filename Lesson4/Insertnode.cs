using System;
//Вставка//поиск
public class Insertnode: Node
{
    public Insertnode()
    {
    }


    public static Node getFreeNode(int value, Node parent)
    {
        Node tmp = new Node();
        tmp.Llnode = tmp.Rrnode = null;
        tmp.Nnode = value;
        tmp.Parent = parent;

        return tmp;
    }

    public static Node Insert(Node head, int value)
    {
        Node node = new Node();
        Node tmp = null;
        if (head == null)
        {
            head = getFreeNode(value, null);
            return head;
        }

        tmp = head;
        while (tmp != null)
        {
            if (value > tmp.Nnode)
            {
                if (tmp.Rrnode != null)
                {
                    tmp = tmp.Rrnode;
                    continue;
                }
                else
                {
                    tmp.Rrnode = getFreeNode(value, tmp);
                    return head;
                }
            }
            else if (value < tmp.Nnode)
            {
                if (tmp.Llnode != null)
                {
                    tmp = tmp.Llnode;
                    continue;
                }
                else
                {
                    tmp.Llnode = getFreeNode(value, tmp);
                    return head;
                }
            }
            else
            {
                throw new Exception("Wrong tree state");                  // Дерево построено неправильно
            }
        }
        return head;
    }


}
