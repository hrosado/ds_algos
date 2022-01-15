using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_App
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // + ----- + ----- +
            // |   3   |  null |
            // + ----- + ----- +
            Node first = new Node
            {
                Value = 3
            };
            // + ----- + ----- +  + ----- + ----- +
            // |	3  |  null +  |   5  |  null  |
            // + ----- + ----- +  + ----- + ----- +
            Node middle = new Node
            {
                Value = 5
            };
            // + ----- + ----- +  + ----- + ----- +
            // |	3  |  -----+->|   5  |  null  |
            // + ----- + ----- +  + ----- + ----- +
            first.Next = middle;

            // + ----- + ----- +  + ----- + ----- +  + ----- + ----- +
            // |	3  |  -----+->|   5  |  null  +  |   ?   |  null |
            // + ----- + ----- +  + ----- + ----- +  + ----- + ----- + 
            Node last = new Node
            {
                Value = 7
            };

            // + ----- + ----- +  + ----- + ----- +  + ----- + ----- +
            // |	3  |  -----+->|   5  |   ----+->||   7   |  null |
            // + ----- + ----- +  + ----- + ----- +  + ----- + ----- + 
            middle.Next = last;

            // Iterate over each node and print the value
            PrintList(first);
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
