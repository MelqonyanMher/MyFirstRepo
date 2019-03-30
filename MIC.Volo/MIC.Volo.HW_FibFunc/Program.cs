using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;
namespace MIC.Volo.HW_FibFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<BigInteger> a = Fibonacci();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        static IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger temp = a;

            while (true)
            {
                yield return  b;
                temp = a;
                a = b;
                b = a + temp;
                Thread.Sleep(500);
            }
        }
    }
}
