using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnFormEvent
{
    public class GameMove
    {
        private IEnumerator cross;
        private IEnumerator circle;

        public GameMove()
        {
            cross = Cross();
            circle = Circle();

        }

        private int move = 0;

        public IEnumerator Cross()
        {

            while (true)
            {
                Console.WriteLine("Cross , movve {0} ", move);
                move++;
                if (move > 9)
                    yield break;
                yield return circle;
            }

        }

        public IEnumerator Circle()
        {
            while (true)
            {
                Console.WriteLine("Circle , move {0}", move);
                move++;
                if (move > 9)
                    yield break;
                yield return cross;
            }
        }

    }


    class program
    {
        public static void Main()
        {

            GameMove gm = new GameMove();
            IEnumerator emu = gm.Cross();
            while (emu.MoveNext())
            {
                emu = (IEnumerator)emu.Current;
            }
            Console.ReadLine();

        }
    }


}
