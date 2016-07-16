using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{

    class BubbleSorter
    {
        static public void Sort(object[] sortArray, Comparison Comparison)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length; j++)
                {
                    if (Comparison(sortArray[j], sortArray[i]))
                    {
                        object temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }

            }
        } 
    }


    class Employ
    {
        private string name;
        private decimal salary;

        public Employ(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }


        public override string ToString()
        {
            return string.Format("{0} , {1:C}",name,salary) ;
        }


        public static bool CompareSalary(object x, object y)
        {
            Employ e1 = (Employ)x;
            Employ e2 = (Employ)y;
            return (e1.salary < e2.salary);
        }


    }

    delegate bool Comparison(object x, object y);

    class MainProgram
    {

        static void Main()
        {
            Employ[] employes = {
                                    new Employ("Bugs Bunny ",2000),
                                    new Employ("Elmer Fudd" ,10000),
                                    new Employ("Wiley Coyote", (decimal)100000.38),
                                    new Employ("RoadRunner",20000)
                                };
            BubbleSorter.Sort(employes,Employ.CompareSalary);

            foreach (var employs in employes){
                Console.WriteLine(employs);
                
            }
            Console.ReadLine();
	    }
		 
	}
}

   





