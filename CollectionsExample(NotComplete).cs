using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// Not complete program 
    /// this program collect from Collection(Chapter 10 from Professional C# 2008 book )
    /// </summary>
    public class Racer : IComparable<Racer> , IFormattable
    {
        public Racer() : this(String.Empty, String.Empty, String.Empty) { }
        public Racer(string firstName, string lastName, string country) : this(firstName, lastName, country, 0) { }

        public string FirstName { get;set;}
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Win { get; set; }



        public Racer(string firstName, string lastName, string country, int win)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Win = win;
        }


        public override string ToString()
        {
            return string.Format(" {0} {1} ", FirstName, LastName);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format.ToUpper())
            {   
                case null:
                case "N": return ToString();
                case "F": return FirstName;
                case "L": return LastName;
                case "W": return String.Format("{0}, win : {1}",ToString(),Win);
                case "C": return String.Format("{0}, Country : {1}", ToString(), Country);
                case "A": return String.Format("{0},{1} Wins : {2}", ToString(), Country,Win);

                default:
                    throw new FormatException(string.Format(formatProvider, "Format {0} is not supported", format));
            }
        }

        public string ToString(string format)
        {
            return ToString(format,null);
        }

        public int ComaperTo(Racer other)
        {
            int compare = this.LastName.CompareTo(other.LastName);

            if (compare == 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            return compare;
        } 
    }


    class CollectionsExample
    {

        static void Main()
        {
            List<int> intList = new List<int>(10);
            intList.Capacity = 10;
            Console.WriteLine(intList);
            intList.TrimExcess();
            Console.ReadLine();
        }
    }
}
