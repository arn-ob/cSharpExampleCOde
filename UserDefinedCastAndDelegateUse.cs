using System;


namespace learnFormEvent
{
    class UserDefinedCastAndDelegateUse
    {
        struct Currency                                                                
        {
            public uint Dollars;
            public ushort Cents;

            public Currency(uint dollars, ushort cents)
            {
                this.Dollars = dollars;
                this.Cents = cents;
            }

            public override string ToString()
            {
                return string.Format("${0}.{1,-2:00}", Dollars, Cents);
            }

            public static string GetCurrencyUnit()
            {
                return "Dollar";
            }


            public static explicit operator Currency(float value)
            {
                checked
                {
                    uint dollers = (uint)value;
                    ushort cents = (ushort)((value - dollers) * 100);
                    return new Currency(dollers, cents);
                }

            }

            public static implicit operator float(Currency value)
            {
                return value.Dollars + (value.Cents / 100f);
            }

            public static implicit operator uint(Currency value)
            {
                return value.Dollars;
            }

        }

        private delegate string GetAString();

        static void Main()
        {
            int x = 40;
            GetAString firstStringMethod = x.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());

            Currency balance = new Currency(34, 50);

            // firstStringMethod ref an instace method
            firstStringMethod = balance.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());

            // firstStringMethod ref a static method
            firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            Console.WriteLine("String is {0}", firstStringMethod());
            Console.ReadLine();

        }

    }
}
