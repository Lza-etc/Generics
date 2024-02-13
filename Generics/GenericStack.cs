using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericStack<T> where T : struct
    {
        readonly T[]  stack;
        private int top = 0;

        public GenericStack(int size)
        {
            stack = new T[size];
        }
        public void Push(T item)
        {
            if (IsFull())
                throw new InvalidOperationException("The stack is full.");

            if (!typeof(T).IsValueType)
                throw new InvalidOperationException("Only value types are allowed.");
            stack[top++] = item;
        }
        public void Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The stack is empty.");
            top--;
        }
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The stack is empty.");
            return stack[top-1];
        }
        public bool IsEmpty()
        {
            return top==0; 
        }
        public bool IsFull()
        {
            return top == stack.Length;
        }
    }
}
