﻿using System;

public class Node:ILinkedList
{
	public int Value { get; set; }
	public Node NextNode { get; set; }
	public Node PrevNode { get; set; }


	public Node()
	{


	}

    public int GetCount()
    {
        throw new NotImplementedException();
    }

    public void AddNode(int value)
    {
        throw new NotImplementedException();
    }

    public void AddNodeAfter(Node node, int value)
    {
        throw new NotImplementedException();
    }

    public void RemoveNode(int index)
    {
        throw new NotImplementedException();
    }

    public void RemoveNode(Node node)
    {
        throw new NotImplementedException();
    }

    public Node FindNode(int searchValue)
    {
        throw new NotImplementedException();
    }
}

public interface ILinkedList 
{
	int GetCount(); // возвращает количество элементов в списке
	void AddNode(int value);  // добавляет новый элемент списка
	void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
	void RemoveNode(int index); // удаляет элемент по порядковому номеру
	void RemoveNode(Node node); // удаляет указанный элемент
	Node FindNode(int searchValue); // ищет элемент по его значению
 
}

