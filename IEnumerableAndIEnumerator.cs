using System;
using System.Collections.Generic;

namespace IEnumerableAndIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");


            #region IEnumerable

            IEnumerable<string> iEnumerableOfString = Month;
            iEnumerableMethodOne(iEnumerableOfString);

            foreach (string AllMonths in iEnumerableOfString)
            {
                Console.WriteLine(AllMonths);
            }
            #endregion


            #region IEnumerator

            //IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator(); //to convert list into IEnumerator we can invoke the GetEnumerator method
            //iEnumeratorMethodOne(iEnumeratorOfString);

            //while(iEnumeratorOfString.MoveNext()) {
            //    Console.WriteLine(iEnumeratorOfString.Current);
            //}
            #endregion

            Console.ReadLine();

        }


        #region IEnumerable Method

        static void iEnumerableMethodOne(IEnumerable<string> i)
        {
            foreach (string s in i)
            {
                Console.WriteLine(s);
                if (s == "June")
                {
                    iEnumerableMethodTwo(i);
                }
            }
        }

        static void iEnumerableMethodTwo(IEnumerable<string> i)
        {
            foreach (string s in i)
            {
                Console.WriteLine(s);
            }
        }
        #endregion

        #region IEnumerator method

        //static void iEnumeratorMethodOne(IEnumerator<string> i) {
        //    while(i.MoveNext()) {
        //        Console.WriteLine(i.Current);
        //        if(i.Current == "June") {
        //            iEnumeratorMethodTwo(i);
        //        }
        //    }
        //}

        //static void iEnumeratorMethodTwo(IEnumerator<string> i) {
        //    while(i.MoveNext()) {
        //        Console.WriteLine(i.Current);
        //    }
        //}
        #endregion
    }
}
