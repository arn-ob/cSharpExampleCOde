using System;


namespace learnFormEvent
{
    class MathOparation
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }

        public static double Square(double value)
        {
            return value * value;
        }
    }
    class Program
    {

        delegate double DoubleOp(double x);

        static void ProcessAndDeiplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0}, Result of oparation is {1}", value, result);
        }

        static void Main()
        {
            DoubleOp[] Oparator = { MathOparation.MultiplyByTwo, MathOparation.Square };

            for (int i = 0; i < Oparator.Length; i++)
            {
                Console.WriteLine("Using oparations [ {0} ]", i);
                ProcessAndDeiplayNumber(Oparator[i], 2.0);
                ProcessAndDeiplayNumber(Oparator[i], 7.94);
                ProcessAndDeiplayNumber(Oparator[i], 1.414);
                Console.ReadLine();
            }
        }
    }
}
