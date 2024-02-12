using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericStack<T> where T : struct
    {
        readonly List<T> stack = new();
        public void Push(T item)
        {
            if (!typeof(T).IsValueType)
                throw new InvalidOperationException("Only value types are allowed.");
            stack.Add(item);
        }
        public void Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The stack is empty.");
            stack.RemoveAt(stack.Count - 1);
        }
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The stack is empty.");
            return stack[^1];
        }
        public bool IsEmpty()
        {
            return stack.Count == 0; 
        }
    }
}
