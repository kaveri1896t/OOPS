namespace Object_Oriented_Programming.CardsQueue
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cards game using queue
    /// </summary>
    public class CardQueue<T>
    {
        /// <summary>
        /// The list is an integer instance of the Linked List
        /// </summary>
        private LinkedList1<T> list = new LinkedList1<T>();

        /// <summary>
        /// Insert elements into the queue.
        /// </summary>
        /// <param name="list1">The list1 is the list of element.</param>
        /// <param name="number">The number to be inserted into queue.</param>
        /// <returns>updated List</returns>
        public LinkedList1<T> EnQueue(List<T> list1, T number)
        {
            try
            {
                ////Add the data into the linked list
                this.list = this.list.AddLastIntoLinkedList(this.list, list1, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this.list;
        }

        /// <summary>
        /// Removes elements from the queue.
        /// </summary>
        /// <param name="list1">The list1 is the instance of the linked list.</param>
        /// <param name="list">The list is the list of elements.</param>
        /// <returns>updated linked list</returns>
        public LinkedList1<T> DeQueue(LinkedList1<T> list1, List<T> list)
        {
            try
            {
                T number;

                ////remove top element from the linked list
                number = list1.RemoveFirstLinkedList();

                //// add that removed node from 
                list1.AddFirstIntoLinkedList(list1, list, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list1;
        }
    }
}
