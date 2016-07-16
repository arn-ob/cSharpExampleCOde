using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace learnFormEvent
{

    public class LinkedListNode
    {
        private object value;
        public LinkedListNode(object value)
        {
            this.value = value;
        }

        public object Value
        {
            get { return value; }
        }

        private LinkedListNode next;
        public LinkedListNode Next
        {
            get { return next; }
            internal set { next = value; }
        }

        private LinkedListNode prv;
        public LinkedListNode Prv
        {
            get { return prv; }
            internal set { prv = value; }
        }

    }



    public class LinkedList : IEnumerable
    {
        private LinkedListNode first;
        public LinkedListNode First
        {
            get { return first; }
        }

        private LinkedListNode last;
        public LinkedListNode Last
        {
            get { return last; }
        }

        public LinkedListNode AddList(object sender)
        {
            LinkedListNode newNode = new LinkedListNode(sender);
            if (first == null)
            {
                first = newNode;
                last = first;
                
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            return newNode;
        }

        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = first;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

    }


    class LinkListWithOutGenerics
    {
        static void Main()
        {
            LinkedList list1 = new LinkedList();
            list1.AddList(2);
            list1.AddList(6);
            list1.AddList(4);
            list1.AddList(10);

            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        
    }
}
