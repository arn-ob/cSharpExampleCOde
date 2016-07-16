using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace learnFormEvent
{
    public class LinkedListNode<T>
    {
        private T value;
        public LinkedListNode(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get { return value; } 
        }

        private LinkedListNode<T> next;

        public LinkedListNode<T> Next
        {
            get { return next; }
            internal set { next = value; }
        }

        private LinkedListNode<T> prev;

        public LinkedListNode<T> Prev
        {
            get { return prev; }
            internal set { prev = value; }
        }
    }
/// <summary>
/// Problem Here .... How to solve the problem ????
/// </summary>
/// <typeparam name="Problem"></typeparam>

    public class LinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T> first;
        public LinkedListNode<T> First
        {
            get { return first; }
        }


        private LinkedListNode<T> last;
        public LinkedListNode<T> Last
        {
            get { return last; }
        }



        public LinkedListNode<T> AddLast(T node)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(node);
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


        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = first;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
                
            }
        }
        /// <summary>
        /// What is the problem ?????? 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetIEnumerator()
        {
             return GetEnumerator();
        }
    }



    class LinkListWithGenerics
    {

        
        static void Main(){
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<string> list2 = new LinkedList<string>();

            list1.AddLast(1);
            list1.AddLast(2);

            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }


            list2.AddLast("Arnob");
            list2.AddLast("hy");

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

        }


    }
}
