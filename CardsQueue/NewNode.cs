namespace Object_Oriented_Programming.CardsQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Node containing data part and link to next node
    /// </summary>
    public class NewNode<T>
    {
        /// <summary>
        /// The node data is data element of class 
        /// </summary>
        internal T NodeData;

        /// <summary>
        /// The Next is the pointer to the Next node
        /// </summary>
        internal NewNode<T> Next;
    }
}
