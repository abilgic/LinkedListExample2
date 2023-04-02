using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample2
{
    public class LinkedListClass
    {
        public Node Top;
        public class Node
        {
            public int Data;
            public Node Next;
            public Node(int Data)
            {
                this.Data = Data;
            }
        }

        public Node Insert(int Data, Node Head)
        {
            if (Head == null)
            {
                Head = new Node(Data);
                return Head;

            }
            else
            {
                var current = Head;
                current.Next = Insert(Data, current.Next);
                return current;
            }
        }

        public Node Print(Node Head)
        {
            if (Head != null)
            {
                var current = Head;
                if (current == null)
                {

                    return Head;
                }
                else
                {
                    Console.Write(current.Data + " ");
                    current.Next = Print(current.Next);

                }


            }
            return Head;

        }

    }
}
