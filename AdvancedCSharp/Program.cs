using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace AdvancedCSharp
{
    class Program
    {
        

        static void Main(string[] args)
        {
          

            int[] arr= { 1, 2, 3, 4, 5 };
            A[] arrofA = new A[] { new A(), new A(), new A() };
            List<A> listOfA = new List<A>
            {
                new A(),
                new A(),
                new A()
            };
            Dictionary<int, A> dictionaryOfA = new Dictionary<int, A>
            {
                [1] = new A(),
                [2] = new A(),
                [3] = new A()
            };
            /*dictionary needs a type and __. pass the key into the instance?*/
            var aType = 123.45;
            Console.WriteLine($"THe type of aType is {aType.GetType()}");
            var aTypeOf = typeof(System.String);
            Console.WriteLine($"TypeOf System.String is {aTypeOf}");
            Console.ReadKey();
            /* typeOf is for creating a type from a class. getType is for programmaticaly finding the type of a variable*/

            var str = "X123";
            int nbr;
            int.TryParse(str, out nbr);
            Console.WriteLine($"Nbr is {nbr}");
            /*tryparse is good for telling if the string to nbr converted successfully with the out parameter.
            If a character is in the string it will return 0, if not will return the converted number(why it is bool)*/
            //Console.ReadKey();

            var n = 0;
            Add1(n);
            Console.WriteLine($"N is {n}");
            Add1Ref(ref n);
            Console.WriteLine($"N is {n}");
            //Console.ReadKey();
            // a behind the scenes copy of n is being passed into Add1, var n is never actually changed
        }


        static void Add1(int i)
        {
            i++;
        }
        static void Add1Ref(ref int i)
        {
            i++;
        }
    }
}
