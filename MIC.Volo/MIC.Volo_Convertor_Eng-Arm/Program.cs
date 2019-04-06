using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Volo_Convertor_Eng_Arm
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void TestConvertor()
        {
            string s = Console.ReadLine();
            Console.WriteLine(MyConvertor.Convert(s));
        }
    }
}
