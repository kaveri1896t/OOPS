// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Commercial_Data_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Stack to store data
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// The maximum size
        /// </summary>
        private int maxSize;

        /// <summary>
        /// The stack array
        /// </summary>
        private string[] stackArray;

        /// <summary>
        /// The top
        /// </summary>
        private int top;

        /// <summary>
        /// Stacks the initialize.
        /// </summary>
        /// <param name="stackSize">Size of the stack.</param>
        public void StackInitialise(int stackSize)
        {
            try
            {
                this.maxSize = stackSize;
                this.stackArray = new string[this.maxSize];
                this.top = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <exception cref="Exception">Handles and throws Exception</exception>
        public void Push(string data)
        {
            try
            {
                this.top++; ////increasing top value after pushing each element
                this.stackArray[this.top] = data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns> returns the top element from the stack</returns>
        public string Pop()
        {
            try
            {
                ////decreasing top value after pushing each element
                return this.stackArray[this.top--];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>returns the top element</returns>
        public string Peek()
        {
            try
            {
                return this.stackArray[this.top]; //// returns the top most element in stack
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            try
            {
                return this.top == -1; //// if top value equals to -1,it means the stack is empty.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is full.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is full; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFull()
        {
            try
            {
                return this.top == this.maxSize - 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
