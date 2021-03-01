using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp.DataStructures.LinkedList
{
    public class SinglyLinkedListNode
    {
        public SinglyLinkedListNode next { get; set; }
        public string Data { get; set; }

        public SinglyLinkedListNode(string data)
        {
            Data = data;
            next = null;
        }
    }
}
