// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList1.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.CardsQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Linked List 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList1<T>
    {
        /// <summary>
        /// The Head is pointing to the first node of the Linked List.
        /// </summary>
        internal NewNode<T> Head;

        /// <summary>
        /// The list is an instance of List
        /// </summary>
        internal List<T> list = new List<T>();

        /// <summary>
        /// Write to file 
        /// </summary>
        /// <returns>String containing Data each node of linked list</returns>
        public string FileWrite()
        {
            string outputString = null;
            try
            {
                NewNode<T> currentNode = this.Head;

                //// traversae till end
                while (currentNode != null)
                {
                    //// add node data into the string
                    outputString += currentNode.NodeData + "\n";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return outputString;
        }

        /// <summary>
        /// Adds the node at first into linked list.
        /// </summary>
        /// <param name="list1">The list1 is an instance of the Linked List.</param>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        /// <returns>updated list</returns>
        public LinkedList1<T> AddFirstIntoLinkedList(LinkedList1<T> list1, List<T> list, T data)
        {
            NewNode<T> newNode = new NewNode<T>();
            newNode.NodeData = data;
            newNode.Next = null;
            try
            {
                if (list1.Head == null)
                {
                    list1.Head = newNode;
                    return list1;
                }
                else
                {
                    newNode.Next = list1.Head;
                    list1.Head = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list1;
        }

        /// <summary>
        /// Adds the last node into linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="list1">The list1.</param>
        /// <param name="data">The data.</param>
        /// <returns>updated list</returns>
        public LinkedList1<T> AddLastIntoLinkedList(LinkedList1<T> list, List<T> list1, T data)
        {
            NewNode<T> newNode = new NewNode<T>();
            newNode.NodeData = data;
            newNode.Next = null;
            try
            {
                if (list.Head == null)
                {
                    list.Head = newNode;
                }
                else
                {
                    //// The current node is temporary node for traversing into Linked List
                    NewNode<T> currentNode = list.Head;

                    // Traverse till the end of the list....
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    // Add new node as the Next node to the last node.
                    currentNode.Next = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }
        
        /// <summary>
        /// Removes the first node from linked list.
        /// </summary>
        /// <returns>Removed Element</returns>
        public T RemoveFirstLinkedList()
        {
            NewNode<T> currentNode = this.Head;
            T data = this.Head.NodeData;
            try
            {
                //// check if required node is the Head node
                if (currentNode == this.Head)
                {
                    ////delete the Head
                    this.Head = currentNode.Next;
                    GC.Collect();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }

        /// <summary>
        /// Reads the data from linked list into list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>list containing node data</returns>
        public List<T> ReadIntoList(LinkedList1<T> list1)
        {
            NewNode<T> currentNode = this.Head;
            while (currentNode != null)
            {
                list.Add(currentNode.NodeData);
            }

            return list;
        }
    }
}
