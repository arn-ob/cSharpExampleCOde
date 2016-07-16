using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    /// <summary>
    /// Not completed :( 
    /// </summary>
    class delegateLearnBasic
    {
        delegate void MeDeleaget();

        static void Main()
        {
            IEnumerable<int> result = GetAllNumberLessThenFive(new[] number = 1,2,58,8);
        }
        static IEnumerable<int> GetAllNumberLessThenFive(IEnumerable<int> number)
        {
            foreach (int numbers in number)
            {
                if (numbers < 5)
                {
                    yield return numbers;
                }
                
            }

        }




    }
}
