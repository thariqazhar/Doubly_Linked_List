using System;

namespace DoublyLinkedList
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
         * It consists of the information part and links to
         * its succeeding and preceding nodes
         * in terms of next and previous nodes.*/
        public int rollNumber;
        public string namme;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }
}