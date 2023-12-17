using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node temp = new Node(val);
            if (First==null)
            {
                temp.Next = First;
                First = temp;
                return;
            }
            Node move = First;
            while(move.Next!= null)
            {
                move = move.Next;
            }
            move.Next = temp;  
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First==null)
            {
                Console.WriteLine("the linked list is empty");
                return;
            }
            if (First.Data==key)
            {
                First = First.Next;
                return;
            }
            Node currunt = First.Next;
            Node previose = First;
            while (currunt!=null)
            {
                if (currunt.Data==key)
                {
                    previose.Next = currunt.Next;
                    currunt.Next = null;
                    return;
                }
                previose = currunt;
                currunt= currunt.Next; 
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            if (other_list.First==null)
            {
                return;
            }
            if (First==null)
            {
                First = other_list.First;
                    return;
            }
            Node current = First;
            while (current.Next!=null)
            {
                current = current.Next;
            }
            current.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            if (First==null)
            {
                return;
            }
            Node prev=null;
            Node curr=First;
            Node next =null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            First = prev;
        }
    }
}
