using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.LinkedList
{
    class SinglyLinkedList
    {
        public static Node Insert(Node head, int data)
        {
            //Complete this method
            Node node = head;// new Node(data);
            if (head == null)
                head = new Node(data);
            else
            {
                while (node.next != null)
                {
                    node = node.next;
                }

                node.next = new Node(data);
            }
            return head;
        }
    }
}
