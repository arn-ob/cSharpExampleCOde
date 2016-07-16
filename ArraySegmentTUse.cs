using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    class ArraySegmentTUse
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 5, 9, 7 };
            ArraySegment<int> segment = new ArraySegment<int>(arr,0,5);

            for (int i = segment.Offset; i < segment.Offset + segment.Count; i++)
            {
                Console.WriteLine(segment.Array[i]);
            }
            Console.ReadLine();
        }
    }
}
